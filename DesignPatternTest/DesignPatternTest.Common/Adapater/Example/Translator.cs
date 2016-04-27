using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public class Translator : Player
    {
        private ForeignCenter fCenter = new ForeignCenter();

        public Translator(string name)
            : base(name)
        {
            this.fCenter.Name = name;
        }

        public override void Attack()
        {
            this.fCenter.AttackChinese();
        }

        public override void Defense()
        {
            this.fCenter.DefenseChinese();
        }
    }
}
