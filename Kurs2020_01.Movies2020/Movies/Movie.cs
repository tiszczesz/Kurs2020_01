using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Kurs2020_01.Movies2020.Movies
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Tytuł")]
        [Required(ErrorMessage = "Podaj tytuł")]
        public string Title { get; set; }

        [Display(Name = "Rodzaj filmu")]
        [Required(ErrorMessage = "Podaj rodzaj filmu")]
        public string Genre { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data realizacji")]
        public DateTime ReleaseDate { get; set; }


        [Display(Name = "Cena")]
        public decimal Price { get; set; }
    }
}
