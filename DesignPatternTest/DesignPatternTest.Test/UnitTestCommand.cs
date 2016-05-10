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
            var d = new Random((int)DateTime.Now.Ticks);

            for (var i = 0; i < 5; i++)
            {
                string arg = (d.Next(1, 100)) % 2 == 0 ? "ON" : "OFF";

                ISwitchable lamp = new Light();

                ICommand switchClose = new CloseSwitchCommand(lamp);
                ICommand switchOpen = new OpenSwitchCommand(lamp);

                Switch _switch = new Switch(switchClose, switchOpen);

                if (arg == "ON")
                {
                    _switch.Close();
                }
                else if (arg == "OFF")
                {
                    _switch.Open();
                }
                else
                {
                    Console.WriteLine("Argument \"ON\" or \"OFF\" is required.");
                }
            }
        }

        [TestMethod]
        public void TestMethodCommand_Example2()
        {
            Cook chef = new Cook();
            Command2 bakeMuttonCommand1 = new BakeMuttonCommand(chef);
            Command2 bakeMuttonCommand2 = new BakeMuttonCommand(chef);
            Command2 bakeChickenWingCommand1 = new BakeChickenWingCommand(chef);
            Waiter girl = new Waiter();
            
            girl.SetOrder(bakeMuttonCommand1);
            girl.SetOrder(bakeMuttonCommand2);
            girl.SetOrder(bakeChickenWingCommand1);

            girl.Notify();
        }
    }
}
