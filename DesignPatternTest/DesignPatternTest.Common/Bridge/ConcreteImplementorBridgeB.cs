using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class ConcreteImplementorBridgeB : ImplementorBridge
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorBridgeB Operation");
        }
    }
}
