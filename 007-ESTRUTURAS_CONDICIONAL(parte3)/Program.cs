/*CONDIÇÃO DE  MÚLTIPLA ESCOLHA(usando Switch)
================================================================================
regras:

=> O SWITCH NÃO FUNCIONA POR INTERVALO;
=> O SWITH NÃO FUNCIONA COM NÚMEROS REAIS


leia("quantidade de pernas)

escolha(pernas)

     caso 1
        tipo = "saci"

    caso 2
       tipo = "bipede"

    caso 4 
       tipo = ""Quadrúpede"
 
escreva(tipo)
    

*/

using System.Diagnostics;

Console.WriteLine("DIGITE UMA LETRA ");
  string? letra = Console.ReadLine();
  string tipo;

switch(letra){

    case "a":
      tipo = " vogal";
      break;
     
    case "e":
      tipo = " vogal";
      break;

    case "i":
      tipo = " vogal";
      break;

    case "o":
       tipo = " vogal";
      break;

    case "u":
       tipo = " vogal";
        break; 
    default:
       tipo = "outro tipo";
       break;

}
Console.WriteLine(tipo);

Console.WriteLine("====================================");

switch(letra){
  case "a":
  case "e":
  case "i":
  case "o":
  case "u":
  Console.WriteLine("vogal");
  break;
  default:
  Console.WriteLine("outro tipo");
  break;

}


