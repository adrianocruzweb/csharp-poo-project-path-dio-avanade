using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_csharp_oo.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade} e sou um aluno nota {Nota}");
        }
    }
}