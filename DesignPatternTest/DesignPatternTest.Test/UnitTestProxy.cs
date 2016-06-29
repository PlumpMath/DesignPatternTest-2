using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternTest.Common;

namespace DesignPatternTest.Test
{
    [TestClass]
    public class UnitTestProxy
    {
        [TestMethod]
        public void TestProxy()
        {
            IBus b = new ProxyBus(new Driver(16));
            b.DriveCar();

            IBus b2 = new ProxyBus(new Driver(25));
            b.DriveCar();
        }
    }
}
