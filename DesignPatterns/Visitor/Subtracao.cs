namespace Visitor
{
    class Subtracao : IExpressao
    {
        public IExpressao esquerda { get; private set; }
        public IExpressao direita { get; private set; }

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = esquerda.Avalia();
            int valorDireita = direita.Avalia();
            return valorEsquerda - valorDireita;
        }

        public void Aceita(Impressora impressora)
        {
            impressora.ImprimeSubtracao(this);
        }
    }
}
