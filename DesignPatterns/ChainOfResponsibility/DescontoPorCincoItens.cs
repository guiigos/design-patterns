namespace ChainOfResponsibility
{
    public class DescontoPorCincoItens : Desconto
    {
        public Desconto proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.itens.Count > 5)
            {
                return orcamento.valor * 0.1;
            }
            return (proximo == null) ? 0 : proximo.Desconta(orcamento);
        }
    }
}
