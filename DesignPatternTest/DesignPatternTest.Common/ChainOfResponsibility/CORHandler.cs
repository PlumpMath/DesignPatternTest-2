using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public abstract class CORHandler
    {
        protected CORHandler _successor;

        public abstract void HandleRequest(int request);

        public void SetSuccessor(CORHandler successor)
        {
            this._successor = successor;
        }


    }
}
