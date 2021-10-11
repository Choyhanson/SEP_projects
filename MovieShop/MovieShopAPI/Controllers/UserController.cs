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
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Purchases()
        {
            var userId = _currentUserService.UserId;
            var purchases = await _purchaseService.GetAllPurchasedMoviesByUserId(userId);

            // call the User Service to get movies purchased by user, and send the data to the view, and use the existing MovieCard partial View
            return Ok(purchases);
        }

        [Route("AddPurchase")]
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> PurchaseAction(int movieId, decimal price)
        {
            var userId = _currentUserService.UserId;
            var res = await _purchaseService.PurchaseMovie(userId, movieId, price);
            return Ok("Purchased!");
        }

        [Route("favorites")]
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Favorites()
        {
            var userId = _currentUserService.UserId;
            var purchases = await _movieFavoriteService.GetAllFavoriteMoviesByUserId(userId);

            // call the User Service to get movies purchased by user, and send the data to the view, and use the existing MovieCard partial View
            return Ok(purchases);
        }
        [Route("addfavorites")]
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddFavorite( int movieId)
        {
            var userId = _currentUserService.UserId;
            var favorite = await _movieFavoriteService.AddFavoriteMovie(userId, movieId);

            // call the User Service to get movies purchased by user, and send the data to the view, and use the existing MovieCard partial View
            return Ok(favorite);
        }

        [Route("removefavorites")]
        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> RemoveFavorite( int movieId)
        {
            var userId = _currentUserService.UserId;
            await _movieFavoriteService.RemoveFavoriteMovie(userId, movieId);

            // call the User Service to get movies purchased by user, and send the data to the view, and use the existing MovieCard partial View
            return Ok("Removed!");
        }
    }
}
