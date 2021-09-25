using ApplicationCore.Models;
using System;
using System.Collections.Generic;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IMovieService
    {   // Models
        IEnumerable<MovieCardResponseModel> Get30HighestMovies();
        IEnumerable<MovieCardResponseModel> GetAllMovies();
        IEnumerable<MovieCardByIdModel> GetCardByIdModels(int id);
    }
}
