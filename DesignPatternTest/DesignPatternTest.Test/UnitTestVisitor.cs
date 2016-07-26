using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTest.Test
{
    [TestClass]
    public class UnitTestVisitor
    {
        [TestMethod]
        public void TestMethodVisitor()
        {
            VisitObjectStructure o = new VisitObjectStructure();
            o.Attach(new ConcreteElementA());
            o.Attach(new ConcreteElementB());

            var v1 = new ConcreteVisitor1();
            var v2 = new ConcreteVisitor2();

            o.Accept(v1);
            o.Accept(v2);
        }

        [TestMethod]
        public void TestMethodVisitor_example()
        {
            VObjectStructure o = new VObjectStructure();
            o.Attach(new VisitMan());
            o.Attach(new VisitWoman());

            VisitSuccess v1 = new VisitSuccess();
            o.Display(v1);

            VisitFail v2 = new VisitFail();
            o.Display(v2);
        }
    }
}
