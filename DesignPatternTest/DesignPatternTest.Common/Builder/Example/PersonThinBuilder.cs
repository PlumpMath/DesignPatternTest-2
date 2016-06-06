using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class PersonThinBuilder : PersonBuilder
    {
        private string p;

        public PersonThinBuilder(string p)
            : base(p)
        {
            this.p = p;
        }

        public override void BuildHead()
        {
            p += "頭 ";
        }

        public override void BuildBody()
        {
            p += "身體 ";
        }

        public override void BuildArmLeft()
        {
            p += "左手 ";
        }

        public override void BuildArmRight()
        {
            p += "右手 ";
        }

        public override void BuildLegLeft()
        {
            p += "左腳 ";
        }

        public override void BuildLegRight()
        {
            p += "右腳 ";
        }

        public override string GetResult()
        {
            return p;
        }
    }
}
