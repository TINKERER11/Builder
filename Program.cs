namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPizzaBuilder builder = new ConcretePizzaBuilder();
            PizzaDirector director = new PizzaDirector(builder);

            Pizza margherita = director.MakeMargheritaPizza();
            Console.WriteLine(margherita);

            Pizza peperoni = director.MakePeperoniPizza();
            Console.WriteLine(peperoni);
        }
    }
}
