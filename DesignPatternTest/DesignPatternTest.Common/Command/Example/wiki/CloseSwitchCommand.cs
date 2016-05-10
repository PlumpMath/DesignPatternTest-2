using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    /// <summary>切到打開</summary>
    public class CloseSwitchCommand : ICommand
    {
        private ISwitchable _switchable;

        public CloseSwitchCommand(ISwitchable switchable)
        {
            this._switchable = switchable;
        }

        public void Execute()
        {
            this._switchable.PowerOn();
        }
    }
}
