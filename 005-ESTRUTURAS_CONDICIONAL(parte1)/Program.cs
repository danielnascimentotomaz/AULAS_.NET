/*
===================================
 >>>>>DESVIO CONDICIONAL SIMPLES:
===================================
if (<condições>){

     <instruções> 

}


=> ESSA INSTRUÇÃO TEM POR FINALIDADE TOMAR UMA DECISÃO DE ACORDO
 COM O RESULTADO DE UMA CONDIÇÃO (TESTE LÓGICO)



=> SE O TESTE RETORNA VERDADEIRO, AS INSTRUÇÕES CONTIDAS ENTRE AS CHAVES
SERÃO EXECUTADOS; CASO CONTRARIO, NADA OCORRE.


>>>> SINTAXE:

if(condição){

   (INSTRUÇÕES CASO CONDIÇÃO RETORNE VERDADEIRO)
}


================================
>>> DEVIO CONDICIONAL COMPOSTO:
================================

° ESSA INTRUÇÃO TEM POR FINALIDADE TOMAR UMA DECISÃO DE ACORDO COM RESULTADO DE UMA
CONDIÇÃO(TESTE LÒGICO)

° SE O TESTE RETORNA VERDADEIRO, AS INTRUÇÕES CODIFICADAS ENTRE AS CHAVES DO if SERÃO
EXECUTADOS.


° SE O TESTE RETORNA FALSO, AS INTRUÇÕES CONTIDAS ENTRE AS CHAVES DO ELSE SERÃO EXECUTADOS.


>>>>>>>>>>>>        SINTAXE

if (CONDIÇÃO){

       (INTRUÇÕES CASO CONDIÇÃO RETORNE VERDADEIRO)
}

else{
       (INTRUÇÕES CASO CONDIÇÃO RETORNE FALSO)

}


*/


int QuantidadeEmEstoque = 10;

int QuantidadeCompra = 4;

bool PossivelVendas = QuantidadeEmEstoque >= QuantidadeCompra;

Console.WriteLine($"QUANTIDADE EM ESTOQUE: {QuantidadeEmEstoque}");

Console.WriteLine($"QUANTIDADE DE COMPRA: {QuantidadeCompra}");

Console.WriteLine($"É POSSIVEL REALIZAR A VENDA? {PossivelVendas}");


if(QuantidadeEmEstoque >= QuantidadeCompra){
    Console.WriteLine("VENDA REALIZADA");
}

else{

    Console.WriteLine("DESCULPA. NÃO TEMOS A QUANTIDADE DESEJADA EM ESTOQUE");
}
 