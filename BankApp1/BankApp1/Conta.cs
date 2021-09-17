using System;
using System.Globalization;

namespace BankApp1
{
    class Conta
    {
        public int NumConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }


        public Conta(int numero, string nome)
        {
            NumConta = numero;
            Nome = nome;

        }

        public Conta(int numero, string nome, double saldo) : this(numero, nome) {
            Deposito(saldo);
        }
        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= saque + 5.00;
           
        }

        public override string ToString()
        {
            return "Conta: " + NumConta + ", Titular: "
                + Nome + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
