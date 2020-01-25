using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Games2020_1.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Game> Games { get; set; }
    }
}
