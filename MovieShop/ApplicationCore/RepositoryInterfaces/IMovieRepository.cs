using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> Get30HighestGrossingMovies();
        IEnumerable<Movie> GetAllMovies();
        IEnumerable<Movie> GetById(int id);
        Decimal? GetMovieRating(int id);
        IEnumerable<MovieCastModel> GetCastByMovie(int id);
        IEnumerable<Trailer> GetTrailerByMovie(int id);
    }
}
