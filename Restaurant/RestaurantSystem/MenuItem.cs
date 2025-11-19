using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public abstract class MenuItem : IDisplayable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public abstract void Display();
    }
}
