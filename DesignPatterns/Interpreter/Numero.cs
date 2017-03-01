using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    class Numero : IExpressao
    {
        private int numero;

        public Numero(int numero)
        {
            this.numero = numero;
        }

        public int Avalia()
        {
            return this.numero;
        }
    }
}
