using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public enum CashType
    {
        /// <summary>
        /// 正常收費
        /// </summary>
        Normal,
        /// <summary>
        /// 滿300送100
        /// </summary>
        Return,
        /// <summary>
        /// 打八折
        /// </summary>
        Rebate
    }

    public class CashFactory
    {
        public static CashSuper createCashAccept(CashType type)
        {
            CashSuper cs = null;
            switch (type)
            {
                case CashType.Normal:
                    cs = new CashNormal();
                    break;
                case CashType.Return:
                    CashReturn cr = new CashReturn("300", "100");
                    cs = cr;
                    break;
                case CashType.Rebate:
                    CashRebate cr2 = new CashRebate("0.8");
                    cs = cr2;
                    break;
                default:
                    break;
            }
            return cs;
        }
    }
}
