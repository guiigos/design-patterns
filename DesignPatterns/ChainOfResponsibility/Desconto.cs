namespace ChainOfResponsibility
{
    public interface Desconto
    {
        double Desconta(Orcamento orcamento);
        Desconto proximo { get; set; }
    }
}
