using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public class ConcreteCompany : Company
    {
        private List<Company> children = new List<Company>();

        public ConcreteCompany(string name)
            : base(name)
        {
        }

        public override void Add(Company c)
        {
            this.children.Add(c);
        }

        public override void Remove(Company c)
        {
            this.children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (var component in this.children)
            {
                component.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (var component in this.children)
            {
                component.LineOfDuty();
            }
        }
    }
}
