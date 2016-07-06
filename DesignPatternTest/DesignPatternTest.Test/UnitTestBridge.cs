using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTest.Test
{
    [TestClass]
    public class UnitTestBridge
    {
        [TestMethod]
        public void TestMethodBridge()
        {
            AbstractionBridge ab = new RefinedAbstraction();
            ab.Implementor = new ConcreteImplementorBridgeA();
            ab.Operation();

            ab.Implementor = new ConcreteImplementorBridgeB();
            ab.Operation();


        }
    }
}
