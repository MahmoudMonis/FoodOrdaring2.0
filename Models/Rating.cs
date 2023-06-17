namespace FoodOrdering.Models;

public class Rating
{
    public int Id { get; set; }
    public int Rate { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
    public int FoodItemId { get; set; }
    public FoodItem FoodItem { get; set; }
}
