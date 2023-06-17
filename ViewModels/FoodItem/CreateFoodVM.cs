using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

<<<<<<< HEAD:ViewModels/FoodItem/CreateFoodItemVM.cs
namespace FoodOrder.ViewModels.vm
=======
namespace FoodOrdering.ViewModels.foodItem
>>>>>>> e5deb05fd106671b926db696d501229127bfe545:ViewModels/FoodItem/CreateFoodVM.cs
{
    public class CreateFoodVM
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public double Price { get; set; }

        public int SubCategoryId { get; set; }
    }
}