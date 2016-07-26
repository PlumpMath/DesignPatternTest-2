using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class VisitSuccess : VisitAction
    {
        public override void GetManConclusion(VisitMan concreteElementA)
        {
            Console.WriteLine("VisitSuccess.GetManConclusion");
        }

        public override void GetWomanConclusion(VisitWoman concreteElementB)
        {
            Console.WriteLine("VisitSuccess.GetWomanConclusion");
        }
    }
}
