using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class CarFacade
    {
        private readonly CarModel model;
        private readonly CarEngine engine;
        private readonly CarBody body;
        private readonly CarAccessories accessories;

        public CarFacade()
        {
            model = new CarModel();
            engine = new CarEngine();
            body = new CarBody();
            accessories = new CarAccessories();
        }

        public void CreateCompleteCar()
        {
            Console.WriteLine("******** Creating a Car **********");
            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accessories.SetAccessories();

            Console.WriteLine("******** Car creation is completed. **********");
        }
    }
}
