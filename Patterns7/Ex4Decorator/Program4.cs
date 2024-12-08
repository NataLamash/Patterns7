using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns7.Ex4Decorator
{
    class Program4
    {
        static void Main(string[] args)
        {
            Tree tree = new ChristmasTree();

            tree = new OrnamentDecorator(tree, "Red Balls");
            tree = new OrnamentDecorator(tree, "Golden Stars");

            tree = new GarlandDecorator(tree);

            tree.Display();

            Console.ReadKey();
        }
    }
}
