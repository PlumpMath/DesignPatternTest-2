using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternTest
{
    public class ConcreteState1 : StateContext
    {
        public override void StateWork(PlayerState user)
        {
            if (user.level < 20)
            {
                Console.WriteLine("等級：{0} 廢", user.level);
            }
            else
            {
                user.SetStateContext(new ConcreteState2());
                user.StateWork();
            }
        }
    }
}
