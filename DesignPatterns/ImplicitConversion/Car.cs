using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitConversion
{
    class Car
    {
        public string year;
        public string km;

        public Car() { }

        // implicit digit to byte conversion operator
        public static implicit operator Honda(Car car)
        {
            Honda honda = new Honda();
            honda.hondaYear = car.year;
            honda.hondaKm = Convert.ToInt32(car.km);

            return honda;
        }
    }
}
