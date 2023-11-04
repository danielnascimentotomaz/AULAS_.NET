using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _022_TIPOS_ESPECIAS.Models
{

    // classe generica
    public class MeuArray<T>
    {


         private static int capacidade = 10;
        private int contador = 0;
        private T[] array = new T[capacidade];

        public void AdicionarElementoArray(T dados){

            if(contador < 11){

                array[contador] = dados;
                contador++;
            }

        }

        



        
    }
}