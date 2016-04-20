using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public class GoldMember : Member
    {
        public override string Name
        {
            get { return MemberType.Gold.ToString(); }
        }
    }
}
