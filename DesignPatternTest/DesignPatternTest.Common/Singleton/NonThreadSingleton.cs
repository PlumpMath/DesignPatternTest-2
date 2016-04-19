using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DesignPatternTest.Common
{
    public class NonThreadSingleton
    {
        private static NonThreadSingleton _instance;

        private NonThreadSingleton()
        {

        }

        public static NonThreadSingleton Instance
        {
            get
            {
                Thread.Sleep(500);
                if (_instance == null)
                {
                    Console.WriteLine("new NonThreadSingleton instance");
                    _instance = new NonThreadSingleton();
                }
                return _instance;
            }
        }
    }
}
