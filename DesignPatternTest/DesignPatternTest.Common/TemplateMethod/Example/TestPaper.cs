using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class TestPaper
    {
        public void TestQuestion1()
        {
            Console.WriteLine("Q1");
            Console.WriteLine("Ans:" + Answer1());
        }

        public void TestQuestion2()
        {
            Console.WriteLine("Q2");
            Console.WriteLine("Ans:" + Answer2());
        }

        public void TestQuestion3()
        {
            Console.WriteLine("Q3");
            Console.WriteLine("Ans:" + Answer3());
        }

        protected virtual string Answer1()
        {
            return "";
        }

        protected virtual string Answer2()
        {
            return "";
        }

        protected virtual string Answer3()
        {
            return "";
        }
    }
}
