using Strategy.Interfaces;
using Strategy.Templates;
using Strategy.Utils;

namespace Strategy.Impostos
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public ICPP(IImposto outroImposto) : base(outroImposto) { }

        public override bool DeveUsarMaximaTaxacao(Orçamento orcamento)
        {
            return orcamento.Value > 500;
        }

        public override double MaximaTaxacao(Orçamento orcamento)
        {
            return orcamento.Value * 0.07 + CalculoDoOutroImposto(orcamento);
        }

        public override double MinimaTaxacao(Orçamento orcamento)
        {
            return orcamento.Value * 0.05 + CalculoDoOutroImposto(orcamento);
        }
    }
}
