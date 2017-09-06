using System;

namespace ImplicitConversion
{
    class Honda
    {
        public string hondaYear;
        public int hondaKm;

        public Honda() { }

        public override string ToString()
        {
            return String.Concat("Km - ", hondaKm, " Year - ", hondaYear);
        }
    }
}
