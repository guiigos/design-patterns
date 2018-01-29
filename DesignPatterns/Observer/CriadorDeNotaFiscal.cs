using System;
using System.Collections.Generic;

namespace Observer
{
    public class CriadorDeNotaFiscal
    {
        public String razaoSocial { get; private set; }
        public String cnpj { get; private set; }
        public String observacoes { get; private set; }
        public DateTime data { get; private set; }

        private double valorTotal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        public IList<AcaoAposGerarNota> todasAcoes = new List<AcaoAposGerarNota>();

        public CriadorDeNotaFiscal ParaEmpresa(String razaoSocial)
        {
            this.razaoSocial = razaoSocial;
            return this;
        }

        public CriadorDeNotaFiscal ComCnpj(String cnpj)
        {
            this.cnpj = cnpj;
            return this;
        }

        public CriadorDeNotaFiscal ComObservacoes(String observacoes)
        {
            this.observacoes = observacoes;
            return this;
        }

        public CriadorDeNotaFiscal NaDataAtual()
        {
            this.data = DateTime.Now;
            return this;
        }

        public void AdicionaAcao(AcaoAposGerarNota acao)
        {
            this.todasAcoes.Add(acao);
        }

        public CriadorDeNotaFiscal ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.valor;
            impostos += item.valor * 0.05;
            return this;
        }

        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(
                this.razaoSocial,
                this.cnpj,
                this.observacoes,
                this.data,
                this.valorTotal,
                this.impostos,
                this.todosItens);

            foreach (AcaoAposGerarNota acao in todasAcoes)
                acao.Executa(nf);

            return nf;
        }
    }
}
