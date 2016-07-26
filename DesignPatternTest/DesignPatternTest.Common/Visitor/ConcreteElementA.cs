using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            Console.WriteLine("ConcreteElementA.Accept");
            visitor.VisitConcreteElementA(this);
        }


        public void OperationA() { }
    }
}
