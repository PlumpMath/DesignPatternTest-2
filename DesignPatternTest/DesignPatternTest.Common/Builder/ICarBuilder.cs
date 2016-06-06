using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public interface ICarBuilder
    {
        void SetWheels(int wheels);

        void SetColor(string color);

        Car GetResult();
    }
}
