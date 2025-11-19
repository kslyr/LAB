using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Dish : MenuItem
    {
        public string Category { get; set; }
        public override void Display()
        {
            Console.WriteLine($"- {Name} ({Category}) - {Price:C}");
        }
    }
}
