using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.ServiceInterfaces;
using Infrastructure.Repositories;
using ApplicationCore.Models;
using Infrastructure.Data;
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services
{
    public class MovieFavoriteService : EFRepository<Favorite>, IFavoriteService
    {
        public MovieFavoriteService(MovieShopDbContext dbContext):base(dbContext)
        {
        }
        public async Task<MovieFavoriteResponseModel> AddFavoriteMovie(int userId, int movieId)
        {
            var newFavorite = new Favorite
            {
                UserId = userId,
                MovieId = movieId
            };
            var createFavorite = await AddAsync(newFavorite);
            var movieFavoriteResponseModel = new MovieFavoriteResponseModel
            {
                UserId = createFavorite.UserId,
                MovieId = createFavorite.MovieId
            };
            return movieFavoriteResponseModel;
        }

        public async Task<IEnumerable<MovieFavoriteResponseModel>> GetAllFavoriteMoviesByUserId(int userId)
        {
            var favorites = await _movieShopDbContext.Favorites.Where(f => f.UserId==userId).Include(f => f.Movie).ToListAsync();

            var res = new List<MovieFavoriteResponseModel>();
            foreach (var item in favorites)
            {
                res.Add(new MovieFavoriteResponseModel 
                { 
                    UserId=item.UserId,
                    MovieId=item.MovieId,
                    MoviePosterUrl=item.Movie.PosterUrl,
                    FavoriteDate=DateTime.Now
                });
            }
            return  res.OrderByDescending(f => f.FavoriteDate);
        }

        public async Task<bool> IsFavoritedMovie(int userId, int movieId)
        {
            var favorites = await _movieShopDbContext.Favorites.Where(f => f.UserId == userId).ToListAsync();
            var res = favorites.Any(f => f.MovieId == movieId);
            return res;
        }

        public async Task RemoveFavoriteMovie(int userId, int movieId)
        {
            var Id = _movieShopDbContext.Favorites.Where(x => x.MovieId == movieId && x.UserId == userId).Select(x => x.Id).FirstOrDefault();
            var entity = await GetByIdAsync(Id);
            var removeFavorite = new Favorite
            {
                Id = entity.Id,
                UserId = userId,
                MovieId = movieId
            };
            await DeleteAsync(removeFavorite);
            
        }
    }
}
