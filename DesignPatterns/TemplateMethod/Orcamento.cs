using System.Collections.Generic;

namespace TemplateMethod
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
