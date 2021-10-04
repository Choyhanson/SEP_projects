using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models;
namespace ApplicationCore.ServiceInterfaces
{
    public interface IFavoriteService
    {
        Task <IEnumerable<MovieFavoriteResponseModel>> GetAllFavoriteMoviesByUserId(int userId);
        Task<bool> IsFavoritedMovie(int userId, int movieId);
        Task<MovieFavoriteResponseModel> AddFavoriteMovie(int userId, int movieId);
        Task RemoveFavoriteMovie(int userId, int movieId);
    }
}
