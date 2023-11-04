using ImplementandoClasseCurso.Models;

Pessoa P1 = new Pessoa();

P1.Nome = "daniel nascimento tomaz";
P1.Idade = 26;

Curso Informatica = new Curso();

Informatica.Nome  = "TECNICO DE INFORMATICA";


Informatica.Alunos = new List<Pessoa>();

Informatica.Adicionar(P1);
Informatica.ListarAluno();

















