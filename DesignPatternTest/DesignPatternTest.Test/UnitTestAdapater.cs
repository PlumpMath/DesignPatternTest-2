using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternTest.Common;

namespace DesignPatternTest.Test
{
    [TestClass]
    public class UnitTestAdapter
    {
        //http://www.dotnetperls.com/factory

        [TestMethod]
        public void TestMethodAdapter()
        {
            /*在設計模式中，介面卡模式（英語：adapter pattern）有時候也稱包裝樣式或者包裝(wrapper)。
             * 將一個類別的介面轉接成使用者所期待的。一個適配使得因介面不相容而不能在一起工作的類別工作在一起
             * ，做法是將類別自己的介面包裹在一個已存在的類別中。
             */
            ITarget adapter = new MyAdapter();
            adapter.Request();
        }
    }
}
