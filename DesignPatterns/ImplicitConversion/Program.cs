using System;

namespace ImplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.year = "1991";
            car.km = "10";

            Honda honda = (Honda)car;
            Console.WriteLine(honda.ToString());
            Console.ReadKey();
        }
    }
}
