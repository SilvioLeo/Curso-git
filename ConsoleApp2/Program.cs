using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o numero da conta:");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta:");
            string titular = Console.ReadLine();

            Console.Write("Havera depósito inicial (s/n):");
            char resp = char.Parse(Console.ReadLine());
            if( resp == 's' || resp == 'S')
            {

                Console.WriteLine("Entre com o valor do deposito inicial");
                double depositoInicia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicia);

            }
            else
            {

                conta = new ContaBancaria(numero, titular);

            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.WriteLine("Entre com o valar para deposito:");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.WriteLine("Entre com o valor do saque:");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados atualizados da conta:");
            Console.WriteLine(conta);
      
        }



    }
}
