using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTest.Test
{
    [TestClass]
    public class UnitMediator
    {
        [TestMethod]
        public void TestMethodMediator()
        {
            UnitedNationsSecurityCouncil UNSC = new UnitedNationsSecurityCouncil();
            TW c1 = new TW(UNSC);
            JP c2 = new JP(UNSC);

            UNSC.colleague1 = c1;
            UNSC.colleague2 = c2;

            c1.Declare("YA");
            c2.Declare("I love TW");
        }
    }
}
