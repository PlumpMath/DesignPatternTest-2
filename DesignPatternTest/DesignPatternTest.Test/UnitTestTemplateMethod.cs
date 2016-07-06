using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTest.Test
{
    [TestClass]
    public class UnitTestTemplateMethod
    {
        [TestMethod]
        public void TestMethodTemplateMethod()
        {
            var a = new ConcreteTempMethodA();
            a.PrimitiveOperation1();
            a.PrimitiveOperation2();

            var b = new ConcreteTempMethodB();
            b.PrimitiveOperation1();
            b.PrimitiveOperation2();
        }

        [TestMethod]
        public void TestMethodTemplateMethod_Example()
        {
            var a = new TestPaperA();
            a.TestQuestion1();
            a.TestQuestion2();
            a.TestQuestion3();

            var b = new TestPaperA();
            b.TestQuestion1();
            b.TestQuestion2();
            b.TestQuestion3();
        }
    }
}
