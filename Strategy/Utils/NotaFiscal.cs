using Strategy.Utils.NFUtils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Utils
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        public string Observacoes { get; set; }
        private DateTime Data { get; set; }

        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataEmissao, double valorBruto, double impostos, IList<ItemDaNota> itens, string observacoes)
        {
            RazaoSocial = razaoSocial;
            this.CNPJ = cnpj;
            DataEmissao = dataEmissao;
            ValorBruto = valorBruto;
            Impostos = impostos;
            Itens = itens;
            Observacoes = observacoes;
        }

    }
}
