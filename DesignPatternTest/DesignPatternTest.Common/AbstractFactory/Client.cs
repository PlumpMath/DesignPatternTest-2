using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class Client
    {
        private AbstractProductA pa;
        private AbstractProductB pb;

        public Client(IAbstractFactory factory)
        {
            pa = factory.CreateProductA();
            pb = factory.CreateProductB();
        }


    }
}
