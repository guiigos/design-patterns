﻿using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS(new ICMS());

            Orcamento orcamento = new Orcamento(500);
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, iss);
            Console.ReadKey();
        }
    }
}
