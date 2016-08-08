using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class ConcreteHandlerA : CORHandler
    {
        public override void HandleRequest(int request)
        {
            if (request == 1)
            {
                Console.WriteLine("Handled by ConcreteHandlerA");
            }
            else if (_successor != null)
            {
                _successor.HandleRequest(request);
            }
        }
    }
}
