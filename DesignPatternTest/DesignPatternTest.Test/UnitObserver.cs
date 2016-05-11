using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternTest.Common;

namespace DesignPatternTest.Test
{
    [TestClass]
    public class UnitObserver
    {
        //當一群物件間有一對多的相依關係時，當被依者物件的資料改變時，會通知其他依靠者物件以作出回應

        [TestMethod]
        public void TestObserver()
        {
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "x"));
            s.Attach(new ConcreteObserver(s, "y"));
            s.Attach(new ConcreteObserver(s, "z"));

            s.SubjectState = "abc";

            s.Notify();

        }

        [TestMethod]
        public void TestObserver_Example()
        {
            Boss myBoss = new Boss();

            StockObserver tongshi1 = new StockObserver("leo", myBoss);

            NBAObserver tongshi2 = new NBAObserver("ken", myBoss);

            myBoss.Update += new MyEventHandler(tongshi1.CloseStockMarket);
            myBoss.Update += new MyEventHandler(tongshi2.CloseNBADirectSeeding);

            myBoss.SubjectState = "I'm come back!!! ";
            myBoss.Notify();
        }
    }
}
