using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class AbstractionBridge
    {
        protected ImplementorBridge implementor;

        public ImplementorBridge Implementor
        {
            set
            {
                this.implementor = value;
            }
        }

        public virtual void Operation()
        {
            Console.WriteLine("AbstractionBridge:Operation()");
            implementor.Operation();
        }
    }
}
