using Strategy.Interfaces;
using Strategy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Descontos
{
    public class Finalizado : IEstado
    {
        public void AplicaDescontroExtra(Orçamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não possuem desconto extra");
        }

        public void Aprova(Orçamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado");
        }
        public void Reprova(Orçamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado");
        }
        public void Finaliza(Orçamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado");
        }
    }
}
