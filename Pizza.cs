using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; private set; } = new List<string>();

        public override string ToString()
        {
            return $"Pizza with {Dough} dough, sauce and toppings: {string.Join(", ", Toppings)}";
        }
    }
}
