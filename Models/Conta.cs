using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_csharp_oo.Models
{
    public abstract class Conta
    {
        protected decimal Saldo { get; set; }

        public abstract void Creditar(decimal Valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é {Saldo}");
        }
    }
}