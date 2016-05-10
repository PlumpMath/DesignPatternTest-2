using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public class BakeMuttonCommand : Command2
    {
        public BakeMuttonCommand(Cook receiver)
            : base(receiver)
        {

        }

        public override void ExecuteCommand()
        {
            _receiver.BakeMutton();
        }
    }
}
