using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns7.Ex2Builder
{
    class BuilderExample
    {
        public static void Main(String[] args)
        {
            Waiter waiter = new Waiter();

            PizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
            waiter.SetPizzaBuilder(hawaiianPizzaBuilder);
            waiter.ConstructPizza();
            Pizza hawaiianPizza = waiter.GetPizza();
            Console.WriteLine("Hawaiian Pizza:");
            hawaiianPizza.Info();

            Console.WriteLine();

            PizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();
            waiter.SetPizzaBuilder(spicyPizzaBuilder);
            waiter.ConstructPizza();
            Pizza spicyPizza = waiter.GetPizza();
            Console.WriteLine("Spicy Pizza:");
            spicyPizza.Info();

            Console.WriteLine();

            PizzaBuilder margaritaPizzaBuilder = new MargaritaPizzaBuilder();
            waiter.SetPizzaBuilder(margaritaPizzaBuilder);
            waiter.ConstructPizza();
            Pizza margaritaPizza = waiter.GetPizza();
            Console.WriteLine("Margarita Pizza:");
            margaritaPizza.Info();

            Console.ReadKey();
        }
    }
}
