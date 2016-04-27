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
            root.Add(new Leaf("Left A"));
            root.Add(new Leaf("Left B"));

            Composite comp = new Composite("root");
            comp.Add(new Leaf("Left xA"));
            comp.Add(new Leaf("Left xB"));

            root.Add(comp);
            root.Add(new Leaf("Left C"));

            Leaf leaf = new Leaf("Left D");
            root.Add(leaf);
            root.Remove(leaf);

            root.Display(1);
        }
    }
}
