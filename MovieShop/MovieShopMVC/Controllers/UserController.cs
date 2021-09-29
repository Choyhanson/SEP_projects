using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;


namespace MovieShopMVC.Controllers
{
    public class UserController : BaseController
    {

        public UserController(IMovieService movieService, IMovieGenreService movieGenreService):base(movieService, movieGenreService)
        {
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
