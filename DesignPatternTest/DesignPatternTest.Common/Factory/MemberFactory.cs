using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public enum MemberType
    {
        Normal,
        Silver,
        Gold
    }

    public static class MemberFactory
    {
        public static Member GetMember(MemberType type)
        {
            switch (type)
            {
                case MemberType.Normal:
                    return new NormalMember();
                case MemberType.Silver:
                    return new SilverMember();
                case MemberType.Gold:
                    return new GoldMember();
                default:
                    return null;
            }
        }
    }
}
