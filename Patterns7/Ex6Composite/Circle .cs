using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns7.Ex6Composite
{
    class Circle : Graphic
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }
}
