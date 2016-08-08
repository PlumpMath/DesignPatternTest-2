using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public abstract class CORManager
    {
        protected string name;

        protected CORManager manager;

        public CORManager(string name)
        {
            this.name = name;
        }

        public void SetSuperior(CORManager manager)
        {
            this.manager = manager;
        }

        public abstract void RequestApplications(CORRequest request);
    }
}
