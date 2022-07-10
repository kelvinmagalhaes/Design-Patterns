using Strategy.Interfaces;
using Strategy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Impostos
{
    public class IHIT : Templates.TemplateDeImpostoCondicional
    {
        public IHIT(IImposto outroImposto) : base(outroImposto) { }
        public override bool DeveUsarMaximaTaxacao(Orçamento orcamento)
        {
            IList<String> noOrcamento = new List<String>();

            foreach (Item item in orcamento.Itens)
            {
                if (noOrcamento.Contains(item.Nome))
                    return true;
                else
                    noOrcamento.Add(item.Nome);
            }

            return false;
        }

        public override double MaximaTaxacao(Orçamento orcamento)
        {
            return orcamento.Value * (0.01 * orcamento.Itens.Count);
        }

        public override double MinimaTaxacao(Orçamento orcamento)
        {
            return orcamento.Value * 0.05;
        }
    }
}
