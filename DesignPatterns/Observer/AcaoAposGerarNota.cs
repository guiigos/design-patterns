using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public interface AcaoAposGerarNota
    {
        void Executa(NotaFiscal nota);
    }
}
