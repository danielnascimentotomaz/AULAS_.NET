// vai primeiro exercutar o  as intruções e despois fazer teste logico.

/*

=> REPETIÇÃO COM TESTE NO FINAL(REPITA)

inicio
  cc <= 0
  repita
     cambalhota
     cc <= cc + 1
  ate (cc >= 4)
     break

=>  A ESTRUTURA REPITA EM JAVA ELA FUNCIONA COMO UM REPITA ELA FUNCIONA
COMO UM ENQUANTO DE CABEÇA PRA BAIXO;

c = 0

do{ 
    < INSTRUÇÃO>

}while(CONDIÇÃO);


*/

int soma = 0;
int valorX;

do{
   
    Console.WriteLine("DIGITE UM NUMERO (0 para parar)");
    valorX = Convert.ToInt32(Console.ReadLine());
    soma = soma + valorX;

    

}while(valorX != 0);

Console.WriteLine($"TOTAL DA SOMA DOS NÚMERO DIGITADS É: {soma}");



///////////////////////////////////////////////////////////////

Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>");

string? opcao;

bool exibirMenu = true;

while(exibirMenu){

    Console.Clear(); // limpa a tela
    
    Console.WriteLine("DIGITE A SUA OPÇÃO");
    Console.WriteLine("1 - CADASTRAR CLIENTE");
    Console.WriteLine("2 - BUSCAR CLIENTE");
    Console.WriteLine("3 - APAGAR CLIENTE");
    Console.WriteLine("4 - ENCERRAR");

    opcao = Console.ReadLine();
   
   switch(opcao){
      case "1":
        Console.WriteLine("CADRASTRO DE CLIENTE");
        break;

        case "2":
          Console.WriteLine("BUSCAR CLIENTE");
          break;

        case "3":
           Console.WriteLine("APAGAR CLIENTE");
           break;

        case "4":
           Console.WriteLine("ENCERRAR");
           exibirMenu = false;
           break;

   }

}
Console.WriteLine("PROGRAMA SE ENCERROU");