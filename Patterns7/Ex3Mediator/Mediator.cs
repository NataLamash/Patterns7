using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns7.Ex3Mediator
{
    abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}
