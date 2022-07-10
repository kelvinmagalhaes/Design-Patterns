using Strategy.Interfaces;
using Strategy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Impostos
{
    public class ICMS : IImposto
    {
        public ICMS(IImposto outroImposto) : base(outroImposto){    }

        public override double Calcula(Orçamento orçamento)
        {
            return orçamento.Value * 0.1 + CalculoDoOutroImposto(orçamento);
        }
    }
}
