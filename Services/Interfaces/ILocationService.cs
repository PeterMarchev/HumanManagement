using Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ILocationService
    {
        List<LocationSM> GetAllLocations();
        Task UpdateLocationAsync(LocationSM location);
        Task CreateLocationAsync(LocationSM newLocation);
        Task<bool> DeleteLocationAsync(Guid id);
        Task<LocationSM> GetLocationByIdAsync(object id);
    }
}
