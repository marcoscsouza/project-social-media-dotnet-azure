﻿using Domain.Interfaces.Repositories;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Azure.Documents;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class MusicoRepository : IMusicoRepository
    {
        private readonly SpotMusicContext _context;
        public MusicoRepository(SpotMusicContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MusicoModel>> GetAllAsync(string userId)
        {

            return await _context.Musicos.Where(x => x.UserId == userId).ToListAsync();
        }

        public async Task<MusicoModel> GetByIdAsync(int id)
        {
            return await _context.Musicos.AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task CreateAsync(MusicoModel musicoModel)
        {
            _context.Add(musicoModel);
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(MusicoModel musicoModel)
        {
            _context.Update(musicoModel);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var musicoModel = await GetByIdAsync(id);
            _context.Musicos.Remove(musicoModel);
            await _context.SaveChangesAsync();
        }
        public async Task<MusicoModel> GetProfileByUserIdAsync(string userId)
        {
            return await _context.Musicos
                                        .FirstOrDefaultAsync(x => x.UserId == userId);
        }
    }
}
