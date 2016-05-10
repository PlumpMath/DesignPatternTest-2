using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public class BakeChickenWingCommand : Command2
    {
        public BakeChickenWingCommand(Cook receiver)
            : base(receiver)
        {

        }
        public override void ExecuteCommand()
        {
            _receiver.BakeChickenWing();
        }
    }
}
