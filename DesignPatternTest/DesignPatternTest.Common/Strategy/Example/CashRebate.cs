using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;
        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }
        public override double AcceptCash(double money)
        {
            return money * this.moneyRebate;
        }
    }
}
