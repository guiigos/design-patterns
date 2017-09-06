namespace Decorator
{
    public abstract class Imposto
    {
        public Imposto outroImposto { get; set; }

        public Imposto() 
        {
            this.outroImposto = null;
        }

        public Imposto(Imposto outroImposto)
        {
            this.outroImposto = outroImposto;
        }

        protected double CalculoOutroImposto(Orcamento orcamento)
        {
            if (outroImposto == null) return 0;
            return outroImposto.Calcula(orcamento);
        }

        public abstract double Calcula(Orcamento orcamento);
    }
}
