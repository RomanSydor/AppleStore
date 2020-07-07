using AppleStore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppleStore.Repositories
{
    public interface IIPadRepository
    {
        Task<List<IPad>> GetIPadsAsync();
        Task<IPad> GetIPadByIdAsync(int id);
        Task<IEnumerable<IPad>> GetIPadByModelAsync(string type);
    }
}
