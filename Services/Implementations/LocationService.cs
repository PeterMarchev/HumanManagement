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
        public class LocationService : ILocationService
        {
            private readonly IMapper _mapper;
            private readonly IUnitOfWork _uow;

            public LocationService(IUnitOfWork uow, IMapper mapper)
            {
                _uow = uow;
                _mapper = mapper;
            }

            public List<LocationSM> GetAllLocations()
            {
                var locations = _uow.GetRepository<Location>().GetAll();
                var mapping = _mapper.Map<List<Location>, List<LocationSM>>(locations);
                return mapping;
            }

            public async Task CreateLocationAsync(LocationSM newLocation)
            {
                try
                {
                    _uow.BeginTransaction();
                    var location = _mapper.Map<Location>(newLocation);
                    await _uow.GetRepository<Location>().AddItemAsync(location);
                    _uow.Commit();
                }
                catch
                {
                    _uow.Rollback();
                }
            }

            public async Task UpdateLocationAsync(LocationSM location)
            {
                try
                {
                    _uow.BeginTransaction();

                    var updateLocation = _mapper.Map<Location>(location);
                    await _uow.GetRepository<Location>().UpdateAsync(updateLocation);

                    _uow.Commit();

                }
                catch (Exception)
                {
                    _uow.Rollback();
                }
            }

            public async Task<bool> DeleteLocationAsync(Guid id)
            {
                try
                {
                    _uow.BeginTransaction();
                    var location = await _uow.GetRepository<Location>().GetSingleAsync(i => i.Id == id);
                    if (location == null)
                    {
                        return false;
                    }
                    await _uow.GetRepository<Location>().DeleteAsync(location);

                    _uow.Commit();
                    return true;
                }
                catch
                {
                    _uow.Rollback();
                    throw;
                }

            }

            public async Task<LocationSM> GetLocationByIdAsync(object id)
            {
                var location = await _uow.GetRepository<Location>().GetByIdAsync(id);
                var mapping = _mapper.Map<Location, LocationSM>(location);
                return mapping;
            }

        }
    }

