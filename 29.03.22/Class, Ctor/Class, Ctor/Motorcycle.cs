using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class__Ctor
{
    class Motorcycle
    {
        public string Brand;
        public string Model;
        public int DateOfManufacture;
        public int Engine;
        public string FuelType;
        public string Gearbox;
        public string Color;

        public Motorcycle(string brand, string model, int dateofmanufacture, int engine, string fueltype, string gearbox, string color)
        {
            Brand = brand;
            Model = model;
            DateOfManufacture = dateofmanufacture;
            Engine = engine;
            FuelType = fueltype;
            Gearbox = gearbox;
            Color = color;
        }
    }
}
