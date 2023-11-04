
Queue<int> fila = new Queue<int>();

fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);


// PERCORRER UMA FILA
foreach(int x in fila){
    Console.WriteLine(x);
}

// REMOVER O PRIMEIRO ELEMENTO DA FILA
// O Dequeue vai remover o primeiro elemento da fila, porque em FILA nao pode remover elemento do meio ou do final da FILA
Console.WriteLine($"REMOVENDO O ELEMENTO: {fila.Dequeue()}");



foreach(int x in fila){
    Console.WriteLine(x);
}


/*
Enqueue(T item): Adiciona um item ao final da fila. Este método é usado para inserir elementos na fila.


Dequeue(): Remove e retorna o item no início da fila. Este método é usado para obter e remover o elemento mais antigo da fila.

int itemRemovido = fila.Dequeue(); // itemRemovido conterá 10


Peek(): Retorna o item no início da fila sem removê-lo. Este método é útil para verificar o próximo elemento que será removido da fila, mas sem efetivamente removê-lo.

int primeiroItem = fila.Peek(); // primeiroItem conterá 20 


Clear(): Remove todos os elementos da fila, deixando-a vazia.

fila.Clear();


Contains(T item): Verifica se a fila contém o item especificado.

bool contem = fila.Contains(20); // Retorna true se a fila contiver o valor 20


Count: Retorna o número de elementos na fila. Essa é uma propriedade que permite saber quantos 

int tamanhoDaFila = fila.Count;


ToArray(): Converte a fila em um array. Isso é útil se você precisar de uma representação de array dos elementos da fila.

int[] array = fila.ToArray();


CopyTo(T[] array, int index): Copia os elementos da fila para um array a partir de um índice específico no array.


int[] meuArray = new int[10];

fila.CopyTo(meuArray, 3);

















*/








