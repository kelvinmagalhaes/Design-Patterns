using Strategy.Interfaces;
using Strategy.Utils;

namespace Strategy.Descontos
{
    public class DescontosPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orçamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Value * 0.1;
            }
            return Proximo.Desconta(orcamento); ;
        }
    }
}
