using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PROPRIEDADE.Models;

namespace Propriedades.Models
{
    public class Curso
    {
        public String NomeDoCurso{get;set;}
        public List<Pessoa> Alunos{get;set;}


          public Curso(){
            
        }

        public Curso(String nomeDoCurso,List<Pessoa> pessoas){
            this.NomeDoCurso = nomeDoCurso;
            this.Alunos = pessoas;
        }

      
        
        public void AdicionarAluno(Pessoa x){

            Alunos.Add(x);
        }

        public int ObterQuantidadeDeAluno(){
            
            int Quantidade = Alunos.Count;
            return Quantidade; 

        }

        public void RemoverAluno(Pessoa aluno){
           Alunos.Remove(aluno);

        }

        
        public void ListaAluno(){

            foreach(Pessoa V in Alunos){
                
                Console.WriteLine(V.NomeCompleto,V.Idade);


            }
        }
        



        

    }
}