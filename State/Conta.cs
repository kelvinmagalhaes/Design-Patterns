using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Conta
    {
        public double Saldo { get; set; }
        public EstadoDaConta Estado { get; set; }

        public void Saca(double valor)
        {
            Estado.Saca(this, valor);
        }

        public void Deposita(double valor)
        {
            Estado.Deposita(this, valor);
        }
    }
}
