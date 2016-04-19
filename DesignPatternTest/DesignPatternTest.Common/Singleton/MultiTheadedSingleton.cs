using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatternTest.Common
{
    public sealed class MultiTheadedSingleton
    {
        private static volatile MultiTheadedSingleton _instance;

        private static object _syncRoot = new object();

        private MultiTheadedSingleton()
        {

        }

        public static MultiTheadedSingleton Instance
        {
            get
            {
                Thread.Sleep(500);
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        Console.WriteLine("new MultiTheadedSingleton instance");
                        _instance = new MultiTheadedSingleton();
                    }
                }
                return _instance;
            }
        }

        public static MultiTheadedSingleton Instance2
        {
            get
            {
                Thread.Sleep(500);
                //double-check
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                        {
                            Console.WriteLine("new MultiTheadedSingleton instance");
                            _instance = new MultiTheadedSingleton();
                        }
                    }
                }
                return _instance;
            }
        }

    }
}
