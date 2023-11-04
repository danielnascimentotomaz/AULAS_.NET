Stack<int> Pilha = new Stack<int>();

Pilha.Push(1);


Pilha.Push(2);

Pilha.Push(3);

Pilha.Push(4);

Pilha.Push(5);


foreach(int x in Pilha){

    Console.WriteLine(x);
}


/*
Push(T item): Adiciona um item ao topo da pilha.

Stack<int> pilha = new Stack<int>();
pilha.Push(10);
pilha.Push(20);
pilha.Push(30);


Pop(): Remove e retorna o item no topo da pilha.

int itemRemovido = pilha.Pop(); // itemRemovido conterá 30


Peek(): Retorna o item no topo da pilha sem removê-lo. Isso permite verificar o próximo elemento a ser removido sem efetivamente removê-lo.

int topoDaPilha = pilha.Peek(); // topoDaPilha conterá 20


Clear(): Remove todos os elementos da pilha, deixando-a vazia.

pilha.Clear();


Contains(T item): Verifica se a pilha contém o item especificado.


bool contem = pilha.Contains(20); // Retorna true se a pilha contiver o valor 20


Count: Retorna o número de elementos na pilha. Esta é uma propriedade que permite saber quantos elementos estão na pilha.

int tamanhoDaPilha = pilha.Count;

ToArray(): Converte a pilha em um array. Isso é útil se você precisar de uma representação de array dos elementos da pilha.


int[] array = pilha.ToArray();


CopyTo(T[] array, int index): Copia os elementos da pilha para um array a partir de um índice específico no array.


int[] meuArray = new int[10];
pilha.CopyTo(meuArray, 3);



*/