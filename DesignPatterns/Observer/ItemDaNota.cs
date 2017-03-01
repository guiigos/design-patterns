﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
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
