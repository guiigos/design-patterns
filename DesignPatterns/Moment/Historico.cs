using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class Historico
    {
        private List<Estado> estados = new List<Estado>();

        public void Adiciona(Estado estado)
        {
            this.estados.Add(estado);
        }

        public Estado Pega(int indice)
        {
            return this.estados[indice];
        }
    }
}
