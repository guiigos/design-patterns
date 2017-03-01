using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    public class EmAprovacao : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.valor = orcamento.valor - (orcamento.valor * 0.05);
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.estadoAtual = new Aprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.estadoAtual = new Reprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento em aprovação não pode ir para finalizado!");
        }
    }
}
