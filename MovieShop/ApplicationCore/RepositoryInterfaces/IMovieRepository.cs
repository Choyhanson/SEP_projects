using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IMovieRepository : IAsyncRepository<Movie>
    {
        Task<IEnumerable<Movie>> GetSortByGrossingMovies();
        IEnumerable<MovieCardResponseModel> GetAllMovies();
        Task<IEnumerable<MovieCardResponseModel>> GetAllMoviesAsync();
        IEnumerable<Movie> GetById(int id);
        Task<IEnumerable<Movie>> GetByMovieIdAsync(int id);
        Decimal? GetMovieRating(int id);
        Task<Decimal?> GetMovieRatingAsync(int id);
        IEnumerable<MovieCastModel> GetCastByMovie(int id);
        Task<IEnumerable<MovieCastModel>> GetCastByMovieAsync(int id);
        //Task<IEnumerable<Trailer>> GetTrailerByMovieAsync(int id);
        Task<IEnumerable<MovieTrailerResponseModel>> GetTrailerByMovieAsync(int id);
        IEnumerable<Trailer> GetTrailerByMovie(int id);

    }
}
