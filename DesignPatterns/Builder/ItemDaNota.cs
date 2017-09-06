using System;

namespace Builder
{
    public class ItemDaNota
    {
        public String nome { get; set; }
        public double valor { get; set; }

        public ItemDaNota(String nome, double valor)
        {
            this.nome = nome;
            this.valor = valor;
        }
    }
}
