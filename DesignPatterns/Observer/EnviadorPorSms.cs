using System;

namespace Observer
{
    public class EnviadorPorSms : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Envia por SMS.");
        }
    }
}
