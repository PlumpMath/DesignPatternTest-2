using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternTest
{
    public abstract class StateContext
    {
        public abstract void StateWork(PlayerState user);
    }
}
