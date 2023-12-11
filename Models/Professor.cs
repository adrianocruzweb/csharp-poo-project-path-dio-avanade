using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_csharp_oo.Models
{
    public class Professor : Pessoa
    {
        public Professor()
        {

        }

        public Professor(string nome) : base(nome)
        {

        }
        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade}, e meu Salário é {Salario}");
        }
    }
}