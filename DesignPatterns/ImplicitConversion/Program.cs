using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion
            Car car = new Car();
            car.year = "1991";
            car.km = "10";

            Honda honda = (Honda)car;
            Console.WriteLine(honda.ToString());
            Console.ReadKey();
        }
    }
}
