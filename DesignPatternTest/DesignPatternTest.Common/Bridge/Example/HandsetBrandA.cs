using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class HandsetBrandA : HandsetBrand
    {
        public HandsetBrandA()
        {
            Console.WriteLine("HandsetBrandA");
        }

        public override void Run()
        {
            soft.Run();
        }
    }
}
