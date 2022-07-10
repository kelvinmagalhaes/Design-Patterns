using Strategy.Interfaces;
using Strategy.RegraDeNegocios;
using Strategy.Utils;
using Strategy.Impostos;
using Strategy.Templates;
using Strategy.Utils.NFUtils;

#region Strategy - Conjunto de algoritmos similares, e precisamos alternar entre eles em diferentes pedaços da aplicação
//IImposto ISS = new ISS();

//IImposto ICMS = new ICMS();

//IImposto ICCC = new ICCC();

//Orçamento orçamento = new Orçamento(6000.0);
//CalculadorDeImposto calcula = new CalculadorDeImposto();

//calcula.RealizaCalculo(orçamento, ISS);
//calcula.RealizaCalculo(orçamento, ICMS);
//calcula.RealizaCalculo(orçamento, ICCC);
#endregion

#region Chain of Responsability - separação de responsabilidades em classes pequenas, enxutas e junta comportamentos.
////CalculadorDeDescontos calcula = new CalculadorDeDescontos();

//Orçamento orcamento = new Orçamento(500);
//orcamento.AdicionarItem(new Item("CANETA", 250));
//orcamento.AdicionarItem(new Item("LAPIS", 250));
//orcamento.AdicionarItem(new Item("XBOX", 1800));
//orcamento.AdicionarItem(new Item("PS5", 5000));
//orcamento.AdicionarItem(new Item("FRITADEIRA", 250));
//orcamento.AdicionarItem(new Item("PANELA", 250));

//double desconto = calcula.Calcula(orcamento);
//Console.WriteLine(desconto);
#endregion

#region Template Method - estruturas parecidas mas deixar buracos com podem serem implementados de formas diferentes
//Orçamento orcamento = new Orçamento(500);
//orcamento.AdicionarItem(new Item("CANETA", 250));
//orcamento.AdicionarItem(new Item("LAPIS", 250));
//orcamento.AdicionarItem(new Item("XBOX", 1800));
//orcamento.AdicionarItem(new Item("PS5", 5000));
//orcamento.AdicionarItem(new Item("FRITADEIRA", 250));
//orcamento.AdicionarItem(new Item("PANELA", 250));

//IImposto IKCV = new IKCV();
//IImposto ICPP = new ICPP();

//CalculadorDeImposto calcula = new CalculadorDeImposto();
//calcula.RealizaCalculo(orcamento, IKCV);
//calcula.RealizaCalculo(orcamento, ICPP);
#endregion

#region Decorator - comportamento que podem ser compostos por comportamentos de outras classes.
////IImposto impostoComplexo = new ISS(new ICMS(null));

//IImposto impostoComplexo = new ImpostoMuitoAlto(new ICMS(null));
//Orçamento orcamento = new Orçamento(500.0);

//double valor = impostoComplexo.Calcula(orcamento);

//Console.WriteLine(valor);
#endregion

#region State - Maquina de estados, conhece o estado
//Orçamento reforma = new Orçamento(500);

//Console.WriteLine(reforma.Value);

//reforma.AplicaDescontroExtra();

//Console.WriteLine(reforma.Value);

//reforma.Aprova();

//reforma.AplicaDescontroExtra();

//Console.WriteLine(reforma.Value);
//reforma.Finaliza();
#endregion

#region Buider - simplifica as classes.
//NotaFiscalBuilder criador = new NotaFiscalBuilder();
//criador
//    .ParaEmpresa("Teste Ltda")
//    .ComCnpj("23.456.789/0001-12")
//    .Com(new ItemDaNota("item 1", 100.0))
//    .Com(new ItemDaNota("item 2", 250.0))
//    .ComObservacoes("Empesa de Testes");

//NotaFiscal nf = criador.Constroi();

//Console.WriteLine(nf.CNPJ);
//Console.WriteLine(nf.ValorBruto);
//Console.WriteLine(nf.Impostos);
//Console.WriteLine(nf.DataEmissao);
#endregion

#region Observer - diversas ações sejam executadas de forma transparente à classe principal, 
//reduzindo o acoplamento entre essas ações, facilitando a manutenção e evolução do código.
NotaFiscalBuilder criador = new NotaFiscalBuilder();
criador
    .ParaEmpresa("Teste Ltda")
    .ComCnpj("23.456.789/0001-12")
    .Com(new ItemDaNota("item 1", 100.0))
    .Com(new ItemDaNota("item 2", 250.0))
    .ComObservacoes("Empesa de Testes");

criador.AdicionaAcao(new EnviadorDeEmail());
criador.AdicionaAcao(new EnviadorDeSms());
criador.AdicionaAcao(new EnviaParaBanco());
criador.AdicionaAcao(new Multiplicador(5.5));


NotaFiscal nf = criador.Constroi();

Console.WriteLine(nf.CNPJ);
Console.WriteLine(nf.ValorBruto);
Console.WriteLine(nf.Impostos);
Console.WriteLine(nf.DataEmissao);
#endregion

Console.ReadKey();