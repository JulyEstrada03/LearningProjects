using System;

namespace NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car car1 = new Car();
            car1.license = "ABC123";
            car1.driver = "driverTest";
            Console.WriteLine("Car license: " + car1.license);
        }
    }
}
