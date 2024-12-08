using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns7.Ex3Mediator
{
    class MainApp
    {
        static void Main()
        {
            ConcreteMediator m = new ConcreteMediator();
            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);
            ConcreteColleague3 c3 = new ConcreteColleague3(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;
            m.Colleague3 = c3;

            c1.Send("How are you?");
            c2.Send("Fine, thanks");
            c3.Send("Hello!");

            // Wait for user
            Console.Read();
        }
    }
}
