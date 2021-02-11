using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Restaurants.Models
{
    public class TempStorage
    {
        private static List<ApplicationResponse> applications = new List<ApplicationResponse>();
        public static IEnumerable<ApplicationResponse> Applications => applications;
        public static void AddApplication(ApplicationResponse application) => applications.Add(application);

    }
}
