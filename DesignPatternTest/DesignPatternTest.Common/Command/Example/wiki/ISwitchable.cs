using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    /// <summary>Receiver</summary>
    public interface ISwitchable
    {
        void PowerOn();
        void PowerOff();
    }
}
