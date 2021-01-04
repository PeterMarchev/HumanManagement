using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ICountryService
    {
        List<CountrySM> GetAllCountries();
        Task<bool> UpdateCountryAsync(CountrySM country);
        Task CreateCountryAsync(CountrySM newCountry);
        Task<bool> DeleteCountryAsync(Guid id);
        Task<CountrySM> GetCountryByIdAsync(object id);
    }
}
