Dictionary<String, int> Pessoa = new Dictionary<string, int>();

Pessoa.Add("Daniel",26);
Pessoa.Add("Lucas",23);
Pessoa.Add("Silas",28);

foreach(KeyValuePair<string,int>  x in Pessoa){

    Console.WriteLine(x);

}
Console.WriteLine("===================================");

/// LISTAR ELEMENTO
 foreach(KeyValuePair<string,int>  x in Pessoa){


       Console.WriteLine($"NOME: {x.Key}, IDADE: {x.Value}");
}
Console.WriteLine("===================================");


/// REMOVER ELEMENTO
Pessoa.Remove("Daniel");

 foreach(KeyValuePair<string,int>  x in Pessoa){


       Console.WriteLine($"NOME: {x.Key}, IDADE: {x.Value}");
}


Console.WriteLine("===================================");

// ALTERANDO VALOR:

Pessoa["Daniel"] = 29;

 foreach(KeyValuePair<string,int>  x in Pessoa){


       Console.WriteLine($"NOME: {x.Key}, IDADE: {x.Value}");
}



Console.WriteLine("===================================");


/// VERIFICANDO DE UMA CHAVE JA FOI ADICIONADA;

string chave = "Daniel";

if(Pessoa.ContainsKey(chave))
{

    Console.WriteLine($"VALOR EXISTENTE {chave}");

}

else{

    Console.WriteLine($"VALOR NÃO EXISTEM SEGURO ADICIONAR CHAVE {chave}");
}


Console.WriteLine("===================================");

// Acessar um valor da chave

Console.WriteLine(Pessoa["Daniel"]);

Console.WriteLine("===================================");
Console.WriteLine("===================================");

////////////////////////////

Console.Write("DIGITE O NOME: ");
string nome = Console.ReadLine();

Console.Write("DIGITE SUA IDADE: ");
int idade = Convert.ToInt16(Console.ReadLine());

if(Pessoa.ContainsKey(nome)){

    Console.WriteLine("NOME JÁ EXISTENTE");
}

else{

    Pessoa.Add(nome,idade);
}

Console.WriteLine("===================================");


foreach(KeyValuePair<string,int>  x in Pessoa){


       Console.WriteLine($"NOME: {x.Key}, IDADE: {x.Value}");
}
