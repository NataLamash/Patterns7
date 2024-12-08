using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns7.Ex6Composite
{
    class Program61
    {
        static void Main(string[] args)
        {
            Graphic circle1 = new Circle();
            Graphic circle2 = new Circle();
            Graphic rectangle1 = new Rectangle();

            CompositeGraphic composite = new CompositeGraphic();
            composite.Add(circle1);
            composite.Add(circle2);
            composite.Add(rectangle1);

            CompositeGraphic composite2 = new CompositeGraphic();
            composite2.Add(new Rectangle());
            composite2.Add(composite); 

            Console.WriteLine("Drawing first composite:");
            composite.Draw();

            Console.WriteLine("\nDrawing second composite:");
            composite2.Draw();

            Console.ReadKey();
        }
    }
}
