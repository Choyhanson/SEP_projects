using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IMovieService
    {   // Models
        IEnumerable<MovieCardResponseModel> GetSortByHighestMovies();
        TableViewModel GetAllMovies(int Page=1,string Sort="defalut");
        IEnumerable<MovieCardByIdModel> GetCardByIdModels(int id);
    }
}
