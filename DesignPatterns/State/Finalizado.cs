using System;

namespace State
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamento finalizados não recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já esta finalizado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já esta finalizado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento já esta finalizado!");
        }
    }
}
