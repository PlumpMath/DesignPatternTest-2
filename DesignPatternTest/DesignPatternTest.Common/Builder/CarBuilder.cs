using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class CarBuilder : ICarBuilder
    {
        private Car _car;

        public CarBuilder()
        {
            this._car = new Car();
        }

        public void SetWheels(int wheels)
        {
            this._car.Wheels = wheels;
        }

        public void SetColor(string color)
        {
            this._car.Color = color;
        }

        public Car GetResult()
        {
            return this._car;
        }
    }
}
