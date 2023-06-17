using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodOrdering.Models;
using FoodOrdering.ViewModels;


namespace FoodOrdering.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public int Quintitiy { get; set; }

        // public int FoodItemId { get; set; }
        // public FoodItem FoodItem { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
