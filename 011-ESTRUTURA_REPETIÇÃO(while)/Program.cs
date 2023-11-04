/*=> REPETIÇÃO COM TESTE LÓGICO NO INICIO
=> WHILE = ENQUANTO

                SINTAXE DE WHILE

while(condição){

    instrução executadas enquanto condição verdadeira
}

=> MUDANDO O FLUXO DE UM LAÇO:

comando continue => toda vez que encontrar um continue vai igonorar o intrução e voltar pra o começo do laço

=>INTERRONPER O FLUXO:

comando Break => interronpe o laço*/


int valor = 5;
int contador = 1;
while(contador <= 10){

     Console.WriteLine($"{valor} X {contador} = {valor * contador}");

     contador++ ;

}

Console.WriteLine("//////////////////////////////////");

int x = 7;
int y = 1;
while(true){
    Console.WriteLine($"{x} X {y} = {x * y}");

    y++;

    if(y == 11){

        break;
    }




}



