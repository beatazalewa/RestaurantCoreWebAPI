using Microsoft.AspNetCore.Mvc;
using RestaurantCoreWebAPI.Server.Models;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantCoreWebAPI.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private List<Restaurant> _restaurants = new List<Restaurant>();

        public RestaurantController()
        {
            _restaurants.Add(new Restaurant() { Id = 1, Name = "Very Modern Restaurant", Address = "1882  State Street", IsOpen = true, Speciality = "French cuisine", Review = 3 });
            _restaurants.Add(new Restaurant() { Id = 2, Name = "Food Land", Address = "4122  Aaron Smith Drive", IsOpen = true, Speciality = "Sushi", Review = 5 });
        }

        [HttpGet("{id}")]
        public ActionResult<Restaurant>GetRestaurantById(int id)
        {
            Restaurant restaurant = _restaurants.SingleOrDefault(p => p.Id == id);
            if (restaurant == null)
            {
                return NotFound();
            }
            return restaurant;
        }

        [HttpPost]
        public ActionResult<Restaurant> Create(Restaurant restaurant)
        {
            int restaurantMaxId = _restaurants.Max(g => g.Id);
            restaurant.Id = ++restaurantMaxId;
            _restaurants.Add(restaurant);
            return CreatedAtAction(nameof(GetRestaurantById), new { id = restaurant.Id }, restaurant);
        }
    }
}



























