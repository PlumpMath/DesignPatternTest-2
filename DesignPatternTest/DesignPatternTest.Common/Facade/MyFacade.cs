using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class MyFacade
    {
        private readonly SubsystemA a = new SubsystemA();
        private readonly SubsystemB b = new SubsystemB();
        private readonly SubsystemC c = new SubsystemC();

        public void Operation1()
        {
            Console.WriteLine("Operation 1\n" +
                a.OperationA1() +
                a.OperationA2() +
                b.OperationB1());
        }
        public void Operation2()
        {
            Console.WriteLine("Operation 2\n" +
                b.OperationB2() +
                c.OperationC1() +
                c.OperationC2());
        }
    }
}
