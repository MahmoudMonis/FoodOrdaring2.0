using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrdering.Models
{
    public class FoodItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
<<<<<<< HEAD
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
=======

        public SubCategory subcategory { get; set; }

        public int SubcategoryId { get; set; }

>>>>>>> e5deb05fd106671b926db696d501229127bfe545
    }
}