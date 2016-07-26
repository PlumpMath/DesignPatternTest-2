using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class VisitFail : VisitAction
    {
        public override void GetManConclusion(VisitMan concreteElementA)
        {
            Console.WriteLine("VisitFail.GetManConclusion");
        }

        public override void GetWomanConclusion(VisitWoman concreteElementB)
        {
            Console.WriteLine("VisitFail.GetWomanConclusion");
        }
    }
}
