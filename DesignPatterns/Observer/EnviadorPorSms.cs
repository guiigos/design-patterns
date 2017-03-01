using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
