
using Investimento.Interfaces;
using Investimento.Utils;

namespace Investimento.RegraDeNegocios
{
    public class RealizadorDeInvestimentos
    {
        public void RealizaCalculo(Invest investimento, IInvestimento nome)
        {
            var calculo = nome.Calcula(investimento) * 0.75;
            
            Console.WriteLine("Valor investido:" +investimento.Value);
            
            Console.WriteLine("Rendimentos para: "  + nome.ToString() + " -> " +calculo);
            
            Console.WriteLine("Imposto:" +((calculo * 1.25) * 0.25));
            
            Console.WriteLine("Valor Total: " + (calculo + investimento.Value));

            Console.WriteLine("\n \n");
        }
    }
}
