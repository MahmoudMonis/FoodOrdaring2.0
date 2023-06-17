using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrdering.Model
{
    public class FoodItem
    {
        public int FoodItemId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public SubCategory subcategory { get; set; }

        public int SubcategoryId { get; set; }

    }
}