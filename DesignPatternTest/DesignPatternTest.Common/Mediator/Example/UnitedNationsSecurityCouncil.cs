using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class UnitedNationsSecurityCouncil : UnitNations
    {
        public TW colleague1 { get; set; }
        public JP colleague2 { get; set; }

        public override void Declare(string message, MCountry colleague)
        {
            if (colleague == colleague1)
            {
                colleague2.GetMessage(message);
            }
            else
            {
                colleague1.GetMessage(message);
            }
        }
    }
}
