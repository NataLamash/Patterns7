using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns7.Ex6Composite
{
    abstract class Graphic
    {
        public abstract void Draw();
        public virtual void Add(Graphic graphic)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Graphic graphic)
        {
            throw new NotImplementedException();
        }

        public virtual Graphic GetChild(int index)
        {
            throw new NotImplementedException();
        }
    }

}
