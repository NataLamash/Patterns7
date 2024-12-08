using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns7.Ex6Composite
{
    class CompositeGraphic : Graphic
    {
        private List<Graphic> _graphics = new List<Graphic>();

        public override void Draw()
        {
            Console.WriteLine("Drawing a Composite Graphic:");
            foreach (var graphic in _graphics)
            {
                graphic.Draw();
            }
        }

        public override void Add(Graphic graphic)
        {
            _graphics.Add(graphic);
        }

        public override void Remove(Graphic graphic)
        {
            _graphics.Remove(graphic);
        }

        public override Graphic GetChild(int index)
        {
            return _graphics[index];
        }
    }
}
