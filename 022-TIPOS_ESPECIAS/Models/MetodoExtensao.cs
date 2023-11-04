using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _022_TIPOS_ESPECIAS.Models
{
    public static class MetodoExtensao
    {

        // MÉTODO DE EXTENSÃO
        public static bool Ehpar(this int numero){

              return numero % 2 == 0;

        }
    }
}