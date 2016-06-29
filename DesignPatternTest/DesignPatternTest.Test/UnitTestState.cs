using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternTest.Common;

namespace DesignPatternTest.Test
{
    [TestClass]
    public class UnitTestState
    {
        [TestMethod]
        public void TestState()
        {
            Context c = new Context(new ConcreteStateA());
            c.Request();
            c.Request();
            c.Request();
            c.Request();
        }

        [TestMethod]
        public void TestState_Example()
        {
            PlayerState user = new PlayerState();
            user.level = 19;
            user.StateWork();
            user.level = 62;
            user.StateWork();
            user.level = 93;
            user.StateWork();
        }

    }
}
