using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Restaurants.Models
{
    public class Restaurant
    {
        //contructor
        public Restaurant(int rank)
        {
            Rank = rank;
        }
        [Required]
        public int Rank { get; }
        [Required]
        public string RestaurantName { get; set; }
        public string FavDish { get; set; } = "It's all tasty!";
        [Required]
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; } = "Coming soon.";

    public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                RestaurantName = "Cubbys",
                FavDish = "Sweet Potato Fries",
                Address = "1258 N State St, Provo, UT 84604",
                PhoneNumber = "801-919-3023",
                Website = "www.cubbys.co",
            };

            Restaurant r2 = new Restaurant(2)
            {
                RestaurantName = "Bombay House",
                FavDish = "Paneer Tikka Masala",
                Address = "463 N University Ave, Provo, UT 84601",
                PhoneNumber = "801-373-6677",
                Website = "www.bombayhouse.com",
            };

            Restaurant r3 = new Restaurant(3)
            {
                RestaurantName = "Vegan Sun",
                Address = "225 W Center St, Provo, UT 84601",
                PhoneNumber = "801-375-0807",
               
            };

            Restaurant r4 = new Restaurant(4)
            {
                RestaurantName = "Thai Neighbor Cuisine #1",
                Address = "170 W 300 S, Provo, UT 84601",
                PhoneNumber = "385-223-8169",
                Website = "www.thaineighborcuisine1.com",
            };

            Restaurant r5 = new Restaurant(5)
            {
                RestaurantName = "Guru's Cafe",
                Address = "45 E Center St, Provo, UT 84606",
                PhoneNumber = "801-375-4878",
                Website = "www.guruscafe.com",
            };

            return new Restaurant[] { r1,r2,r3,r4,r5 };
        }


    }
}
