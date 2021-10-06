using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ICurrentUserService _currentUserService;
        private readonly IPurchaseService _purchaseService;
        private readonly IFavoriteService _movieFavoriteService;

        public UserController(IFavoriteService movieFavoriteService, IPurchaseService purchaseService, IMovieService movieService, IMovieGenreService movieGenreService, IUserService userService, ICurrentUserService currentUserService)
           
        {
            _userService = userService;
            _currentUserService = currentUserService;
            _purchaseService = purchaseService;
            _movieFavoriteService = movieFavoriteService;
        }

        [Route("purchases")]
        //[Authorize]
        [HttpGet]
        public async Task<IActionResult> Purchases()
        {
            var userId = _currentUserService.UserId;
            var purchases = await _purchaseService.GetAllPurchasedMoviesByUserId(49826);
            //var purchases = await _purchaseService.GetAllPurchasedMoviesByUserId(userId);

            // call the User Service to get movies purchased by user, and send the data to the view, and use the existing MovieCard partial View
            return Ok(purchases);
        }
    }
}
