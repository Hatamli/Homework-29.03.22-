using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class__Ctor
{
    class Car : Motorcycle
    {
        public Car(string brand, string model, int dateofmanufacture, int engine, string fueltype, string gearbox, string color) : base(brand, model, dateofmanufacture, engine, fueltype, gearbox, color)
        {

        }
    }
}
