using ApplicationCore.Entities;
using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
   public class TableViewModel
    {
        public IEnumerable<MovieCardByIdModel> Movies { get; set; }
        public IEnumerable<MovieCardResponseModel> Genres { get; set; }
        public decimal? Rating { get; set; }
        public IEnumerable<MovieCastModel> Casts { get; set; }
        public IEnumerable<Trailer> Trailers { get; set; }
        public int TotalItemNum { get; set; }
        public int CurrentPage { get; set; }
        public int GenreId { get; set; }
    }
}
