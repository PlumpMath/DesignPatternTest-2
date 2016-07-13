using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class HandsetBrandI : HandsetBrand
    {
        public HandsetBrandI()
        {
            Console.WriteLine("HandsetBrandI");
        }

        public override void Run()
        {
            soft.Run();
        }
    }
}
