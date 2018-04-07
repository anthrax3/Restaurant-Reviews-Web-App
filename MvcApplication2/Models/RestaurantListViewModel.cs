using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class RestaurantListViewModel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Id { get; set; }
        public int CountOfReviews { get; set; }
        public string RestaurantImage { get; set; }
    }
}