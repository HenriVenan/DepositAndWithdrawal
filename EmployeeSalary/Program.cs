using System;

namespace EmployeeSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o nome do titular: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial: ");
            char depositoInicial = char.Parse(Console.ReadLine());

            

            if (depositoInicial == 's')
            {
                Console.Write("Entre com o valor do saldo inicial: ");
                double valorSaldo = double.Parse(Console.ReadLine());

                Employee conta = new Employee(numeroConta, nomeTitular, valorSaldo);
                Console.WriteLine("\n" + conta);

                Console.Write("Entre com o valor para deposito: ");
                double valorDeposito = double.Parse(Console.ReadLine());
                conta.Deposito(valorDeposito);

                Console.WriteLine("\n" + conta);

                Console.Write("Entre com o valor para saque: ");
                double valorSaque = double.Parse(Console.ReadLine());
                conta.Saque(valorSaque);

                Console.WriteLine("\n" + conta);
            } else if (depositoInicial == 'n')
            {
                Employee conta = new Employee(numeroConta, nomeTitular);
                Console.WriteLine("\n" + conta);

                Console.Write("Entre com o valor para deposito: ");
                double valorDeposito = double.Parse(Console.ReadLine());
                conta.Deposito(valorDeposito);

                Console.WriteLine("\n" + conta);

                Console.Write("Entre com o valor para saque: ");
                double valorSaque = double.Parse(Console.ReadLine());
                conta.Saque(valorSaque);

                Console.WriteLine("\n" + conta);
            } else
            {
                Console.WriteLine("\nResposta Inválida, tente novamente");
            }

            

            
        }
    }
}
