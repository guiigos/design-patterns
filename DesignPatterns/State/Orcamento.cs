using System.Collections.Generic;

namespace State
{
    public class Orcamento
    {
        public EstadoDeUmOrcamento estadoAtual { get; set; }
        public double valor { get; set; }
        public IList<Item> itens { get; private set; }

        public Orcamento(double valor)
        {
            this.valor = valor;
            this.itens = new List<Item>();
            this.estadoAtual = new EmAprovacao();
        }

        public void AdicionaItem(Item item)
        {
            itens.Add(item);
        }

        public void AplicaDescontoExtra()
        {
            estadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            estadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            estadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            estadoAtual.Finaliza(this);
        }

    }
}
