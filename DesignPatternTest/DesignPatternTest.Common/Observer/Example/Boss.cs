using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public delegate void MyEventHandler();

    public class Boss : ISubject
    {
        public event MyEventHandler Update;

        private string action;

        public void Notify()
        {
            Update();
        }

        public string SubjectState { get; set; }
    }
}
