//Lopp for 
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}


int soma = 0;
for ( int i = 1; i <= 100; i++)
{
    soma += i; // Soma o valor de i a variavel soma, exemplo: 1+2+3+4....+99+100

}

Console.WriteLine("A soma dos numeros de 1 a 100 é:" + soma);

//LOOP INFINITO
/*
for (; ;)
{
    Console.WriteLine("Este é um loop infinito!"); Significa Erro!
}
*/

//loop while (enquanto)
int contador = 1;

while (contador <= 5)
{
    Console.WriteLine(contador);
    contador++; // Incrementa o contador
}

//Loop Do Whiter (faça enquanto)
int novocontador = 2;

do
{
    Console.WriteLine(novocontador);
    novocontador++; //Incrementa o contador
} while (novocontador <= 5);

//Loop infinito  while

/*while (true)
{
    Console.WriteLine("Este é um loop infinito ");
}
*/

//loop foreach

// uma lista strings
List<string> nomes = new List<string> { "Ana", "Carlos", "Joao", "Maria" };

// Usando o fereach para percorre a lista 
foreach (string nome in nomes)
{
    Console.WriteLine(nome); // Imprime cada nome exibindo na tela

}

// vetor de numeros inteiros
int[] numeros = { 1, 2, 3, 4, 5, };

// Usando o fereach para percorrer o vetor
foreach (int numero in numeros)
    { Console.WriteLine(numero); } // imprime cada numeros exibindo na tela



