using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public interface ISubject
    {
        void Notify();
        
        string SubjectState { get; set; }
    }
}
