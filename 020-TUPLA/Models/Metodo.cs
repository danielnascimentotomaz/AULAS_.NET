using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _020_TUPLA.Models
{
    public class Metodo
    {    

       
        public (bool,int, string) Calculo(int x, int y){

            bool N = x == y;
            int M = x + y;

            string O = $"A = {x} e B = {y}";


            return(N,M,O);


           
    
            

        }
    }
}