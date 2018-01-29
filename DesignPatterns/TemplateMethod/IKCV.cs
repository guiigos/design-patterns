namespace TemplateMethod
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.valor > 500 && temItemMaiorQueCemReaisNo(orcamento);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.valor * 0.10;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.valor * 0.06;
        }

        public bool temItemMaiorQueCemReaisNo(Orcamento orcamento)
        {
            foreach(Item item in orcamento.itens)
            {
                if (item.valor > 100) return true;
            }
            return false;
        }
    }
}
