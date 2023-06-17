using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrdering.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
        public User User{ get; set; }
    }
}