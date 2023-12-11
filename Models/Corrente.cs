using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_csharp_oo.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal Valor)
        {
            Saldo += Valor;
        }
    }
}