using System;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace ContaBancaria 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Entre o numero da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial(s/n)? ");
            char respDepInicial = char.Parse(Console.ReadLine());

            if(respDepInicial == 's')
            {
                Console.Write("Entre o valor de deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new Conta(numConta, nomeTitular, depositoInicial);
            }
            else
            {
                conta = new Conta(numConta, nomeTitular);
            }
            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine("\nDados da conta atualizados:");
            Console.WriteLine(conta);

            Console.Write("\nEntre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine("\nDados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}