using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_csharp_oo.Interfaces
{
    public interface ICalculadora
    {
        int Add(int numeroUm, int numeroDois);
        int Subtract(int numeroUm, int numeroDois);
        int Multiply(int numeroUm, int numeroDois);
        int Divide(int numeroUm, int numeroDois)
        {
            return numeroDois / numeroUm;
        }
    }
}