using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    /// <summary>切到關閉</summary>
    public class OpenSwitchCommand : ICommand
    {
        private ISwitchable _switchable;

        public OpenSwitchCommand(ISwitchable switchable)
        {
            this._switchable = switchable;
        }

        public void Execute()
        {
            this._switchable.PowerOff();
        }
    }
}
