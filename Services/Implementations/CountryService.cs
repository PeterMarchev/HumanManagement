using AutoMapper;
using Data;
using HumanManagement.Data.Patterns;
using Services.Interfaces;
using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementations
{
    public class CountryService : ICountryService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public CountryService(IMapper mapper, IUnitOfWork uow)
        {
            _mapper = mapper;
            _uow = uow;
        }



        public List<CountrySM> GetAllCountries()
        {
            var countries = _uow.GetRepository<Country>().GetAll();
            var mapping = _mapper.Map<List<Country>, List<CountrySM>>(countries);
            return mapping;
        }

        public async Task CreateCountryAsync(CountrySM newCountry)
        {
            try
            {
                _uow.BeginTransaction();
                var country = _mapper.Map<Country>(newCountry);
                await _uow.GetRepository<Country>().AddItemAsync(country);
                _uow.Commit();
            }
            catch
            {
                _uow.Rollback();
            }
        }

        public async Task<bool> UpdateCountryAsync(CountrySM country)
        {
            try
            {
                _uow.BeginTransaction();

                var updateCountry = _mapper.Map<Country>(country);
                await _uow.GetRepository<Country>().UpdateAsync(updateCountry);

                _uow.Commit();
                return true;
            }
            catch (Exception)
            {
                _uow.Rollback();
                throw;
            }
        }

        public async Task<bool> DeleteCountryAsync(Guid id)
        {
            try
            {
                _uow.BeginTransaction();
                var country = await _uow.GetRepository<Country>().GetSingleAsync(i => i.Id == id);
                if (country == null)
                {
                    return false;
                }
                await _uow.GetRepository<Country>().DeleteAsync(country);

                _uow.Commit();
                return true;
            }
            catch
            {
                _uow.Rollback();
                throw;
            }

        }

        public async Task<CountrySM> GetCountryByIdAsync(object id)
        {
            var country = await _uow.GetRepository<Country>().GetByIdAsync(id);
            var mapping = _mapper.Map<Country, CountrySM>(country);
            return mapping;
        }
    }
}
