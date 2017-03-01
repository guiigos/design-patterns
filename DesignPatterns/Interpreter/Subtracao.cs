﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    class Subtracao : IExpressao
    {
        public IExpressao esquerda { get; set; }
        public IExpressao direita { get; set; }

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = esquerda.Avalia();
            int valorDireita = direita.Avalia();
            return valorEsquerda - valorDireita;
        }
    }
}
