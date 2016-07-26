using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class TW : MCountry
    {
        public TW(UnitNations mediator)
            : base(mediator)
        {

        }

        public void Declare(string message)
        {
            mediator.Declare(message, this);
        }

        public void GetMessage(string message)
        {
            Console.WriteLine("TW.GetMessage " + message);
        }
    }
}
