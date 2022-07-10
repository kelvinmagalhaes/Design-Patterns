namespace TemplateMethod
{
    public class Conta
    {
        public String Titular { get; private set; }
        public double Saldo { get; private set; }
        public String Nome { get; private set; }
        public int Agencia { get; private set; }
        public int Numero { get; private set; }

        public Conta(String titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }

    enum Formato
    {
        XML,
        CSV,
        PORCENTO
    }

    class Requisicao
    {
        public Formato Formato { get; private set; }

        public Requisicao(Formato formato)
        {
            this.Formato = formato;
        }

    }
}
