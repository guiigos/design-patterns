using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Historico historico = new Historico();
            Contrato c = new Contrato(DateTime.Now, "Guilherme", TipoContrato.Novo);

            historico.Adiciona(c.SalvaEstado());
            Console.WriteLine(c.tipo);

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());
            Console.WriteLine(c.tipo);

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());
            Console.WriteLine(c.tipo);

            Console.WriteLine(historico.Pega(1).contrato.tipo);
        }
    }
}
