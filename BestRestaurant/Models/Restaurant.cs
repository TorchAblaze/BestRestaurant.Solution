namespace BestRestaurant.Models
{
    public class Restaurant
    {
        public int CuisineId { get; set; }
        public virtual Cuisine Cuisine { get; set; }
    }
}