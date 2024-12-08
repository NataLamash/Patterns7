using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns7.Ex4Decorator
{
    abstract class TreeDecorator : Tree

    {
        protected Tree _tree;

        public TreeDecorator(Tree tree)
        {
            _tree = tree;
        }

        public override void Display()
        {
            _tree.Display();
        }
    }
}
