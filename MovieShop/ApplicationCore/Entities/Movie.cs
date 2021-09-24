using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        [MaxLength(64)]
        public string Title { get; set; }
        public string Overview { get; set; }
        public string Tagline { get; set; }
        public decimal? Budget { get; set; }
        public decimal? Revenue { get; set; }
        public string ImdbUrl { get; set; }
        public string TmdbUrl { get; set; }
        public string PosterUrl { get; set; }
        public string BackdropUrl { get; set; }
        [MaxLength(64)]
        public string OriginalLanguage { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? RunTime { get; set; }
        public decimal? Price { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [MaxLength(64)]
        public string UpdatedBy { get; set; }
        [MaxLength(64)]
        public string CreatedBy { get; set; }
        public decimal? Rating { get; set; }


        public ICollection<Trailer> Trailers { get; set; }
        public ICollection<MovieGenre> Genre { get; set; }
        public ICollection<MovieCrew> Crews { get; set; }
        public ICollection<MovieCast> Casts { get; set; }
        public ICollection<Purchase> Users { get; set; }
        public ICollection<Review> UserReview { get; set; }
        public ICollection<Favorite> UserFavorite { get; set; }
    }
}
