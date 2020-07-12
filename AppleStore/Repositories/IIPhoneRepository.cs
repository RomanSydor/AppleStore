using AppleStore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppleStore.Repositories
{
    public interface IIPhoneRepository
    {
        Task<List<IPhone>> GetIPhonesAsync();
        Task<IPhone> GetIPhoneByIdAsync(int id);
        Task<IEnumerable<IPhone>> GetIPhoneByModelAsync(string model);
        IPhone GetIPhoneByColorAndMemoryAsync(string color, string memory, string model);
    }
}
