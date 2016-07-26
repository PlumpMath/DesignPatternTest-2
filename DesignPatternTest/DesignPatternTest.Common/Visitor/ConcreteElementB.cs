using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class ConcreteElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            Console.WriteLine("ConcreteElementA.Accept");
            visitor.VisitConcreteElementB(this);
        }

        public void OperationB() { }
    }
}
