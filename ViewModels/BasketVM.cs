using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrder.ViewModels
{
    public class BasketVM1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FoodItemVM FoodItem{ get; set; }
    }
}