using System;

namespace EmployeeSalary
{
    internal class Employee
    {
        private int numeroConta {  get; }
        private string titular { get; }
        private double saldo { get; set; }

        public Employee(int numeroConta, string titular, double saldo)
        {
            this.numeroConta = numeroConta;
            this.titular = titular;
            this.saldo = saldo;
        }

        public Employee(int numeroConta, string titular)
        {
            this.numeroConta = numeroConta;
            this.titular = titular;
        }

        public void Deposito(double valorDeposito)
        {
            saldo += valorDeposito;
        }

        public void Saque(double valorSaque)
        {
            if (valorSaque > saldo)  
                saldo = 0; 
            else 
                saldo -= valorSaque; 
        }

        public override string ToString()
        {
            return 
                "Conta: " + numeroConta +
                ", Titular: " + titular + 
                ", Saldo: " + saldo;
        }
    }
}
