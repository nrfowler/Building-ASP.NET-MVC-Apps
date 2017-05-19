using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class Restaurant
    {
        public int Id;
        public string Name;
        public string City;
        public string Country;
        public ICollection<RestaurantReview> Reviews;

    }
}