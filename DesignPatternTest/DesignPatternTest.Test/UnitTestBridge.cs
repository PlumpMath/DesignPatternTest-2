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

        [TestMethod]
        public void TestMethodBridge_Example()
        {
            HandsetBrand hb;
            hb = new HandsetBrandA();
            hb.SetHandsetSoft(new HandsetLine());
            hb.Run();

            hb.SetHandsetSoft(new HandsetGame());
            hb.Run();

            hb = new HandsetBrandI();
            hb.SetHandsetSoft(new HandsetLine());
            hb.Run();

        }
    }
}
