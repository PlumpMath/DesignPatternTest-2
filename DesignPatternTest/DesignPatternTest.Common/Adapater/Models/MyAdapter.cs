using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public class MyAdapter : Adaptee, ITarget
    {
        public void Request()
        {
            base.SpecificRequest();
        }
    }
}
