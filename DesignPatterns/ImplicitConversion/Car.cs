using System;

namespace ImplicitConversion
{
    class Car
    {
        public string year;
        public string km;

        public Car() { }

        public static implicit operator Honda(Car car)
        {
            Honda honda = new Honda();
            honda.hondaYear = car.year;
            honda.hondaKm = Convert.ToInt32(car.km);

            return honda;
        }
    }
}
