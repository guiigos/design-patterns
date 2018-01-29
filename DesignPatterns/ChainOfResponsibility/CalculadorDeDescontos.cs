namespace ChainOfResponsibility
{
    class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            Desconto d1 = new DescontoPorCincoItens();
            Desconto d2 = new DescontoPorMaisDeQuinhentosReais();

            d1.proximo = d2;
            return d1.Desconta(orcamento);
        }
    }
}
