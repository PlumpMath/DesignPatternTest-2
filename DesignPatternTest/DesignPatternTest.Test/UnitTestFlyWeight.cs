using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTest.Test
{
    [TestClass]
    public class UnitTestFlyWeight
    {
        [TestMethod]
        public void TestMethodFlyWeight_Example()
        {
            FWebSiteFactory f = new FWebSiteFactory();
            var fx = f.GetWebSiteCategory("Product Demo");
            fx.Use(new FUser("Leoli"));

            var fy = f.GetWebSiteCategory("Blog");
            fy.Use(new FUser("Perry"));

            Console.WriteLine("網站數：{0}", f.GetWebsiteCount());
        }
    }
}
