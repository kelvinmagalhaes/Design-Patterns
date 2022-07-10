using Investimento.Interfaces;
using Investimento.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimento.Types
{
    public class Moderado : IInvestimento
    {
        public double Calcula(Invest investimento)
        {
            bool escolhido  = new Random().Next(101) > 50;

            if (escolhido != true)
            {
                return investimento.Value * 0.025;
            }
            else
            {
                return investimento.Value * 0.007;
            }
        }
    }
}
