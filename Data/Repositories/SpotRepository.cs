using Domain.Interfaces.Repositories;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class SpotRepository : ISpotRepository
    {
        private readonly SpotMusicContext _context;
        public SpotRepository(SpotMusicContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<SpotModel>> GetAllAsync()
        {
            return await _context.Spots.Include(m => m.MusicoModel).ToListAsync();
        }
        
        public async Task<SpotModel> GetByIdAsync(int id)
        {
            return await _context.Spots
                .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task CreateAsync(SpotModel spotModel)
        {
            _context.Add(spotModel);
            await _context.SaveChangesAsync();
        }
        public async Task EditAsync(SpotModel spotModel)
        {
            _context.Update(spotModel);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var spotModel = await GetByIdAsync(id);

            _context.Spots.Remove(spotModel);
            await _context.SaveChangesAsync();
        }

        

        
    }
}
