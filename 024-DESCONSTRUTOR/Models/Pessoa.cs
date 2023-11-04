using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DESCONSTRUTOR.Models
{
    public class Pessoa
    {

        // CONSTRUTOR
        public Pessoa(string x, string y){

            Nome = x;
            Sobrenome = y;
        }
        
        // DESCONSTRUTOR VAI SEPARAR O CONSTRUTOR EM VARIAVEL SEPARADA
        public void Deconstruct(out string nome, out string sobrenome){

            nome = Nome;
            sobrenome = Sobrenome;


        }

       


        // ATRIBUTOS
        public String Nome { get; set; }
        public string Sobrenome{get;set;}
        
    }
}