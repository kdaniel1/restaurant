using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurants.Models;

namespace Restaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();
            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                restaurantList.Add($"Rank: { r.Rank} Restaurant Name: {r.RestaurantName} Favorite Dish: {r.FavDish} Address: {r.Address} Restaurant Phone #: {r.PhoneNumber} Link to Website: {r.Website}");
            }
            
            return View(restaurantList);
        }
        //Takes user to the add a restaurant page
        [HttpGet]
        public IActionResult AddRestaurant()
        {
            return View();
        }
        // with the HttpPost it makes sure the model state is valid then loads
        //the confirmation page, else it allows the user to fix any errors.

        [HttpPost]
        public IActionResult AddRestaurant(ApplicationResponse appResponse)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddApplication(appResponse);
                return View("ConfirmationPage", appResponse);
            }
            return View(appResponse);
        }

        //Allows user to see past entries
        public IActionResult UserInput()
        {
            return View(TempStorage.Applications);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
