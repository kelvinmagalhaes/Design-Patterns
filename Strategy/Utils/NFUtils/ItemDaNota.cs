using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Utils.NFUtils
{
    public class ItemDaNota
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public ItemDaNota(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
        public ItemDaNota ComValor(double valor)
        {
            Valor = valor;
            return this;
        }

        public ItemDaNota Constroi()
        {
            return new ItemDaNota(Nome, Valor);
        }
    }
}

