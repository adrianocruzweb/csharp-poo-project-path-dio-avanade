using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trilha_csharp_oo.Interfaces;

namespace trilha_csharp_oo.Models
{
    public class Calculadora : ICalculadora
    {
        public int Add(int numeroUm, int numeroDois)
        {
            return numeroUm + numeroDois;
        }

        public int Divide(int numeroUm, int numeroDois)
        {
            return numeroUm / numeroDois;
        }

        public int Multiply(int numeroUm, int numeroDois)
        {
            return numeroUm * numeroDois;
        }

        public int Subtract(int numeroUm, int numeroDois)
        {
            return numeroUm - numeroDois;
        }
    }
}