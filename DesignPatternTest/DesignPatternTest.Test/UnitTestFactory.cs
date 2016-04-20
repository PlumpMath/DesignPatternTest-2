using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternTest.Common;

namespace DesignPatternTest.Test
{
    [TestClass]
    public class UnitTestFactory
    {
        [TestMethod]
        public void TestMethodGet()
        {
            var member = MemberFactory.GetMember(MemberType.Normal);
            Assert.AreEqual(member.Name, MemberType.Normal.ToString());
        }
    }
}
