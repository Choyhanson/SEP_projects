using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
   public interface IMovieGenreService
    {
        IEnumerable<MovieCardResponseModel> GetAllGenres();
        Task<IEnumerable<MovieCardResponseModel>> GetAllGenresAsync();
        IEnumerable<MovieCardResponseModel> GetGenreByMovieId(int movieId);
        Task<IEnumerable<MovieCardResponseModel> >GetGenreByMovieIdAsync(int movieId);
        IEnumerable<MovieCardResponseModel> SortDisplay(IEnumerable<MovieCardResponseModel>movieModel, string Sort = "default");
        Task<TableViewModel> GetAllMoviesByGenreAsync(int id, int Page = 1, string Sort = "default");
        TableViewModel GetAllMoviesByGenre(int id, int Page = 1, string Sort = "default");
    }
}
