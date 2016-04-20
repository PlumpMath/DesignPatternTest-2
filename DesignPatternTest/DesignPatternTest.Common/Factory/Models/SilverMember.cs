using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public class SilverMember : Member
    {
        public override string Name
        {
            get { return MemberType.Silver.ToString(); }
        }
    }
}
