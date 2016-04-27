using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public class ForeignCenter
    {
        public string Name { get; set; }

        public void AttackChinese()
        {
            Console.WriteLine("外籍中鋒 {0} 進攻", this.Name);
        }

        public void DefenseChinese()
        {
            Console.WriteLine("外籍中鋒 {0} 防守", this.Name);
        }
    }
}
