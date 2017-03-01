using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    public class Item
    {
        public String nome { get; private set; }
        public double valor { get; private set; }

        public Item(String nome, double valor)
        {
            this.nome = nome;
            this.valor = valor;
        }
    }
}
