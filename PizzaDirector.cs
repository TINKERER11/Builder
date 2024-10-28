using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class PizzaDirector
    {
        private readonly IPizzaBuilder _builder;

        public PizzaDirector(IPizzaBuilder builder)
        {
            _builder = builder;
        }

        public Pizza MakeMargheritaPizza()
        {
            _builder.SetDough("Thin crust");
            _builder.SetSauce("Tomato sauce");
            _builder.AddTopping("Mozzarella cheese");
            _builder.AddTopping("Basil");
            return _builder.Build();
        }

        public Pizza MakePeperoniPizza()
        {
            _builder.SetDough("Thick crust");
            _builder.SetSauce("Barbecue sauce");
            _builder.AddTopping("Pepperoni");
            _builder.AddTopping("Mozzarella cheese");
            return _builder.Build();
        }
    }
}
