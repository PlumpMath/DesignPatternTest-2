using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public class ConcreteObserver : Observer
    {
        private string _name;

        private string _observerState;

        private ConcreteSubject _subject;

        public ConcreteSubject Subject { get; set; }

        public ConcreteObserver(ConcreteSubject cSubject, string name)
        {
            this._subject = cSubject;
            this._name = name;
        }

        public override void Update()
        {
            _observerState = this._subject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1}", this._name, this._observerState);
        }
    }
}
