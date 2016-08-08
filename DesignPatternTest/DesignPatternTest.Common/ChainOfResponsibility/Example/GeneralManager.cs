using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class GeneralManager : CORManager
    {
        public GeneralManager(string name)
            : base(name)
        {

        }
        public override void RequestApplications(CORRequest request)
        {
            if (request.RequestType == "請假")
            {
                Console.WriteLine("{0}：{1} 數量{2} 被批準", name, request.RequestContent, request.Number);
            }
            else if (request.RequestType == "加薪" && request.Number <= 500)
            {
                Console.WriteLine("{0}：{1} 數量{2} 被批準", name, request.RequestContent, request.Number);
            }
            else if (request.RequestType == "加薪" && request.Number > 500)
            {
                Console.WriteLine("{0}：{1} 數量{2} 再說吧", name, request.RequestContent, request.Number);
            }
            
        }
    }
}
