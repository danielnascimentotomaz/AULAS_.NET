
// Alterando a localização do código:

//using System.Globalization;
//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

//concatenação:

using System.Globalization;

List<String> Nomes = new List<string>();

Nomes.Add("DANIEL NASCIMENTO TOMAZ");
Nomes.Add("SILAS NASCIMENTO TOMAZ");
Nomes.Add("MARCOS PAULO SILVA");

for(int x = 0; x < Nomes.Count; x++){
    String Texto = "N° " + (x + 1) + " -- " + Nomes[x];
    Console.WriteLine(Texto);
    
}

Console.WriteLine("====================");
   
   
    int o = 20;
    string z = "daniel";

    string j = "MEU NOME É " + z +" IDADE " + o;
    Console.WriteLine(j);

// INTERPOLAÇÃO DE STRINGS

Console.WriteLine("====================");

int Idade = 26;
string Nome = "Daniel Nascimento Tomaz";

string Resultado = $"MEU NOME É {Nome} E MINHA IDADE É {Idade}";

Console.WriteLine(Resultado);


// CONCATENAÇÃO DE VALORES:

Console.WriteLine("====================");

string x1 = "20";
string x2 = "40";

string x3 = x1 + x2;

Console.WriteLine(x3);

Console.WriteLine("====================");

// FORMATANDO VALORES MONETARIOS:

decimal r1 = 80.40M;

Console.WriteLine($"{r1:C}");

Console.WriteLine("====================");

// Representando Porcentagem

double Porcentagem = 0.3421;

Console.WriteLine(Porcentagem.ToString("p"));



Console.WriteLine("====================");

// FORMATANDO NÚMEROS:

float H = 20.33344F;

Console.WriteLine($"{H:N2}");

Console.WriteLine("====================");

// FORMATAÇÃO ESPECIAL:

int y = 28092022;

Console.WriteLine(y.ToString("##/##/####"));

Console.WriteLine("====================");

// FORMATANDO O TIPO DATETIME:

DateTime DataHora = DateTime.Now;

Console.WriteLine(DataHora);

// => FORMATAÇÃO:

Console.WriteLine("====================");

Console.WriteLine(DataHora.ToString("dddd/dd/MM/yyyy HH:mm"));

/*
d -> Representa o dia do mês como um número de 1 a 31.

dd -> Representa o dia do mês como um número de 01 a 31.

ddd -> Representa o nome abreviado do dia (Seg, Ter, Qua, etc).

dddd -> Representa o nome completo do dia (segunda, terça, etc).

h -> hora do relógio de 12 horas (por exemplo, 4).

hh -> relógio de 12 horas, com um 0 inicial (por exemplo, 06)

H -> hora do relógio de 24 horas (por exemplo, 15)

HH -> hora do relógio de 24 horas, com um 0 inicial (por exemplo, 22)

m -> Minutos

mm -> Minutos com zero à esquerda

M -> Número do mês (por exemplo, 3)

MM -> Número do mês com zero à esquerda (por exemplo, 04)

MMM -> Nome do mês abreviado (por exemplo, dezembro)

MMMM -> Nome completo do mês (por exemplo, dezembro)

s -> Segundos

ss -> Segundos com zero à esquerda

t -> AM/PM abreviado (por exemplo, A ou P)

tt -> AM / PM (por exemplo, AM ou PM

y -> Ano, sem zero à esquerda (por exemplo, 2015 seria 15)

aa -> Ano, zero à esquerda (por exemplo, 2015 seria 015)

aaaa -> Ano, (por exemplo, 2015)

aaaa -> Ano, (por exemplo, 2015)

K -> Representa as informações de fuso horário de um valor de data e hora (por exemplo, +05:00)

z -> Com valores de DateTime representa o deslocamento assinado do fuso horário do sistema operacional local do

Tempo Universal Coordenado (UTC), medido em horas. (por exemplo, +6)

zz -> Como z, mas com zero à esquerda (por exemplo, +06)

zzz -> Com valores DateTime representa o deslocamento assinado do fuso horário do sistema operacional local do UTC, medido em horas e minutos. (por exemplo, +06:00)

f -> Representa o dígito mais significativo da fração de segundos; ou seja, representa os décimos de segundo em um valor de data e hora.

ff -> Representa os dois dígitos mais significativos da fração de segundos em data e hora

fff -> Representa os três dígitos mais significativos da fração de segundos; ou seja, representa os milissegundos em um valor de data e hora.

ffff -> Representa os quatro dígitos mais significativos da fração de segundos; ou seja, representa os dez milésimos de segundo em um valor de data e hora. Embora seja possível exibir os décimos de milésimos de um segundo componente de um valor de tempo, esse valor pode não ser significativo.

fffff -> Representa os cinco dígitos mais significativos da fração de segundos; ou seja, representa os centésimos de milésimos de segundo em um valor de data e hora.

ffffff -> Representa os seis dígitos mais significativos da fração de segundos; ou seja, representa os milionésimos de segundo em um valor de data e hora.

fffffff -> Representa os sete dígitos mais significativos da fração do segundo; ou seja, representa os dez milionésimos de segundo em um valor de data e hora.

*/


// Convertendo String para DateTime:

Console.WriteLine("====================");

string Data = "28/11/2023 18:00";

DateTime DataConvertida = DateTime.Parse(Data);

Console.WriteLine(DataConvertida);


// Datetime tryingParse:

Console.WriteLine("====================");

string Data2 = "28/12/2023 18:00";

if(DateTime.TryParse(Data2, out DateTime DataConvertida2)){
    Console.WriteLine(DataConvertida2);

}
else{
    Console.WriteLine("Data Inválida");
}

Console.WriteLine("====================");

// Também posso usar tryParseExact:

string Data3 = "28/13/2023 18:00";

if(DateTime.TryParseExact(Data3, "dd/MM/yyyy HH:mm",
                          CultureInfo.InvariantCulture,
                          DateTimeStyles.None, 
                          out DateTime DataConvertida4)){
    Console.WriteLine(DataConvertida4);

}else{
    Console.WriteLine("Data Inválida");
}
      








