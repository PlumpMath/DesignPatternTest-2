using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class TestPaperB : TestPaper
    {
        protected override string Answer1()
        {
            return "B1";
        }

        protected override string Answer2()
        {
            return "B2";
        }

        protected override string Answer3()
        {
            return "B3";
        }
    }
}
