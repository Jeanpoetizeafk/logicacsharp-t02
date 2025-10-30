//Soma 

//Declarando constante
const int valor1 = 10;
const int valor2 = 5;

//Soma 
int soma = valor1 + valor2;
Console.WriteLine($"Soma: {valor1} + {valor2} ={soma}");

//subtração
int subtracao = valor1 - valor2;
Console.WriteLine($"Subtração: {valor1} - {valor2} = {subtracao}");

//Multiplicação 

int multiplicacao = valor1 * valor2;
Console.WriteLine($"multiplicação: {valor1} * {valor2} = {multiplicacao}");


//Divisão (resultado) 
int divisao = valor1 / valor2;
Console.WriteLine($"Divisão: {valor1} / {valor2} = {divisao}");

//Resto da divisão
int restodivisao = valor1 % valor2;
Console.WriteLine($"Resto da divisão de: {valor1} / {valor2} = {restodivisao}");

//pontencial(usando math.pow para calcular a potencia)
double potencia = Math.Pow(valor1, valor2);
Console.WriteLine($"potenciação: {valor1} elevado a {valor2} = {potencia}");

/*(comwentário mais de 1 linha ao mesmo tempo)
/* ordem
 * *de
 * grandeza */

// Exemplo 1: Sem Parênteses 
int resultado1 = 3 + 5 * 2; // multiplicação tem prioridade
Console.WriteLine($"Resultado 1 (sem parênteses): 3 + 5 * 2 = {resultado1}");

//Exemplo 1: Com parenteses
int resultado2 = (3 + 5) * 2; // parenteses alterem a ordem
Console.WriteLine($"Resultado 2 (com parenteses): (3 + 5) * 2 = {resultado2}");

//Exemplo 2: Sem Parenteses
int resultado3 = 8 / 4 + 3; // Divisão tem prioridade
Console.WriteLine($"Resultado 3 (sem parenteses): 8 / 4 + 3 = {resultado3}");

//Exemplo 2: Com Parenteses
double resultado4 = 8.0 / (4 + 3); // parenteses Alteram a ordem 
Console.WriteLine($"Resultado 4 (com parenteses): 8 / (4 + 3) = {resultado4}");








