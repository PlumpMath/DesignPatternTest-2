using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class TestPaperA : TestPaper
    {
        protected override string Answer1()
        {
            return "A1";
        }

        protected override string Answer2()
        {
            return "A2";
        }

        protected override string Answer3()
        {
            return "A3";
        }

    }
}
