using System;

namespace State
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamento reprovados não recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já esta reprovado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já esta reprovado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.estadoAtual = new Finalizado();
        }
    }
}
