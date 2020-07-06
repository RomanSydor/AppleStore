using AppleStore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppleStore.Repositories
{
    public class MacRepository : IMacRepository
    {
        private readonly DataContext _dataContext;

        public MacRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Mac>> GetMacsAsync()
        {
            return await _dataContext.Macs.ToListAsync();
        }
        public async Task<Mac> GetMacByIdAsync(int id)
        {
            return await _dataContext.Macs.SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<Mac>> GetMacByModelAsync(string type)
        {
            var macs = _dataContext.Macs
                .Where(m => m.Type == type);

            return await macs
                .OrderBy(m => m.Memory)
                .OrderBy(p => p.Price)
                .ToListAsync();
        }
    }
}
