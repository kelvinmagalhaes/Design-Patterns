using Strategy.Interfaces;
using Strategy.Templates;
using Strategy.Utils;

namespace Strategy.Impostos
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV(IImposto outroImposto) : base(outroImposto) { }

        public override bool DeveUsarMaximaTaxacao(Orçamento orcamento)
        {
            return orcamento.Value > 500 && temItemMaiorQue100ReaisNo(orcamento);
        }

        public override double MaximaTaxacao(Orçamento orcamento)
        {
            return orcamento.Value * 0.10 + CalculoDoOutroImposto(orcamento);
        }

        public override double MinimaTaxacao(Orçamento orcamento)
        {
            return orcamento.Value * 0.06 + CalculoDoOutroImposto(orcamento);
        }

        private bool temItemMaiorQue100ReaisNo(Orçamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100)
                {
                    return true;
                }             
            }
            return false;
        }
    }
}
