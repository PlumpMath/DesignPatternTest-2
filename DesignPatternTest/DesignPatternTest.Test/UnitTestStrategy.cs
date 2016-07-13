using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTest.Test
{
    [TestClass]
    public class UnitTestStrategy
    {
        [TestMethod]
        public void TestMethodStrategy()
        {
            StrategyContext context;
            context = new StrategyContext(new ConcreteStrategyA());
            context.ContextInterface();

            context = new StrategyContext(new ConcreteStrategyB());
            context.ContextInterface();
        }

        [TestMethod]
        public void TestMethodStrategy_Example()
        {
            double total = 0d;
            total += SetType(CashType.Normal, 1, 1);
            total += SetType(CashType.Return, 600, 1);
            total += SetType(CashType.Rebate, 1000, 1);
            Console.WriteLine(total);
        }

        private double SetType(CashType type, double price, double num)
        {
            CashSuper cashsuper = CashFactory.createCashAccept(type);

            double totalPrices = 0d;
            totalPrices = cashsuper.AcceptCash(price * num);

            return totalPrices;
        }
    }
}
