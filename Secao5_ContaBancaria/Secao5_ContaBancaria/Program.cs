using System;
using System.Globalization;

namespace Secao5_ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titularDaConta = Console.ReadLine();
            Console.Write("Haverá depósito inicial (S/N): ");
            string escolha = Console.ReadLine();
                       
            if (escolha == "S" || escolha == "s")
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numeroDaConta, titularDaConta, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numeroDaConta, titularDaConta);
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.Write("Entre o valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(valorDeposito);
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.Write("Entre o valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(valorSaque);
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
        }
    }
}
