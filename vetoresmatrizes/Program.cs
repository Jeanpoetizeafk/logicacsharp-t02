

// 1. Declarando de dois vetores 
int[] numeros = { 7, 2, 3, 34, 5 }; //Vetor de inteiros
string[] nomes = { "Ana", "Joao", "Maria", "Carlos" }; // Vetor de strings


//Exibindo os elementos do vetor de numeros com loop for
Console.WriteLine("vetor de numeros (usando for):");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);

}

//Exibindo os elementos do vetor de nomes com loop foreach
Console.WriteLine("\nvetor de nomes (usando foreach:");
foreach (var nome in nomes)
{
    Console.WriteLine(nome); 
}

// ordenaçao de vetor de numeros
Array.Sort(numeros);
Console.WriteLine("\nvetor de numeros ordenado:");
foreach (var n in numeros)
{
    Console.WriteLine(n);
}


int valorprocurado = 5;
int posicaosequencial = pesquisasequencial(numeros, valorprocurado);

if (posicaosequencial != -1)
{
    Console.WriteLine($"\npesquisa sequencial: valor {valorprocurado} encontrado na posiçao{posicaosequencial}.");

}
else
{
    Console.WriteLine($"\npesquisa sequencial: valor {valorprocurado} nao encontrado.");
}

static int pesquisasequencial(int[] vetor, int valor)
{
    for (int i = 0;i < vetor.Length;i++)
    { 
        if (vetor[i] == valor)
            return i; //Retorna o indice do valor encontrado

    }
    return -1; // Retorna -1 se nao encontrado
}



//ordenar antes da pesquisa binaria AULA 25//11/2026
Array.Sort(numeros);


// pesquisa binaria

int posicaobinaria = Array.BinarySearch(numeros, valorprocurado);
if (posicaobinaria < 0)
{
    Console.WriteLine($"pesquisa binaria: valor {valorprocurado} encontrado na posiçao {posicaobinaria}.");
}
else
{
    Console.WriteLine($"pesquisa binaria: vslor {valorprocurado} não encontrado.");
}

//declaracao e manipulaçao de matriz 3x2
int[,] matriz = new int[3, 2]
{
    { 1, 2, },
    { 3, 4, },
    { 5, 6, },

};

Console.WriteLine("\nexibindo" a matriz 3x2:");
    for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 2; j++)
    {
        
        Console.Write(matriz[i, j] + "\t");
    }
    Console.WriteLine();
    }

//manipulaçao: somando 10 a cada elemento
Console.WriteLine("\nmatriz apos adicionar 10 a cada elemento:");
for (int i = 0;i <3;i++)
{
    for (int j = 0; j < 2;j++)
    {
        matriz[i, j] += 10;
        Console.Write(matriz[i, j] + "\t");
       
    }
    Console.WriteLine();
}
