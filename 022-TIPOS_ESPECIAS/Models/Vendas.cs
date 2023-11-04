using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _022_TIPOS_ESPECIAS
{
    public class Vendas
    {  
         // CONSTRUTOR
        public Vendas(int id, string produtos,decimal preco,decimal? desconto){

             this.Id = id;
             this.Produtos = produtos;
             this.Preco = preco;
             this.Desconto = desconto;

       }
        // ATRIBUTOS
        public int Id{ get; set; }
        public String  Produtos{ get; set; }

        public decimal Preco{ get; set; }
       
        // TIPO  NULLABLE
        public decimal? Desconto{ get; set; }

      
      // MÉTODO
       
       public void EXIBIR(){

        Console.WriteLine($"ID: {Id} PRODUTO: {Produtos}");
       }
    
    
    
    
    }

    



    
}