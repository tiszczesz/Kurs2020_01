using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Games2020_1.Models;

namespace Games2020_1.Data
{
    public class GameContexDb : DbContext
    {
        public GameContexDb(DbContextOptions<GameContexDb> options) :base(options)
        {                
        }
        public DbSet<Game> Games { get; set; }

        public DbSet<Genre> Genres { get; set; }
    }
}
