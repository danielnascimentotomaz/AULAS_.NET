/*==> OPERADORES LÓGICOS

>>> and => &&              or => ||                 or excluvisamente => ^      not => 

P   Q   P&&Q              P   Q     P||Q              P    Q    P ^ Q          P  !P

V   V     V               V    V      V               V     V     F            V   F
V   F     F               V    F      V               V     F     V            F   V
F   V     F               F    V      V               F     V     V
F   F     F               F    F      F               F     F     F
*/

// OPERADOR OR
bool ehMaiorDeIdade = true;
bool possuiAutorizaçãoDoResponsavel  = false;

if(ehMaiorDeIdade || possuiAutorizaçãoDoResponsavel){

    Console.WriteLine("ENTRADA LIBERADA");
}

else{

    Console.WriteLine("ENTRADA NÃO LIBERADA");
}

// OPERADOR AND 

bool possuiPresencaMinima = true;

double media = 7.5;

if(possuiPresencaMinima && media >= 7.0){
    Console.WriteLine("APROVADO");

}

else{
    Console.WriteLine("ALUNO REPROVADO");
}

// OPERADOR not

bool choveu = false;
bool estarTarde = false;

if(!choveu && !estarTarde){
  Console.WriteLine("vou pedalar");

}
else{

    Console.WriteLine("VOU PEDALAR OUTRO DIA");
}