 using _009_OPERADORES_ARITMETICOS.Models;
 
 /*
      ============== OPERADADORES ARITMÉTICO ========================


SOMA = +
SUBTRAÇÃO = -
DIVISÃO = /
MULTIPLICAÇÃO = *
RESTO => %


>>>>>>>> OPERADOREs UNÁRIOS

++ => INCREMENTO => a++ => a = a + 1 

-- => DECREMENTO => a-- => a = a - 1


===== OPERADORES DE ATRIBUIÇÃO:

+= => SOMA E ATRIBUIR => a += b => a = a + b
-= => SUBTRAIR E ATRIBUIR => a -= b => a = a - b
*= => MULTIPLICAR E ATRIBUIR => a *= b => a = a * b
/= => DIVIDIR E ATRIBUIR => a /= b => a = a / b
%= => RESTO ATRIBUIR => a %= b => a = a % b
*/
Calculadora calculo = new Calculadora();

calculo.Soma(2,3);
calculo.Subtrair(5,3);
calculo.Multiplicar(4,5);
calculo.Dividir(20,4);
calculo.Potencia(2,2);
calculo.Seno(90);
calculo.coseno(30);
calculo.tangente(30);
calculo.raizQuadrada(25);

Console.WriteLine("======================================================");

//Operador de incremento e descremento:

// Prefixado: Ja atribui o valor na hora

int x1 = 10;
int y1 = 5;

Console.WriteLine(++x1);
Console.WriteLine(--y1);

Console.WriteLine("======================================================");
// Posfixado: Apenas atribui o valor após a execução

int x2 = 10;
int y2 = 5;

Console.WriteLine(x2++);
Console.WriteLine(y2--);

Console.WriteLine("======================================================");
Console.WriteLine(x2);
Console.WriteLine(y2);

