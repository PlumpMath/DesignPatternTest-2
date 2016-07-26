using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class VisitWoman : VisitPerson
    {
        public override void Accept(VisitAction visitor)
        {
            Console.WriteLine("VisitWoman.Accept");
            visitor.GetWomanConclusion(this);
        }
    }
}
