using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public interface IPizzaBuilder
    {
        void SetDough(string dough);
        void SetSauce(string sauce);
        void AddTopping(string topping);
        Pizza Build();
    }
}
