using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROPRIEDADE.Models
{
    public class Pessoa
    {

   

      // CONSTRUTORES 
      
      public Pessoa(){


      }
    // CONSTRUTORES COM PARÂMETRO
    public Pessoa(string nome, int idade){
        this.Nome = nome;
        this.Idade = idade;


    }



        // VALIDAÇÕES NO GET E SET

        /// Pra valida um atributo preciso criar um campo
        private string _nome;
        public string  Nome {

            get{

                return _nome;
               
                
            }

            /* Ou usando Body exception

            get => _nome;



            */

        set{

            if(value == ""){

                throw new ArgumentException("O NOME NÃO PODE SER VAZIO");
            }

            _nome = value;

        }  } 


        
        // VALIDACÃO DA IDADE
        private int _idade;
        public int Idade{

            get {

                return _idade;

                
            }



            set{

                if(value < 0){
                    throw new ArgumentException("A IDADE NÃO PODE SER MENOR QUE 0");

                }

                _idade = value;
            }

        }



       public string SobreNome{get;set;}   
       
        // ATRIBUTO USANDO APENAS O GET(ESTOU USANDO PRA JUNTA NOME É SOBRENOME)
        public string NomeCompleto{

            get{

            return $"{Nome} {SobreNome}";
        }  }
        
        
        // MÉTODO
        public void Aprensentar(){
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");


        }
        
    }
} 