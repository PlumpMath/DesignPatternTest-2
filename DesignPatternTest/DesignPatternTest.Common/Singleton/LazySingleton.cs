using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton> _lazyInstance = new Lazy<LazySingleton>(() => new LazySingleton());

        private LazySingleton()
        {

        }

        public static LazySingleton Instance
        {
            get
            {
                return _lazyInstance.Value;
            }
        }
    }
}
