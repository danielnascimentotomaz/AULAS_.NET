using System.Net.NetworkInformation;
using PROPRIEDADE.Models;
using Propriedades.Models;

// INSTANCIANDO  A CLASSE PESSOA
Pessoa p1 = new Pessoa();
p1.Nome = "daniel NASCIMENTO TOMAZ";
p1.Idade = 18;


// INSTANCIANDO  A CLASSE PESSOA USANDO O CONSTRUTOR 
Pessoa p2 = new Pessoa("daniel silva",12);

// INSTACIANDO A CLASSE CURSO
Curso CursoDeIngle = new Curso();
CursoDeIngle.NomeDoCurso = "CURSO DE INGLÊS";

// QUANDO TEM UMA LISTA COMO ATRIBUTO VOCÊ PRECISA INICIALIZA-LA  ESSA LISTA CASO NÃO TENHA
// INICIALIZA-LA  NA CLASSE

CursoDeIngle.Alunos = new List<Pessoa>();

// ADICIONANDO UMA PESSOA NA LISTA DE CURSO
CursoDeIngle.AdicionarAluno(p1);


CursoDeIngle.ListaAluno();






