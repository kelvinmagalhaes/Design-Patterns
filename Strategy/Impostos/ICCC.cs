using Strategy.Interfaces;
using Strategy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Impostos
{
    public class ICCC : IImposto
    {
        public ICCC(IImposto outroImposto) : base(outroImposto) { }
        public override double Calcula(Orçamento orçamento)
        {
            if (orçamento.Value < 1000)
            {
                return orçamento.Value * 0.05 + CalculoDoOutroImposto(orçamento);
            }
            else if (orçamento.Value > 1000 && orçamento.Value < 3000)
            {
                return orçamento.Value * 0.07 + +CalculoDoOutroImposto(orçamento);
            }
            else
            {
                return orçamento.Value * 0.08 + 30 + CalculoDoOutroImposto(orçamento);
            }

        }
    }
}
