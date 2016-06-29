using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternTest
{
    public class ConcreteState2 : StateContext
    {
        public override void StateWork(PlayerState user)
        {
            if (user.level < 70)
            {
                Console.WriteLine("等級：{0} 再強點吧", user.level);
            }
            else
            {
                user.SetStateContext(new ConcreteState3());
                user.StateWork();
            }
        }
    }
}
