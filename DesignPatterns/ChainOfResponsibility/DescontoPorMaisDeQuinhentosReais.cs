using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    public class DescontoPorMaisDeQuinhentosReais : Desconto
    {
        public Desconto proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.valor >= 500)
            {
                return orcamento.valor * 0.07;
            }
            return (proximo == null) ? 0 : proximo.Desconta(orcamento);
        }
    }
}
