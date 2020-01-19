using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{ Id=1, Name="Scott's Pizza", Location="MaryLand", Cuisine=CuisineType.Indian},
                new Restaurant{ Id=2, Name="Cinnamon Club", Location="London", Cuisine=CuisineType.Italian},
                new Restaurant{ Id=3, Name="La Costa", Location="California", Cuisine=CuisineType.Mexican}
            };
        }

        public Restaurant GetRestaurantById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetRestaurantByName(string name)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }
}
