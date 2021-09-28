using ApplicationCore.Models;
using System;
using System.Collections.Generic;

namespace ApplicationCore.ServiceInterfaces
{
   public interface IMovieGenreService
    {
        IEnumerable<MovieCardResponseModel> GetAllGenres();
        IEnumerable<MovieCardResponseModel> GetGenreByMovieId(int movieId);
        IEnumerable<MovieCardResponseModel> SortDisplay(IEnumerable<MovieCardResponseModel>movieModel, string Sort = "default");
    }
}
