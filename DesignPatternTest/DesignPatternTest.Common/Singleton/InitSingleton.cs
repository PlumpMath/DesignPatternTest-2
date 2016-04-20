using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public sealed class InitSingleton
    {
        private static InitSingleton _instance = new InitSingleton();

        private InitSingleton()
        {

        }

        public static InitSingleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
