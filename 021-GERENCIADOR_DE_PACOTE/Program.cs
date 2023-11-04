using System.Collections.Generic;
using _021_GERENCIADOR_DE_PACOTE.Models;
using Newtonsoft.Json;

// data

DateTime DataAtual = DateTime.Now;


Vendas v1 = new Vendas(1,"Material de escritorio",25.00M,DataAtual);
Vendas v2 = new Vendas(2, "licenca de sofware",110.00M,DataAtual);
Vendas v3 = new Vendas(3, "mouse",25.00M,DataAtual);

// TRANSFORMANDO UM OBJETO em serializado em json

// como ja estalei o pacote Newtonsoft.Json vou usar agora para transforma um objeto em formato json

string serializado =  JsonConvert.SerializeObject(v1, Formatting.Indented);// Formating.Indented vai formatar o arquivo json

string serializado02 =  JsonConvert.SerializeObject(v2, Formatting.Indented);

Console.WriteLine(serializado);
Console.WriteLine("=========================================================");





// Criando um aquirvo na pasta arquivos  com o objeto serializado em json
File.WriteAllText("ArquivoJSON/vendas1.json",serializado);

File.WriteAllText("ArquivoJSON/vendas.json",serializado02);



Console.WriteLine(serializado);

Console.WriteLine("=--=--=--=--=--=--=--=--=-==-->");


//////////////       SERIALIZANDO UM COLEÇÃO    ////////////////


List<Vendas> listaVendas = new List<Vendas>();

listaVendas.Add(v1);
listaVendas.Add(v2);
listaVendas.Add(v3);



string serializadolista = JsonConvert.SerializeObject(listaVendas,Formatting.Indented);


Console.WriteLine(serializadolista);

Console.WriteLine("=========================================================");


// CRIANDO UM ARQUIRVO JSON
File.WriteAllText("ArquivoJSON/lista.Json",serializadolista);

Console.WriteLine("=========================================================");


////////////////////////////////////////////////////////

//////// DESERIALIZANDO UM OBJETO //////

// 1° passo analisar o arquivo JSON 
// 2° passo criar uma classe com atributo existente no arquivo JSON
// 3° passo ler o arguivo JSON

String conteudoArquivo = File.ReadAllText("ArquivoJSON/lista.Json");

/// uma lista de arquivo
List<Deserializando>  listaVenda = JsonConvert.DeserializeObject<List<Deserializando>>(conteudoArquivo);

foreach(Deserializando venda in listaVenda){

    Console.WriteLine($"ID: {venda.Id}, PRODUTO: {venda.Produto}, PRECO: {venda.Preco}, DATA {venda.DataVenda} ");


}

Console.WriteLine("=========================================================");



//////////////////////////////////////////

// deserializando um objeto
string X = File.ReadAllText("ArquivoJSON/vendas.json");

Deserializando  Y = JsonConvert.DeserializeObject<Deserializando>(X);

Console.WriteLine($"ID: {Y.Id},PRODUTO: {Y.Produto},PRECO: {Y.Preco},DATAVENDA: {Y.DataVenda.ToString("dd/MM/yyyy HH:mm:ss")}");

Console.WriteLine("");

