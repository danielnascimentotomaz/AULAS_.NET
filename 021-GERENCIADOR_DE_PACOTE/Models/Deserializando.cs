using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _021_GERENCIADOR_DE_PACOTE.Models
{
    public class Deserializando
    {

       
        public int Id{ get; set; }
        
        [JsonProperty("Produto")] // Caso meu atributo Json venha com outro nome que suja da convenção do c# EX: Nome_Produto  ai vou mapear esse nome pra minha propridade da classe
        public string Produto{get;set;}

        public decimal Preco{ get; set; }

        public DateTime  DataVenda{get;set;}
        
    }
}