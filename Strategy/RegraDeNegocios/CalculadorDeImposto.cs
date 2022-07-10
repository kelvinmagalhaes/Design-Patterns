using Strategy.Interfaces;
using Strategy.Utils;

namespace Strategy.RegraDeNegocios
{
    public class CalculadorDeImposto
    {
        public void RealizaCalculo(Orçamento orçamento, IImposto imposto)
        {
            Console.WriteLine(imposto.Calcula(orçamento));
        }
    }
}
