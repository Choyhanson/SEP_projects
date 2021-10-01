using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IMovieService
    {   // Models
       Task<IEnumerable<MovieCardResponseModel>> GetSortByHighestMovies();
       TableViewModel GetAllMovies(int Page=1,string Sort="defalut");
       Task<TableViewModel >GetAllMoviesAsync(int Page=1,string Sort="defalut");
        IEnumerable<MovieCardByIdModel> GetCardByIdModels(int id);
      TableViewModel GetMovieDetail(int id);
        //Task<TableViewModel> GetAllMovies(int Page = 1, string Sort = "defalut");
        //Task<IEnumerable<MovieCardByIdModel>> GetCardByIdModels(int id);
        Task<TableViewModel> GetMovieDetailAsync(int id);
    }
}
