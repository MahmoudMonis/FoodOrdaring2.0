using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrdering.Models;

namespace FoodOrdering.Models;

public class BasketItem
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public int BasketId { get; set; }
    public Basket Basket { get; set; }
    public int FoodItemId { get; set; }
    public FoodItem FoodItem { get; set; }
}