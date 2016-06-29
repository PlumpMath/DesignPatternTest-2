using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternTest
{
    public class ConcreteState3 : StateContext
    {
        public override void StateWork(PlayerState user)
        {
            if (user.level >= 70)
            {
                Console.WriteLine("等級：{0} 算強吧", user.level);
            }
        }
    }
}
