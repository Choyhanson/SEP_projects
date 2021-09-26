using ApplicationCore.Entities;
using System;
using System.Collections.Generic;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IMovieGenreRepository
    {
        IEnumerable<Genre> GetAllGenres();
        IEnumerable<Genre> GetGenreByMovieId(int movieId);
        IEnumerable<Movie> GetAllMoviesByGenre(int genreId);
    }
}
