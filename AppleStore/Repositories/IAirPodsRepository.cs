using AppleStore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppleStore.Repositories
{
    public interface IAirPodsRepository
    {
        Task<List<AirPods>> GetAirPodsesAsync();
        Task<AirPods> GetAirPodsByIdAsync(int id);
    }
}
