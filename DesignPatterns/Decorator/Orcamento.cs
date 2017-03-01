using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class Orcamento
    {
        public double valor { get; private set; }
        public IList<Item> itens { get; private set; }

        public Orcamento(double valor)
        {
            this.valor = valor;
            this.itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            itens.Add(item);
        }
    }
}
