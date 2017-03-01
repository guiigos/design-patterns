using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class Estado
    {
        public Contrato contrato { get; private set; }

        public Estado(Contrato contrato)
        {
            this.contrato = contrato;
        }
    }
}
