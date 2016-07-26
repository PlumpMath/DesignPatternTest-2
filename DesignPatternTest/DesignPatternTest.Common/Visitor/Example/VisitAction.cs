using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public abstract class VisitAction
    {
        public abstract void GetManConclusion(VisitMan concreteElementA);

        public abstract void GetWomanConclusion(VisitWoman concreteElementB);
    }
}
