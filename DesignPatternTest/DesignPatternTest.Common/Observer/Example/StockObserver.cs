using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public class StockObserver
    {
        private string _name;
        private ISubject _sub;

        public StockObserver(string name, ISubject sub)
        {
            this._name = name;
            this._sub = sub;
        }

        public void CloseStockMarket()
        {
            Console.WriteLine("{0} {1} 關閉股票，繼續工作", this._sub.SubjectState, this._name);
        }
    }
}
