using System;

namespace Class__Ctor
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", "Five Series", 2000, 2500, "Benzin", "Automatic", "Grey");
            Console.WriteLine(car.Brand);
        }
    }
}
