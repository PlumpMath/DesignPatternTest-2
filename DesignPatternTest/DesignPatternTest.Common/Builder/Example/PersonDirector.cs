using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class PersonDirector
    {
        private PersonBuilder pb;

        public PersonDirector(PersonBuilder builder)
        {
            this.pb = builder;
        }

        public void CreatePersion()
        {
            pb.BuildHead();
            pb.BuildBody();
            pb.BuildArmLeft();
            pb.BuildArmRight();
            pb.BuildLegLeft();
            pb.BuildLegRight();
        }

        public string GetResult()
        {
            return pb.GetResult();
        }
    }
}
