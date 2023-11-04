using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementandoClasseCurso.Models
{
    public class Curso
    {
        public string Nome{get;set;}
        public List<Pessoa> Alunos{ get; set; }

        public void Adicionar(Pessoa aluno){

            Alunos.Add(aluno);
    
        }

        public int QuantidadeDeAlunoCadrastrados(){

            int Quantidade = Alunos.Count;

            return Quantidade;

        }
        public void RemoverAluno(Pessoa aluno){

            Alunos.Remove(aluno);


        }

        public void ListarAluno(){

            foreach(Pessoa x in Alunos){

                Console.WriteLine(x);
            }



        }

        

            

        }
    }
