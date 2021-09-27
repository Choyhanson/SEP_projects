using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class MovieCardResponseModel
    {
        public int MovieId { get; set; }
        public decimal Revenue { get; set; }
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public string MovieTitle { get; set; }
        public string MoviePosterUrl { get; set; }
        public int Pages { get; set; }
    }
}
