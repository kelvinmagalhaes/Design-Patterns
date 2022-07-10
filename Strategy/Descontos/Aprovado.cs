using Strategy.Interfaces;
using Strategy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Descontos
{
    public class Aprovado : IEstado
    {
        private bool descontoAplicado = false;
        public void AplicaDescontroExtra(Orçamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Value -= orcamento.Value * 0.02;
                descontoAplicado = true;
            }
            else
            {
                throw new Exception("Desconto já aplicado!");
            }
        }
        public void Aprova(Orçamento orçamento)
        {
            throw new Exception("Orçamento já está em estado de aprovação");
        }

        public void Reprova(Orçamento orçamento)
        {
            throw new Exception("Orçamento já está em estado de aprovação");
        }

        public void Finaliza(Orçamento orçamento)
        {
            orçamento.EstadoAtual = new Finalizado();
        }
    }
}
