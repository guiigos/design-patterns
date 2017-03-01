using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    interface IExpressao
    {
        int Avalia();
        void Aceita(Impressora impressora);
    }
}
