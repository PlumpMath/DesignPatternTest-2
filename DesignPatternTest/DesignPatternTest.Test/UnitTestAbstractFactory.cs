using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTest.Test
{
    [TestClass]
    public class UnitTestAbstractFactory
    {
        [TestMethod]
        public void TestMethodAbstractFactory()
        {
            IAbstractFactory factoryA = new ConcreteFactoryA();
            IAbstractFactory factoryB = new ConcreteFactoryB();

            var clientA = new Client(factoryA);
            var clientB = new Client(factoryB);
        }

        [TestMethod]
        public void TestMethod_Example()
        {
            ICommonFactory factory = new SqlCommonFactory();
            IUser iu = factory.CreateUser();
            iu.Insert(new User() { Id = 2, Name = "leoli" });
            iu.GetUser(1);
        }
    }
}
