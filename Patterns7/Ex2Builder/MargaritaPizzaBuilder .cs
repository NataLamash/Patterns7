using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns7.Ex2Builder
{
    class MargaritaPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough() { pizza.SetDough("thin crust"); }
        public override void BuildSauce() { pizza.SetSauce("tomato"); }
        public override void BuildTopping() { pizza.SetTopping("mozzarella+basil"); }
    }
}
