using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternTest.Common;

namespace DesignPatternTest.Test
{
    [TestClass]
    public class UnitTestAdapter
    {
        //http://www.dotnetperls.com/factory

        [TestMethod]
        public void TestMethodAdapter()
        {
            ITarget adapter = new MyAdapter();
            adapter.Request();
        }
    }
}
