using Strategy.Utils;

namespace Strategy.Interfaces
{
    public interface IEstado
    {
        void AplicaDescontroExtra(Orçamento orcamento);
        void Aprova(Orçamento orcamento);
        void Reprova(Orçamento orcamento);
        void Finaliza(Orçamento orcamento);
    }
}
