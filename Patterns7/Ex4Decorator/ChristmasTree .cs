using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns7.Ex4Decorator
{
    class ChristmasTree : Tree
    {
        public override void Display()
        {
            Console.WriteLine("Christmas Tree");
        }
    }
}
