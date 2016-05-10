using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public abstract class Command2
    {
        protected Cook _receiver;

        public Command2(Cook receiver)
        {
            this._receiver = receiver;
        }

        public abstract void ExecuteCommand();
    }
}
