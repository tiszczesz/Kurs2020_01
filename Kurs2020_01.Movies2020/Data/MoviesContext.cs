using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kurs2020_01.Movies2020.Movies;

namespace Kurs2020_01.Movies2020.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext (DbContextOptions<MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Kurs2020_01.Movies2020.Movies.Movie> Movie { get; set; }
    }
}
