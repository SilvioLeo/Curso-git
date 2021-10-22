using System;
using System.Globalization;

namespace ConsoleApp2
{
    class ContaBancaria
    {
        public int NumConta { get;  private set; }
        public string Titular { get; set; }
        public double Saldo { get;  private set; }


        public ContaBancaria(int numero, string titular)
        {
            NumConta = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {

            Saldo = saldo;

        }




        public  double Deposito(double quantia)
        {
            return Saldo += quantia ;

        }

        public double Saque(double quantia)
        {

            return Saldo -= quantia + 5.0;
        }

        public override string ToString() 
        {
            return "Conta " + NumConta + ", " + "Titular: " + Titular + ", " + "Saldo: " + "$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}