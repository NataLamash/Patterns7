using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns7.Ex4Decorator
{
    class OrnamentDecorator : TreeDecorator
    {
        private string _ornament;

        public OrnamentDecorator(Tree tree, string ornament) : base(tree)
        {
            _ornament = ornament;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Decorated with: {_ornament}");
        }
    }
}
