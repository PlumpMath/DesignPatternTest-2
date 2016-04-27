using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternTest.Common;

namespace DesignPatternTest.Test
{
    [TestClass]
    public class UnitTestCommand
    {
        //http://www.dotnetperls.com/factory

        [TestMethod]
        public void TestMethodCommand()
        {
            Command c = new ConcreteCommand(new Receiver());
            Invoker invoker = new Invoker();
            invoker.SetCommand(c);
            invoker.ExecuteCommand();
        }

        [TestMethod]
        public void TestMethodCommand_Example()
        {

        }
    }
}
