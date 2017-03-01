using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class EnviadorDeEmail : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Envia por e-mail.");
        }
    }
}
