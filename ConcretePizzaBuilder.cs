using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class ConcretePizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public void SetDough(string dough)
        {
            _pizza.Dough = dough;
        }

        public void SetSauce(string sauce)
        {
            _pizza.Sauce = sauce;
        }

        public void AddTopping(string topping)
        {
            _pizza.Toppings.Add(topping);
        }
        public Pizza Build()
        {
            return _pizza;
        }
    }
}
