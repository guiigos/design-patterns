using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class Numero : IExpressao
    {
        public int valor;

        public Numero(int valor)
        {
            this.valor = valor;
        }

        public int Avalia()
        {
            return this.valor;
        }

        public void Aceita(Impressora impressora)
        {
            impressora.ImprimeNumero(this);
        }
    }
}
