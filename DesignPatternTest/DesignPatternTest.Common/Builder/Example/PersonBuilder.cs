using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public abstract class PersonBuilder
    {
        public PersonBuilder(string p)
        {

        }

        public abstract void BuildHead();

        public abstract void BuildBody();

        public abstract void BuildArmLeft();

        public abstract void BuildArmRight();

        public abstract void BuildLegLeft();

        public abstract void BuildLegRight();

        public abstract string GetResult();
    }
}
