using AppleStore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppleStore.Repositories
{
    public class IPadRepository : IIPadRepository
    {
        private readonly DataContext _dataContext;

        public IPadRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IPad> GetIPadByIdAsync(int id)
        {
            return await _dataContext.IPads.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<IPad>> GetIPadByModelAsync(string type)
        {
            var iPads = _dataContext.IPads
                .Where(i => i.TypeOfModel == type);

            return await iPads
                .OrderBy(m => m.Memory)
                .OrderBy(p => p.Price)
                .ToListAsync();
        }

        public async Task<List<IPad>> GetIPadsAsync()
        {
            return await _dataContext.IPads.ToListAsync();
        }
    }
}
