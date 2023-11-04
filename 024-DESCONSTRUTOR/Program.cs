using DESCONSTRUTOR.Models;


// CONSTRUTOR
Pessoa p1 = new Pessoa("DANIEL","NASCIMENTO");

//DESCONTRUTOR

(string X,string Y) = p1;

 
Console.WriteLine($"{X} {Y}");


