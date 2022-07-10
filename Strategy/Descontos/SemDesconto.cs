using Strategy.Interfaces;
using Strategy.Utils;

namespace Strategy.Descontos
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orçamento orcamento)
        {
            return 0;
        }
    }
}
