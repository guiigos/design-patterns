namespace Decorator
{
    public class ICMS : Imposto
    {
        public ICMS() : base() { }
        public ICMS(Imposto outroImposto) : base(outroImposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.valor * 0.1 + CalculoOutroImposto(orcamento);
        }
    }
}
