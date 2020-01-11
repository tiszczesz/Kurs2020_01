﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly Kurs2020_01.Movies2020.Data.MoviesContext _context;

        public DetailsModel(Kurs2020_01.Movies2020.Data.MoviesContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
