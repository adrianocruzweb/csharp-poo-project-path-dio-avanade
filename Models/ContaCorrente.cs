using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_csharp_oo.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal SaldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = SaldoInicial;
        }

        public int NumeroConta { get; set; }
        private decimal Saldo;

        public void Sacar(decimal valor)
        {
            if(Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("Seu Saldo é: " + Saldo);
        }
    }
}