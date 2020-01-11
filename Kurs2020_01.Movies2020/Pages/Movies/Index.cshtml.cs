using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Kurs2020_01.Movies2020.Data;
using Kurs2020_01.Movies2020.Movies;

namespace Kurs2020_01.Movies2020
{
    public class IndexModel : PageModel
    {
        private readonly Kurs2020_01.Movies2020.Data.MoviesContext _context;

        public IndexModel(Kurs2020_01.Movies2020.Data.MoviesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
