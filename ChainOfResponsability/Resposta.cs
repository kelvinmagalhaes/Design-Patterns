using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{

    class RespostaEmXml : IResposta
    {
        public IResposta OutraResposta { get; set; }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else
            {
                OutraResposta.Responde(req, conta);
            }
        }
    }

    class RespostaEmCsv : IResposta
    {
        public IResposta OutraResposta { get; set; }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else
            {
                OutraResposta.Responde(req, conta);
            }
        }
    }

    class RespostaEmPorcento : IResposta
    {
        public IResposta OutraResposta { get; set; }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Titular + "%" + conta.Saldo);
            }
            else
            {
                OutraResposta.Responde(req, conta);
            }
        }
    }
}
