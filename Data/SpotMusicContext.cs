using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace Data
{
    public class SpotMusicContext : DbContext
    {
        public SpotMusicContext (DbContextOptions<SpotMusicContext> options)
            : base(options)
        {
        }

        public DbSet<MusicoModel> Musicos { get; set; }

        public DbSet<SpotModel> Spots { get; set; }
    }
}
