using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class PlayerState
    {
        public int level = 1;

        private StateContext state;

        public PlayerState()
        {
            SetStateContext(new ConcreteState1());
        }

        public void SetStateContext(StateContext s)
        {
            state = s;
        }

        public void StateWork()
        {
            state.StateWork(this);
        }
    }
}
