using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public interface Imposto
    {
        double Calcula(Orcamento orcamento);
    }
}
