using Strategy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Interfaces
{
    public interface IDesconto
    {
        double Desconta(Orçamento orcamento);
        IDesconto Proximo { get; set; }
    }
}
