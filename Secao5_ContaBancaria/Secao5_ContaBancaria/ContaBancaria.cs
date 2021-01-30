using System.Globalization;

namespace Secao5_ContaBancaria
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string titularConta)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;            
        }

        public ContaBancaria(int numeroConta, string titularConta, double saldo)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
            Saldo = saldo;
        }

        public void Depositar (double valorDeposito)
        {
            Saldo += valorDeposito;
        }

        public void Sacar (double valorSaque)
        {
           Saldo -= 5.0;
           Saldo -= valorSaque;        
        }

        public override string ToString()
        {
            return "Conta: "
                + NumeroConta
                + ", Titular: "
                + TitularConta
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
