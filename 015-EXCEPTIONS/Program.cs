
using _015_EXCEPTIONS.Models;


try{

string[] linhas = File.ReadAllLines("Arquivo/ArquivoLeitura.txt");

foreach(string linha in linhas){

    Console.WriteLine(linha);
}
}
// EXCEÇÃO ESPECIFICA
catch(FileNotFoundException x){
    Console.WriteLine($"OCORREU UM ERRO NA LEITURA DO ARQUIVO.AQUIRVO NÃO ENCONTRADO. {x.Message}");
}
// EXCEÇÃO ESPECIFICA
catch(DirectoryNotFoundException x){
    Console.WriteLine($"OCORREU UM ERRO NA LEITURA DO ARQUIVO.CAMINHO DA PASTA NÃO ENCONTRADO {x.Message}");
}
// se tiver uma exceções e nao cair na exceção especifica cai na exceção generica
// EXCEÇÃO GENERICA
catch(Exception x ){
      Console.WriteLine($"OCORREU UMA EXCEÇÃO GENERICA {x.Message}");

}

finally{

    Console.WriteLine("CHEGOU ATÉ AQUI");
}

Console.WriteLine("///////////////////////////////////////////////////////////");



// Essa Cla
Excecao x1 = new Excecao();

x1.Metodo4();

x1.Metodo1();



