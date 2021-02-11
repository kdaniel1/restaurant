using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Restaurants.Models
{
    public class ApplicationResponse
    {
        //this model takes the user data, makes sure it has everything needed to validate the model
        [Required]
        #nullable disable
        public string Name { get; set; }
        [Required]
        #nullable disable
        public string Restaurant { get; set; }
        #nullable disable
        [Required]
        public string FavDish { get; set; } = "They're all tasty!";
        [Required]
        [RegularExpression(@"^[2-9]\d{2}-\d{3}-\d{4}$", ErrorMessage = "Phone number should be in the following format: XXX-XXX-XXXX")]
        #nullable disable
        public string PhoneNumber { get; set; }
        #nullable enable
        public string? Website { get; set; }
    }
}
