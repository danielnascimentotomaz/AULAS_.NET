using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _020_TUPLA.Models
{
    public class LerturaArquivo
    {
        // Tupla em método
        public (bool ,string[], int) LerArquivo(string caminho){
            try{
            string[] textocomplicado = File.ReadAllLines(caminho);

            return(true,textocomplicado,textocomplicado.Count());
            
                
                }catch(Exception){

                    return(false, new string[0], 0);
                        

                }




        }
        
    }
}