namespace Visitor
{
    class Soma : IExpressao
    {
        public IExpressao esquerda { get; private set; }
        public IExpressao direita { get; private set; }

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

        public void Aceita(Impressora impressora)
        {
            impressora.ImprimeSoma(this);
        }
    }
}
