using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns7.Ex6Facade
{
    internal class Program62
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();

            coffeeMachine.MakeEspresso();

            coffeeMachine.MakeCappuccino();

            Console.ReadKey();
        }
    }
}
