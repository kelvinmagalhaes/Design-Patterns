using Strategy.Interfaces;
using Strategy.Utils;

namespace Strategy.Descontos
{
    public class DescontoQuinhentos : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orçamento orcamento)
        {
            if (orcamento.Value > 500)
            {
                return orcamento.Value * 0.07;
            }
            return Proximo.Desconta(orcamento);
        }
    }
}
