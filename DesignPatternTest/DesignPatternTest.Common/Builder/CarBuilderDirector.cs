using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class CarBuilderDirector
    {
        public Car Construct()
        {
            CarBuilder builder = new CarBuilder();
            builder.SetColor("Red");
            builder.SetWheels(4);
            return builder.GetResult();
        }
    }
}
