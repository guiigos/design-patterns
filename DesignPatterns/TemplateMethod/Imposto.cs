﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    public interface Imposto
    {
        double Calcula(Orcamento orcamento);
    }
}
