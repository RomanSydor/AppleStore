﻿using AppleStore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppleStore.Repositories
{
    public class AppleWatchRepository : IAppleWatchRepository
    {
        private DataContext _dataContext;

        public AppleWatchRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<AppleWatch> GetAppleWatchByIdAsync(int id)
        {
            return await _dataContext.AppleWatches.SingleOrDefaultAsync(w => w.Id == id);
        }

        public async Task<IEnumerable<AppleWatch>> GetAppleWatchByModelAsync(string model)
        {
            var watches = _dataContext.AppleWatches
                .Where(m => m.AppleWatchModel == model);

            return await watches
                .OrderBy(ss => ss.ScreenSize)
                .OrderBy(p => p.Price)
                .ToListAsync();
        }

        public async Task<List<AppleWatch>> GetAppleWatchesAsync()
        {
            return await _dataContext.AppleWatches.ToListAsync();
        }

        public AppleWatch GetWatchByColorAndSize(int size, string color, string model, string celluar)
        {
            return _dataContext.AppleWatches
                .SingleOrDefault(w => w.ScreenSize == size && w.Color == color &&
                w.AppleWatchModel == model && w.Cellular == celluar);
        }
    }
}
