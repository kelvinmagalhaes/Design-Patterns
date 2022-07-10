using Investimento.Interfaces;
using Investimento.RegraDeNegocios;
using Investimento.Types;
using Investimento.Utils;

IInvestimento moderado = new Moderado();

IInvestimento arrojado = new Arrojado();

IInvestimento conservador = new Conservador();

Invest invest = new Invest(6000.0);
RealizadorDeInvestimentos calcula = new RealizadorDeInvestimentos();

calcula.RealizaCalculo(invest, moderado);
calcula.RealizaCalculo(invest, arrojado);
calcula.RealizaCalculo(invest, conservador);


Console.ReadKey();