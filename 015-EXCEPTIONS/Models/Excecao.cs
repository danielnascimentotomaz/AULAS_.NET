using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _015_EXCEPTIONS.Models;

namespace _015_EXCEPTIONS.Models
{
    public class Excecao
    {
        
        public void Metodo1(){
           
           try{
            Metodo2();
            
            }catch(Exception){
                Console.WriteLine("EXCEÇÃO TRATADA");


            }


        }
         public void Metodo2(){

            Metodo3();


        }
         public void Metodo3(){

            Metodo4();


        }
         public void Metodo4(){
            throw new Exception("OCORREU UMA EXEÇÃO");


        }
    }
}