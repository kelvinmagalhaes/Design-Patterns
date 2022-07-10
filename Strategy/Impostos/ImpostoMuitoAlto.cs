using Strategy.Interfaces;
using Strategy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Impostos
{
    public  class ImpostoMuitoAlto : IImposto
    {
        public ImpostoMuitoAlto(IImposto outroImposto) : base(outroImposto) { } 
        public override double Calcula(Orçamento orcamento)
        {
            return orcamento.Value * 0.2 + CalculoDoOutroImposto(orcamento);
        }
    }
}
