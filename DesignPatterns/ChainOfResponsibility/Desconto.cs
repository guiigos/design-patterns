using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    public interface Desconto
    {
        double Desconta(Orcamento orcamento);
        Desconto proximo { get; set; }
    }
}
