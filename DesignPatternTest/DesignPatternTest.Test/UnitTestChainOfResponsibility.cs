using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTest.Test
{
    [TestClass]
    public class UnitTestChainOfResponsibility
    {
        [TestMethod]
        public void TestMethod_ChainOfResponsibility()
        {
            var a = new ConcreteHandlerA();
            var b = new ConcreteHandlerB();

            a.SetSuccessor(b);

            foreach (var item in new[] { 1, 13 })
            {
                a.HandleRequest(item);
            }
        }

        [TestMethod]
        public void TestMethod_ChainOfResponsibility_Example()
        {
            CommonManager c = new CommonManager("jj");

            MajorDemo m = new MajorDemo("ken");

            GeneralManager g = new GeneralManager("lin");

            c.SetSuperior(m);

            m.SetSuperior(g);

            CORRequest r = new CORRequest() { RequestType = "請假", RequestContent = "Tan請假", Number = 1 };

            c.RequestApplications(r);

            CORRequest r2 = new CORRequest() { RequestType = "請假", RequestContent = "Tan請假", Number = 4 };

            c.RequestApplications(r2);

            CORRequest r3 = new CORRequest() { RequestType = "加薪", RequestContent = "Tan請求加薪", Number = 500 };

            c.RequestApplications(r3);

            CORRequest r4 = new CORRequest() { RequestType = "加薪", RequestContent = "Tan請求加薪", Number = 1000 };

            c.RequestApplications(r4);

        }
    }
}
