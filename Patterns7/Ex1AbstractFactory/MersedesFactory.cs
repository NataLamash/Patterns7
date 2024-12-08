using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Patterns7.Ex1AbstractFactory
{
    public class MersedesFactory : ICarFactory

    {
        Car ICarFactory.CreateCar()
        {
            return new Mersedes();
        }

        Engine ICarFactory.CreateEngine()
        {
            return new MersedesEngine();
        }
    }
}
