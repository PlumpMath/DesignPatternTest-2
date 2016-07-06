using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class RefinedAbstraction : AbstractionBridge
    {
        public override void Operation()
        {
            Console.WriteLine("RefinedAbstraction:Operation()");
            implementor.Operation();
        }
    }
}
