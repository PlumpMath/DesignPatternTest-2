using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class ConcreteTempMethodB : AbstractTempMethod
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteTempMethodB.PrimitiveOperation1()");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteTempMethodB.PrimitiveOperation2()");
        }
    }
}
