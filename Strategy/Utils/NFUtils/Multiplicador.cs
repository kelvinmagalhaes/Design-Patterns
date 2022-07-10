using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Utils.NFUtils
{
    public class Multiplicador : IAcaoAposGerarNota
    {
        public double Fator { get; private set; }

        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine(nf.ValorBruto * this.Fator);
        }

        public  Multiplicador(double fator)
        {
            this.Fator = fator;
        }
    }
}
