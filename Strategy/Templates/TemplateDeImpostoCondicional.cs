using Strategy.Interfaces;
using Strategy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Templates
{
    public abstract class TemplateDeImpostoCondicional : IImposto
    {
        public TemplateDeImpostoCondicional(IImposto outroImposto) : base(outroImposto) { }
 
        public override double Calcula(Orçamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }
            return MinimaTaxacao(orcamento);
        }
        public abstract bool DeveUsarMaximaTaxacao(Orçamento orcamento);
        public abstract double MaximaTaxacao(Orçamento orcamento);
        public abstract double MinimaTaxacao(Orçamento orcamento);
    }
}
