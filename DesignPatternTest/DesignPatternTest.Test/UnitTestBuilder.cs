using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

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

        [TestMethod]
        public void TestStringBuilder()
        {
            StringBuilder s = new StringBuilder();
            s.Append("1 ");
            s.Append("2 ");
            s.Append("3 ");
            Console.WriteLine(s.ToString());
        }

    }
}
