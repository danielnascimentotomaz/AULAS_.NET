// O tipo DateTime

// É UMA MANEIRA DE REPRESENTAR DATA C#

DateTime HoraAtual = DateTime.Now;

Console.WriteLine(HoraAtual);

Console.WriteLine("---------------------------");

// apenas o dia, mes e ano:

Console.WriteLine(HoraAtual.ToString("dd/MM/yyyy"));

Console.WriteLine("---------------------------");
// Apenas hora,minuto e segundo

Console.WriteLine(HoraAtual.ToString("HH:mm:ss"));


Console.WriteLine("---------------------------");

// Apenas dia, mes e ano e hora, minuto e segundo

Console.WriteLine(HoraAtual.ToString("dd/MM/yyyy HH:mm:ss"));

Console.WriteLine("---------------------------");

//Adicionar 5 dias na data atual

Console.WriteLine(HoraAtual.AddDays(5));
