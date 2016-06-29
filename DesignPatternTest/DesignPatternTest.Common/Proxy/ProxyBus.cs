using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class ProxyBus : IBus
    {
        private Driver driver;
        private IBus realBus;

        public ProxyBus(Driver driver)
        {
            this.driver = driver;
            this.realBus = new Bus();
        }

        public void DriveCar()
        {
            if (driver.Age <= 16)
            {
                Console.WriteLine("Sorry, the driver is too young to drive.");
            }
            else
            {
                realBus.DriveCar();
            }
        }
    }
}
