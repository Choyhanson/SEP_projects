using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IMovieGenreRepository
    {
        IEnumerable<Genre> GetAllGenres();
        IEnumerable<Genre> GetGenreByMovieId(int movieId);
        IEnumerable<MovieCardResponseModel> GetAllMoviesByGenre(int genreId);
    }
}
