using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Patterns7.Ex1AbstractFactory
{
    public interface ICarFactory
    {
        Car CreateCar();
        Engine CreateEngine();
    }
}
