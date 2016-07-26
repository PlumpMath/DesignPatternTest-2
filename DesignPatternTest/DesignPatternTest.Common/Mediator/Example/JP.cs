using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class JP: MCountry
    {
        public JP(UnitNations mediator)
            : base(mediator)
        {

        }

        public void Declare(string message)
        {
            mediator.Declare(message, this);
        }

        public void GetMessage(string message)
        {
            Console.WriteLine("JP.GetMessage " + message);
        }
    }
}
