/*         TUPLAS

Tupla fonece sintaxe concisa para agrupar vários elementos de dados em uma estruturas de dados leve.


*/

using _020_TUPLA.Models;


(string Nome, string Sobrenome,int IDADE) dados = ("Daniel", "Nascimento Tomaz", 26);

Console.WriteLine($"NOME: {dados.Nome}");
Console.WriteLine($"SOBRENOME: {dados.Sobrenome}");
Console.WriteLine($"IDADE: {dados.IDADE}");


Console.WriteLine("______________________________");
Console.WriteLine(dados);

Console.WriteLine("=============================");

// OUTRA SINTAXE DA TUPLA

// Essas duas sintaxe de tupla eu nao consigo nomea meus elementos
ValueTuple<string,string,int> dados01 = ("Antonio","Silva",33);
Console.WriteLine(dados01.Item1);


var dados02 = Tuple.Create("Maria","Amorim",42);


Console.WriteLine(dados02.Item1);

/////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////

/// Instanciando a classe LeituraArquivo

Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>");

LerturaArquivo X1 = new LerturaArquivo();

// O var serve pra não precisar passar o tipo
 var(sucesso,linhaArquivo,QuantidadeLinha) = X1.LerArquivo("arquivoLeitura.txt");


if(sucesso){
    Console.WriteLine($"QUANTIDADE LINHAS DO ARQUIVO: {QuantidadeLinha}");
    
    foreach(String y in linhaArquivo ){
        Console.WriteLine(y);
    }
    
   
}

else
    {
        Console.WriteLine("NÃO FOI POSSIVEL LER O ARQUIVO");
    }

/////////////////////////////////////////////////////////////////////////////
///
(bool sucesso,string[] Texto,int QuantidadeLinha ) Arquivo = X1.LerArquivo("arquivoLeitura.txt");

if(Arquivo.sucesso){

 Console.WriteLine($"QUANTIDADE LINHAS DO ARQUIVO: {Arquivo.QuantidadeLinha}");
    
    foreach(String y in Arquivo.Texto ){
        Console.WriteLine(y);
    }
    
   
}

else
    {
        Console.WriteLine("NÃO FOI POSSIVEL LER O ARQUIVO");
    }
















Console.WriteLine("=================================");

Metodo u = new Metodo();


var(a,b,O) = u.Calculo(5,5);

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(O);




Console.WriteLine("===================================");
