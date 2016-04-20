using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Hello Adaptee!!");
        }
    }
}
