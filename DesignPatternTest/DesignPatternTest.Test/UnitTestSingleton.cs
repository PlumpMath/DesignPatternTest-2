using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternTest.Common;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatternTest.Test
{
    [TestClass]
    public class UnitTestSingleton
    {
        //https://msdn.microsoft.com/zh-tw/library/ff650316.aspx
        //http://csharpindepth.com/Articles/General/Singleton.aspx

        //https://msdn.microsoft.com/zh-tw/library/88c54tsw.aspx
        //sealed 類別(Class)不能被繼承，或宣告sealed method 不能被子類別 override

        [TestMethod]
        public void TestNormalSingleton_GetInstance()
        {
            Assert.IsNotNull(NonThreadSingleton.Instance);
        }

        [TestMethod]
        public void TestInitSingleton_GetInstance()
        {
            Assert.IsNotNull(InitSingleton.Instance);
        }

        [TestMethod]
        public void TestMultiTheadedSingleton_GetInstance()
        {
            Assert.IsNotNull(MultiTheadedSingleton.Instance);
        }

        [TestMethod]
        public void TestLazySingleton_GetInstance()
        {
            Assert.IsNotNull(LazySingleton.Instance);
        }

        [TestMethod]
        public void TestEqual()
        {
            var a = new Test();
            var b = new Test();
            Assert.AreNotEqual(a, b);

            Assert.AreEqual(NonThreadSingleton.Instance, NonThreadSingleton.Instance);
            Assert.AreEqual(InitSingleton.Instance, InitSingleton.Instance);
            Assert.AreEqual(MultiTheadedSingleton.Instance, MultiTheadedSingleton.Instance);
            Assert.AreEqual(LazySingleton.Instance, LazySingleton.Instance);
        }

        [TestMethod]
        public void TestTask()
        {
            var task1 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("t1:", NonThreadSingleton.Instance != null);
                Console.WriteLine("Done!(task1)");
            });
            var task2 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("t2:", NonThreadSingleton.Instance != null);
                Console.WriteLine("Done!(task2)");
            });

            Task.WaitAll(task1, task2);
            Console.WriteLine("WaitAll Passed");
        }

        [TestMethod]
        public void TestTask2()
        {
            var task1 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("t1:", MultiTheadedSingleton.Instance != null);
                Console.WriteLine("Done!(task1)");
            });
            var task2 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("t2:", MultiTheadedSingleton.Instance != null);
                Console.WriteLine("Done!(task2)");
            });

            Task.WaitAll(task1, task2);
            Console.WriteLine("WaitAll Passed");
        }

        [TestMethod]
        public void TestTask3()
        {
            var task1 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("t1:", MultiTheadedSingleton.Instance2 != null);
                Console.WriteLine("Done!(task1)");
            });
            var task2 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("t2:", MultiTheadedSingleton.Instance2 != null);
                Console.WriteLine("Done!(task2)");
            });

            Task.WaitAll(task1, task2);
            Console.WriteLine("WaitAll Passed");
        }
        #region
        private class Test
        {

        }
        #endregion
    }
}
