using AppleStore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppleStore.Repositories
{
    public class IPhoneRepository : IIPhoneRepository
    {
        private readonly DataContext _dataContext;

        public IPhoneRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<IPhone>> GetIPhonesAsync()
        {
            return await _dataContext.IPhones.ToListAsync();
        }

        public async Task<IEnumerable<IPhone>> GetIPhoneByModelAsync(string model)
        {
            var iPhones =  _dataContext.IPhones
                .Where(i => i.IPhoneModel == model);

            return await iPhones
                .OrderBy(m => m.Memory)
                .OrderBy(p => p.Price)
                .ToListAsync();
        }

        public async Task<IPhone> GetIPhoneByIdAsync(int id)
        {
            return await _dataContext.IPhones.SingleOrDefaultAsync(d => d.Id == id);
        }

        public IPhone GetIPhoneByColorAndMemoryAsync(string color, string memory, string model)
        {
            return _dataContext.IPhones
                .SingleOrDefault(i => i.Color == color && i.Memory == memory && i.IPhoneModel == model);
        }
    }
}
