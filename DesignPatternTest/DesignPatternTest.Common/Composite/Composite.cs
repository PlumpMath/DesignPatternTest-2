using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public class Composite : Component
    {
        private List<Component> _children = new List<Component>();

        public Composite(string name)
            : base(name)
        {

        }
        public override void Add(Component c)
        {
            this._children.Add(c);
        }

        public override void Remove(Component c)
        {
            this._children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + this.name);

            foreach (var component in this._children)
            {
                component.Display(depth + 2);
            }
        }
    }
}
