using ApplicationCore.Entities;
using System;
using System.Collections.Generic;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> Get30HighestGrossingMovies();
        IEnumerable<Movie> GetAllMovies();
        IEnumerable<Movie> GetById(int id);
    }
}
