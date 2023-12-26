using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }

        // only visible to the class
        private decimal saldo;

        // method to alter tha value of saldo
        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                System.Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                System.Console.WriteLine("Valor desejado é maior que o saldo disponível");
            }

        }

        public void ExibirSaldo()
        {
            System.Console.WriteLine($"Seu saldo disponivel é: {saldo}");
        }
    }
}