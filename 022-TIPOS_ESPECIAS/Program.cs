
using _022_TIPOS_ESPECIAS;
using _022_TIPOS_ESPECIAS.Models;

//TIPO DE VALOR NULO(NULLABLE)


bool? desejaReceberMaail = null;

// Hasvalue:  vai acessa valor da variavel e verificar se o valor é diferente de nulo

// Value: vai acessar o valor da variavel

// É MUITO IMPORTANTE QUANDO TIVER TRABALHANDO COM TIPO null FAÇA PRIMEIRO A VERIFICAÇÃO HasValue

if(desejaReceberMaail.HasValue && desejaReceberMaail.Value){
    Console.WriteLine("O USUARIO OPTOU POR RECEBER E-MAIL");

}

else{

    Console.WriteLine("O USUÁRIO NÃO RESPONDEU OU OPTOU POR NÃO RECEBER E-MAIL");



}

Console.WriteLine("==================================================");
/////////////////////////////////////////////////////////////////////////////////////////

Vendas x1 = new Vendas(1,"COMPUTADOR",4500M, 100M);

Vendas x2 = new Vendas(2,"IMPRESSORA",1600,null);

List<Vendas> elementos = new List<Vendas>();

elementos.Add(x1);

elementos.Add(x2);


foreach(Vendas Z in elementos){
    Console.WriteLine($"ID: {Z.Id} NOME: {Z.Produtos} PREÇO: {Z.Preco} DESCONTO: {Z.Desconto}");

}

Console.WriteLine("-----------------------------------------");

var tipoAnonimo = new {Nome = "Daniel",Sobrenome = "Nascimento Tomaz", Altura = 1.80};

Console.WriteLine($"NOME: {tipoAnonimo.Nome}");
Console.WriteLine($"SOBRENOME: {tipoAnonimo.Sobrenome}");
Console.WriteLine($"IDADE: {tipoAnonimo.Altura}");

Console.WriteLine("-----------------------------------------");

var listaAnonimo = elementos.Select(x => new {x.Produtos,x.Preco});

foreach(var K in elementos){
     
     Console.WriteLine($"PRODUTO: {K.Produtos}, PREÇO: {K.Preco}");

}

Console.WriteLine("-----------------------------------------");

/// TIPO DE VARIAVEL DINAMICA

dynamic x = 45;

Console.WriteLine(x);

dynamic y = "DANIEL NASCIMENTO TOMAZ";

Console.WriteLine(y);


int c =4;

c = 7;

Console.WriteLine(c);

dynamic g = Console.ReadLine();

int h = g * 5;
//////////////////////////////////////////////////

// INSTANCIANDO A CLASSE MEUARRAY

MeuArray<int> cal1 = new MeuArray<int>();

cal1.AdicionarElementoArray(2);


// CHAMANDO O MÉTODO POR EXTENSÃO

int B = 30;

B.Ehpar();
