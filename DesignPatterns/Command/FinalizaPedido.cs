using System;

namespace Command
{
    class FinalizaPedido : IComando
    {
        public Pedido pedido { get; set; }

        public FinalizaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Finalizando o pedido do cliente {0}", pedido.cliente);
            pedido.Finaliza();
        }
    }
}
