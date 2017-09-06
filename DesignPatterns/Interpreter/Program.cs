using System;
using System.Linq.Expressions;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao soma = new Soma(esquerda, direita);

            Console.WriteLine(soma.Avalia());

            Expression soma2 = Expression.Add(Expression.Constant(10), Expression.Constant(100));
            Func<int> funcao = Expression.Lambda<Func<int>>(soma2).Compile();

            Console.WriteLine(funcao());
            Console.ReadKey();
        }
    }
}
