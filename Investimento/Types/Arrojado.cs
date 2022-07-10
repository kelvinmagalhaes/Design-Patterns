using Investimento.Interfaces;
using Investimento.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimento.Types
{
    public class Arrojado : IInvestimento
    {
        public double Calcula(Invest investimento)
        {
            bool escolhido2 = new Random().Next(101) > 20;
            bool escolhido3 = new Random().Next(101) > 30;
            bool escolhido4 = new Random().Next(101) > 50;

            if (escolhido3 != true && escolhido2 == true)
            {
                return investimento.Value * 0.05;
            }
            else if (escolhido3 == true && escolhido4 != true)
            {
                return investimento.Value * 0.03;
            }
            else
            {
                return investimento.Value * 0.006;
            }
        }
    }
}
