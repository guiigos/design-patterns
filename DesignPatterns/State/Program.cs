using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento reforma = new Orcamento(500);
            Console.WriteLine(reforma.valor);
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.valor);
            
            reforma.Aprova();
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.valor);

            reforma.Finaliza();
            
            Console.ReadKey();
        }
    }
}
