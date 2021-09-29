using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShopMVC.Controllers
{
    public class UserController : Controller
    {

        private readonly IMovieService _movieService;
        private readonly IMovieGenreService _movieGenreService;
        public UserController(IMovieService movieService, IMovieGenreService movieGenreService)
        {
            _movieService = movieService;
            _movieGenreService = movieGenreService;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
            ViewBag.Genres = _movieGenreService.GetAllGenres();
            ViewBag.Method = _movieGenreService;
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
