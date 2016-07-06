using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class ConcreteImplementorBridgeA : ImplementorBridge
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorBridgeA Operation");
        }
    }
}
