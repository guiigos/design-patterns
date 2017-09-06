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
            Console.WriteLine(c.tipo); //Novo
            c.Avanca();
            historico.Adiciona(c.SalvaEstado());
            Console.WriteLine(c.tipo); //EmAndamento

            c.Avanca();
            historico.Adiciona(c.SalvaEstado());
            Console.WriteLine(c.tipo); //Acertado

            Console.WriteLine(historico.Pega(1).contrato.tipo); //EmAndamento
        }
    }
}
