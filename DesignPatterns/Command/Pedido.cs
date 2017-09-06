using System;

namespace Command
{
    class Pedido
    {
        public string cliente { get; private set; }
        public double valor { get; private set; }
        public DateTime dataFinalizacao { get; private set; }
        public Status status { get; private set; }

        public Pedido(string cliente, double valor)
        {
            this.cliente = cliente;
            this.valor = valor;
            this.status = Status.Novo;
        }

        public void Paga()
        {
            this.status = Status.Pago;
        }

        public void Finaliza()
        {
            this.status = Status.Entregue;
            this.dataFinalizacao = DateTime.Now;
        }
    }
}
