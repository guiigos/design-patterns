using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class NotaFiscalDao : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Grava no banco.");
        }
    }
}
