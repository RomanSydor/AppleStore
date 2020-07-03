using AppleStore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppleStore.Repositories
{
    public interface IMacRepository
    {
        Task<List<Mac>> GetMacsAsync();
        Task<Mac> GetMacByIdAsync(int id);
    }
}
