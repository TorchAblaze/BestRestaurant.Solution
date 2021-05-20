namespace BestRestaurant.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public int Rating { get; set; }
    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine { get; set; }

    public string StarRating()
    {
      string starRating = "";
      if (Rating > 0)
      {
        for (int i = 1; i <= Rating; i++)
        {
          starRating += "⭐ ";
        }
      }
      return starRating;
    }
  }
}