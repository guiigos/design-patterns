using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao soma = new Soma(esquerda, direita);

            Impressora impressora = new Impressora();
            soma.Aceita(impressora);

            Console.Write(" = " + soma.Avalia());
            Console.ReadKey();
        }
    }
}
