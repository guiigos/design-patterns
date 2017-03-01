using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    public class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.valor * 0.1;
        }
    }
}
