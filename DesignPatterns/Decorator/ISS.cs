namespace Decorator
{
    public class ISS : Imposto
    {
        public ISS() : base() { }
        public ISS(Imposto outroImposto) : base(outroImposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.valor * 0.06 + CalculoOutroImposto(orcamento);
        }
    }
}
