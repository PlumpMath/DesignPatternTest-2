using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public class Waiter
    {
        private IList<Command2> orders = new List<Command2>();

        public void SetOrder(Command2 command)
        {
            if (command.ToString() == "DesignPatternTest.Common.BakeChickenWingCommand")
            {
                Console.WriteLine("服務生:雞翅沒了，請換別的燒烤。");
            }
            else
            {
                orders.Add(command);
                Console.WriteLine("增加訂單:" + command.ToString()
                    + " 時間：" + DateTime.Now.ToString());
            }
        }

        public void CancelOrder(Command2 command)
        {
            orders.Remove(command);
            Console.WriteLine("取消訂單:" + command.ToString()
                    + " 時間：" + DateTime.Now.ToString());
        }

        public void Notify()
        {
            foreach (Command2 cmd in orders)
            {
                cmd.ExecuteCommand();
            }
        }
    }
}
