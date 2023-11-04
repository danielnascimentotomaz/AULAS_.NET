using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class PessoaFisica
    {
        public int Idade { get; set; }

        public string? Titulo {get;set;}

       public void Apresentar(){

        Console.WriteLine($"MINHA IDADE É {Idade} e meu nome é {Titulo}");


       }

    }
}