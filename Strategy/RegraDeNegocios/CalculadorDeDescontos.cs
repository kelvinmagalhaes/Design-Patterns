using Strategy.Descontos;
using Strategy.Interfaces;
using Strategy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.RegraDeNegocios
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orçamento orcamento)
        {
            IDesconto d1 = new DescontosPorCincoItens();
            IDesconto d2 = new DescontoQuinhentos();
            IDesconto d3 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;

            return d1.Desconta(orcamento);
        }
    }
}
