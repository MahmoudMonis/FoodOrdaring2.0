using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrder.ViewModels
{
    public class RatingVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UsersVM users { get; set; }
    }
}