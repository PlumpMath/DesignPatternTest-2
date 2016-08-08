using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class ConcreteWebsite : FWebSite
    {
        private string Name { get; set; }

        public ConcreteWebsite(string name)
        {
            this.Name = name;
        }

        public override void Use(FUser user)
        {
            Console.WriteLine("網站分類： " + Name + " 用戶： " + user.Name);
        }
    }
}
