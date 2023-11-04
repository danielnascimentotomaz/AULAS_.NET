 // OPERADOR TERNARIO

int x1,x2,R;

x1 = 4;
x2 = 5;
// TRADUZINDO SE x1 FOR MAIOR DO x2 R = x1 SE NÃO R = x2
R = x1 > x2 ? x1:x2;

Console.WriteLine(R);

Console.WriteLine("=============================");

// PAR OU IMPAR

int T ;
string z;

Console.Write("DIGITE UM VALOR: ");
T = Convert.ToInt32(Console.ReadLine());

z = (T % 2 == 0) ? "par": "IMPAR";



Console.WriteLine($"O NÚMERO {T} É {z}");








