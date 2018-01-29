namespace Interpreter
{
    class Soma : IExpressao
    {
        public IExpressao esquerda { get; set; }
        public IExpressao direita { get; set; }

        public Soma(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }   

        public int Avalia(){
            int valorEsquerda = esquerda.Avalia();
            int valorDireita = direita.Avalia();
            return valorEsquerda + valorDireita;
        }
    }
}
