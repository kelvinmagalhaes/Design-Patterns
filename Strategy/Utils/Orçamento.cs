using Strategy.Descontos;
using Strategy.Interfaces;

namespace Strategy.Utils
{
    public class Orçamento
    {
        public double Value { get; set; }
        public IList<Item> Itens { get; private set; }
        public IEstado EstadoAtual { get; set; }


        public Orçamento(double value)
        {
            this.Value = value;
            this.Itens = new List<Item>();
            this.EstadoAtual = new EmAprovacao();
        }

        public void AdicionarItem(Item item) 
        { 
            Itens.Add(item);
        }       

        public void AplicaDescontroExtra()
        {
            EstadoAtual.AplicaDescontroExtra(this);
        }

        public void Aprova() { EstadoAtual.Aprova(this); }
        public void Reprova() { EstadoAtual.Reprova(this); }
        public void Finaliza() { EstadoAtual.Finaliza(this); }
    }
}
