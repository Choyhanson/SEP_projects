﻿using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using System;
using System.Collections.Generic;

namespace Infrastructure.Repositories
{
    class MovieRepository : IMovieRepository
    {
        public IEnumerable<Movie> Get30HighestGrossingMovies()
        {
            //go to database and execute SP, SPL
            var movies = new List<Movie> 
            {
                new Movie {Id =1, Title="Inception", PosterUrl="Inception.jpg",Revenue=825532764},
                new Movie {Id =2, Title="Interstellar", PosterUrl="Interstellar.jpg",Revenue=825532764},
                new Movie {Id =3, Title="The Dark Knight", PosterUrl="The_Dark_Knight.jpg",Revenue=825532764}
            };
            return movies;
        }
    }
}
