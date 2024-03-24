using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ContaBancaria
{
    internal class Conta
    {
        public int NumConta {  get; set; }
        public string NomeTitular { get; set; }
        public double Saldo {  get; set; }

        public Conta()
        {
        }

        public Conta(int numConta, string nomeTitular)
        {
            NumConta = numConta;
            NomeTitular = nomeTitular;
        }
        public Conta(int numConta, string nomeTitular, double saldo)
        {
            NumConta = numConta;
            NomeTitular = nomeTitular;
            Saldo = saldo;
        }

        public double Deposito(double deposito)
        {
            return Saldo += deposito;
        }
        public double Saque(double saque)
        {
            return Saldo -= saque + 3.50;
        }

        public override string ToString()
        {
            return "Conta "
                + NumConta
                + ", Titular: "
                + NomeTitular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
