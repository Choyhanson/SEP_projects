using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.ServiceInterfaces;
namespace MovieShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public HomeController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [Route("homepage")]
        [HttpGet]
        public async Task<IActionResult> Index(int Page=1,string Sort = "default") 
        {
            var table = await _movieService.GetAllMoviesAsync(Page, Sort);
            return Ok(table);
    }
    }
}
