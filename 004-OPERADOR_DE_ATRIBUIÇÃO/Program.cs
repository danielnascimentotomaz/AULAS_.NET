//              OPERADOR DE ATRIBUIÇÃO


// O operador de atribuição = atribui o valor do operando do lado direito a uma variavel,
// um = ou um indexador fornecido pelo operando do lado esquerdo. o resultado de uma expressão
// de atribuição é o valor atribuido um operando do lado esquerdo. O tipo do operandos do lado
// direito deve ser do mesmo tipo ou implicitamente conversivel para o operando do lado esquerdo.


int a = 20;

int b = 30;

int c = a + b;


Console.WriteLine($"A SOMA DE {a} + {b} = {c}");

int v = Convert.ToInt32("5");

Console.WriteLine(v);

// Outra maneira

int H = int.Parse("45");

Console.WriteLine(H);


// CONVERTENDO UM VALOR INTEIRO PARA STRING USANDO ToString
int J = 7;
string U= J.ToString();
//  OU

string VK = Convert.ToString(J);

Console.WriteLine(J);
Console.WriteLine(VK);

// cast implicito

//=> Quando um tipo de dado suporta valores de outo tipo


int L= 599;

double G = L;

Console.WriteLine(G);


Console.WriteLine("-------------------------------------------");

// Convertendo de maneira segura

string ValorString = "10u";
int ValorInteiro = 0;

// Vai tentar converter o valor string em um valor inteiro
int.TryParse(ValorString, out ValorInteiro);

Console.WriteLine(ValorInteiro);


Console.WriteLine("Fim");



