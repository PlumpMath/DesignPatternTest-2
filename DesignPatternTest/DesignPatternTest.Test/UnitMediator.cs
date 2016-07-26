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
            ConcreteMediator m = new ConcreteMediator();

            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);

            m.Colleague1 = c1;
            m.Colleague2 = c2;

            c1.Send("How are you?");
            c2.Send("Fine, thanks");
        }

        [TestMethod]
        public void TestMethodMediator_Example()
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
