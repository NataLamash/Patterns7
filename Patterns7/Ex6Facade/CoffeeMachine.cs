using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns7.Ex6Facade
{
    class CoffeeMachine
    {
        private CoffeeGrinder _grinder;
        private CoffeeMaker _coffeeMaker;
        private MilkFrother _milkFrother;

        public CoffeeMachine()
        {
            _grinder = new CoffeeGrinder();
            _coffeeMaker = new CoffeeMaker();
            _milkFrother = new MilkFrother();
        }

        public void MakeEspresso()
        {
            Console.WriteLine("\nPreparing Espresso:");
            _grinder.GrindBeans();
            _coffeeMaker.BrewCoffee();
            Console.WriteLine("Espresso is ready!");
        }

        public void MakeCappuccino()
        {
            Console.WriteLine("\nPreparing Cappuccino:");
            _grinder.GrindBeans();
            _coffeeMaker.BrewCoffee();
            _milkFrother.FrothMilk();
            Console.WriteLine("Cappuccino is ready!");
        }
    }
}
