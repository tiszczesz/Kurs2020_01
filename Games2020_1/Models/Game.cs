using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Games2020_1.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime YearProd { get; set; }
        virtual public Genre Genre { get; set; }
        virtual public int GenreId { get; set; }
    }
}
