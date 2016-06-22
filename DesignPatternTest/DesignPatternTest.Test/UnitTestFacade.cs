using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTest.Test
{
    [TestClass]
    public class UnitTestFacade
    {
        [TestMethod]
        public void TestMethodFacade()
        {
            var f = new MyFacade();
            f.Operation1();
            f.Operation2();
        }

        [TestMethod]
        public void MyTestMethodFacade()
        {
            var cf = new CarFacade();
            cf.CreateCompleteCar();
        }
    }
}
