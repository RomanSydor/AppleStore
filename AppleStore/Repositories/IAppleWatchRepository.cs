using AppleStore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppleStore.Repositories
{
    public interface IAppleWatchRepository
    {
        Task<List<AppleWatch>> GetAppleWatchesAsync();
        Task<AppleWatch> GetAppleWatchByIdAsync(int id);
        Task<IEnumerable<AppleWatch>> GetAppleWatchByModelAsync(string model);
    }
}
