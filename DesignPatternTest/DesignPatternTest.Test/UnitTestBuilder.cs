using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTest.Test
{
    [TestClass]
    public class UnitTestBuilder
    {
        [TestMethod]
        public void TestMethodBuilder()
        {
            var builderDirector = new CarBuilderDirector();
            Car c = builderDirector.Construct();
            Assert.AreEqual(c.Wheels, 4);
            Assert.AreEqual(c.Color, "Red");
        }

        [TestMethod]
        public void TestMethodBuilder_Example()
        {
            string p = "Leo ";
            var ptb = new PersonThinBuilder(p);
            var pd = new PersonDirector(ptb);
            pd.CreatePersion();
            Console.WriteLine(pd.GetResult());

        }
    }
}
