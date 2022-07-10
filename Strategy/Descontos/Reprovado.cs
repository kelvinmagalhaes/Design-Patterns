using Strategy.Interfaces;
using Strategy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Descontos
{
    public class Reprovado : IEstado
    {
        public void AplicaDescontroExtra(Orçamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não possuem desconto extra");
        }
        public void Aprova(Orçamento orçamento)
        {
            throw new Exception("Orçamento já está em estado de reprovação");
        }

        public void Reprova(Orçamento orçamento)
        {
            throw new Exception("Orçamento já está em estado de reprovação");
        }

        public void Finaliza(Orçamento orçamento)
        {
            orçamento.EstadoAtual = new Finalizado();
        }

    }
}
