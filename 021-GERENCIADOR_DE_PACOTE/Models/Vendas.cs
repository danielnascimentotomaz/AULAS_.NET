using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _021_GERENCIADOR_DE_PACOTE.Models
{
    public class Vendas
    {
        // ATRIBUTO
        public int Id{ get; set; } 
        public string Produto{ get; set; }

        public decimal Preco{get; set;}

        public DateTime DataVenda{get;set;}

    // CONSTRUTOR
    public Vendas(int id, string produto, decimal preco, DateTime datavenda){
          
          this.Id = id;
          this.Produto = produto;
          this.Preco = preco;
          this.DataVenda = datavenda;

    }

 public override string ToString()
{
    return $"ID: {Id}, Produto: {Produto}, Preço: {Preco:C}, Data de Venda: {DataVenda:dd/MM/yyyy}";
}


    



    }
}