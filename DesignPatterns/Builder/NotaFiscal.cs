using System;
using System.Collections.Generic;

namespace Builder
{
    public class NotaFiscal
    {
        public String razaoSocial { get; set; }
        public String cnpj { get; set; }
        public String observacoes { get; set; }
        public DateTime dataEmissao { get; set; }
        public double valorBruto { get; set; }
        public double impostos { get; set; }
        public IList<ItemDaNota> itens {get;set;}

        public NotaFiscal(String razaoSocial, String cnpj, String observacoes, DateTime dataEmissao, double valorBruto, double impostos, IList<ItemDaNota> itens)
        {
            this.razaoSocial = razaoSocial;
            this.cnpj = cnpj;
            this.observacoes = observacoes;
            this.dataEmissao = dataEmissao;
            this.valorBruto = valorBruto;
            this.impostos = impostos;
            this.itens = itens;
        }
    }
}
