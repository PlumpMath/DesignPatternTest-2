using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class VObjectStructure
    {
        private IList<VisitPerson> elements = new List<VisitPerson>();

        public void Attach(VisitPerson element)
        {
            this.elements.Add(element);
        }

        public void Detach(VisitPerson element)
        {
            this.elements.Remove(element);
        }

        public void Display(VisitAction visitor)
        {
            foreach (VisitPerson e in elements)
            {
                e.Accept(visitor);
            }
        }
    }
}
