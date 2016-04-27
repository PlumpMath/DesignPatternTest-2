using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver r)
        {
            this.receiver = r;
        }

        public abstract void Execute();
    }


}
