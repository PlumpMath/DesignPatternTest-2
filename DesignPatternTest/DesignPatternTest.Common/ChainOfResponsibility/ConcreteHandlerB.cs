using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class ConcreteHandlerB : CORHandler
    {
        public override void HandleRequest(int request)
        {
            if (request > 10)
            {
                Console.WriteLine("Handled by ConcreteHandlerB");
            }
            else if (_successor != null)
            {
                _successor.HandleRequest(request);
            }
        }
    }
}
