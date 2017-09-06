using System.Collections.Generic;

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
