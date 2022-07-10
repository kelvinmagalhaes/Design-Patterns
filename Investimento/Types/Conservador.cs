using Investimento.Interfaces;
using Investimento.Utils;

namespace Investimento.Types
{
    public class Conservador : IInvestimento
    {
        public double Calcula(Invest investimento)
        {
            return investimento.Value * 0.8;
        }
    }
}
