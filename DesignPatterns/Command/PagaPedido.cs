using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class PagaPedido : IComando
    {
        public Pedido pedido { get; set; }

        public PagaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Pagando o pedido do cliente {0}", pedido.cliente);
            pedido.Paga();
        }
    }
}
