using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridges
{
    interface IMensagem
    {
        IEnviador enviador { get; set; }

        void Envia();
        string Formata();
    }
}
