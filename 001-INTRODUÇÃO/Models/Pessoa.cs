using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Caminho da Classe
namespace _001_INTRODUÇÃO.Models
{
    public class Pessoa
    {
        private String Nome{get;set;}
        private int Idade{get;set;}


        // Construtor
        public Pessoa(String nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
        // Construtor Vazio
        public Pessoa()
        {
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }

       

    
}}