using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IMovieGenreRepository
    {
        IEnumerable<Genre> GetAllGenres();
        Task<IEnumerable<Genre>> GetAllGenresAsync();
        IEnumerable<Genre> GetGenreByMovieId(int movieId);
        Task<IEnumerable<Genre>> GetGenreByMovieIdAsync(int movieId);
        IEnumerable<MovieCardResponseModel> GetAllMoviesByGenre(int genreId);
        Task<IEnumerable<MovieCardResponseModel> >GetAllMoviesByGenreAsync(int genreId);
    }
}
