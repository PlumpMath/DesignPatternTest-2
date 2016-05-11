using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternTest.Common;

namespace DesignPatternTest.Test
{
    [TestClass]
    public class UnitTestComposite
    {
        //http://www.dotnetperls.com/factory

        [TestMethod]
        public void TestMethodComposite()
        {
            /*
             */
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("root");
            comp.Add(new Leaf("Leaf xA"));
            comp.Add(new Leaf("Leaf xB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            root.Display(1);
        }

        [TestMethod]
        public void TestMethodCompositeExample()
        {
            var root = new ConcreteCompany("高雄總公司");
            root.Add(new HRDept("高雄人資"));
            root.Add(new FinanceDept("高雄財務部"));

            var comp = new ConcreteCompany("台北分公司");
            comp.Add(new HRDept("台北人資"));
            comp.Add(new FinanceDept("台北財務部"));
            root.Add(comp);

            var comp1 = new ConcreteCompany("信義辦事處");
            comp1.Add(new HRDept("信義人資"));
            comp1.Add(new FinanceDept("信義財務部"));
            comp.Add(comp1);


            var comp2 = new ConcreteCompany("三重辦事處");
            comp2.Add(new HRDept("三重人資"));
            comp2.Add(new FinanceDept("三重財務部"));
            comp.Add(comp2);

            Console.WriteLine("結構圖");
            root.Display(1);

            Console.WriteLine("職責");
            root.LineOfDuty();
        }
    }
}
