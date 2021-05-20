using System.Collections.Generic;

namespace BestRestaurant.Models
{
    public class Cuisine
    {
        public Cuisine()
        {
            this.Restaurants = new HashSet<Restaurant>();
        }
        // public int Id { get; set; }
        public int Entrees { get; set; }

        public string Type { get; set; }

        public int CuisineId { get; set; }
        
        public virtual ICollection<Restaurant> Restaurants { get; set; }
    }
}