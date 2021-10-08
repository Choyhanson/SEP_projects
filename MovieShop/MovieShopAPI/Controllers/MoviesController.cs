using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieShopAPI.Controllers
{
    // Attribute Routing
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IMovieGenreService _movieGenreService;
        public MoviesController(IMovieService movieService, IMovieGenreService movieGenreService)
        {
            _movieService = movieService;
            _movieGenreService = movieGenreService;
        }

        [Route("toprevenue")]
        [HttpGet]
        public async Task<IActionResult> GetTopRevenueMovies()
        {
            var movies = await _movieService.GetSortByHighestMovies();
            if (!movies.Any())
            {
                return NotFound("No Movies Found");
            }
            // 200 OK
            return Ok(movies);
            // Serialization => object to another type of project
            // C# to JSON or C# to XML using XMLSerilizer
            // DeSerialization => JSON to C#
            // .NET Core we have JSON.NET => 3rd party library
            // After .NET Core 3.1, using System.Text.Json
            // along with data you also need to return HTTP status code
        }

        [Route("{id:int}",Name ="GetMovie")]
        [HttpGet]
        public async Task<IActionResult>Details(int id)
        {
            var movie = await _movieService.GetMovieDetailAsync(id);
            return Ok(movie);
        }
        [Route("genre")]
        [HttpGet]
        public async Task<IActionResult> GenreViews(int genreId, int Page=1, string Sort = "default")
        {
            var table = await _movieGenreService.GetAllMoviesByGenreAsync(genreId, Page, Sort);

            return Ok(table);
        }
    }
}
