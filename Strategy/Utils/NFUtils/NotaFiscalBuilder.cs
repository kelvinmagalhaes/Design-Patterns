using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Utils.NFUtils
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public double valorTotal;
        public double Impostos;
        public IList<ItemDaNota> todosItens = new List<ItemDaNota>();
        public string Observacoes { get; private set; }
        public DateTime Data { get; private set; }

        //public NotaFiscalBuilder(IList<IAcaoAposGerarNota> lista)
        //{
        //    this.todasAcoesASeremExecutadas = lista;
        //}
        public NotaFiscalBuilder ParaEmpresa(string RazaorazaoSocial)
        {
            RazaoSocial = RazaorazaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public void NaDataAtual(DateTime data)
        {
            Data = data;
        }
        public NotaFiscalBuilder NaData(DateTime novaData)
        {
            Data = novaData;

            return this;
        }

        public NotaFiscalBuilder Com(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }
        public IList<IAcaoAposGerarNota> todasAcoesASeremExecutadas = new List<IAcaoAposGerarNota>();
        public void AdicionaAcao(IAcaoAposGerarNota novaAcao)
        {
            this.todasAcoesASeremExecutadas.Add(novaAcao);
        }
        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, Impostos, todosItens, Observacoes);

            foreach (IAcaoAposGerarNota acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }

            return nf;

        }

        
    }
}
