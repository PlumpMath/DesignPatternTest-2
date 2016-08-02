using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public abstract class Decorator : DComponent
    {
        protected DComponent component;

        public void SetComponent(DComponent component)
        {
            this.component = component;
        }


        public override void Operation()
        {
            if (this.component == null)
            {
                Console.WriteLine("Component Operation");
                this.component.Operation();
            }
        }
    }
}
