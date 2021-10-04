using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class MovieFavoriteResponseModel
    {
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public string MoviePosterUrl { get; set; }
        public DateTime FavoriteDate { get; set; }
    }
}
