using System;

namespace State
{
    public class Aprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.valor -= orcamento.valor * 0.02;
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já esta em estado de aprovação!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já esta em estado de aprovação!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.estadoAtual = new Finalizado();
        }
    }
}
