using Strategy.Interfaces;
using Strategy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Descontos
{
    public class EmAprovacao : IEstado
    {
        private bool descontoAplicado = false;
        public void AplicaDescontroExtra(Orçamento orcamento)
        {
            
            if (!descontoAplicado)
            {
                orcamento.Value -= orcamento.Value * 0.05;
                descontoAplicado = true;
            }
            else
            {
                throw new Exception("Desconto já aplicado!");
            }
        }

        public void Aprova(Orçamento orçamento)
        {
            orçamento.EstadoAtual = new Aprovado();
        }

        public void Reprova(Orçamento orçamento)
        {
            orçamento.EstadoAtual = new Reprovado();
        }

        public void Finaliza(Orçamento orçamento)
        {
            throw new Exception("Orçamento em aprovação não pode ir para finalizado direto");
        }
    }
}
