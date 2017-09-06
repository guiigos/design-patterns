using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto ikcv = new IKCV();
            Imposto icpp = new ICPP();

            Orcamento orcamento = new Orcamento(500);
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            calculador.RealizaCalculo(orcamento, ikcv);
            calculador.RealizaCalculo(orcamento, icpp);
            Console.ReadKey();
        }
    }
}
