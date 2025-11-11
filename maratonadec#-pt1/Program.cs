// 1.Objetivo: Declarar variáveis, usar concatenação e interpolação

// Declaracão de variável 
using System;
using System.Runtime.Intrinsics.X86;

string nome1 = "Beatriz";

// Usando concatenação "ola, " + nome + "!" 
Console.WriteLine("Olá, " + nome1 + "! Seja bem-vinda ao nosso site!");

// Usando interpolação $"ola, {nome}!"
Console.WriteLine($"Olá, {nome1}! Seja bem-vinda ao nosso site!");

// 2.Objetivo: trabalhar com calculos matematicos e variaveis( conversao de temperaturas Celsius para Fahrenheit)

// Declaracao da constante para conversao
const double fator_conersao = 9.0 / 5.0;
const double ajuste = 32.0;

// Entrada de dados, Daclara a variavel para a temperatura em celsius
Console.Write("Digite a temperatura em Celsius: ");
double celsius = 20;

// Calculo de conversao, aplica a formula de conversao: F = (C * 9/5) + 32
double fahrenheit = (celsius * fator_conersao) + ajuste;

// Saida de dados /
Console.WriteLine($"{celsius} graus Celsius equivalem a {fahrenheit} graus Fahrenheit.");

// 3.Objetivo: impressao de dados do usuario, concatenacao e interpolacao de dados


// Solicita os dados ao usuário
Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();

Console.Write("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite sua cidade: ");
string cidade = Console.ReadLine();


string mensagemConcatenacao = "Meu nome é " + nome + ", tenho " + idade + " anos e moro em " + cidade + ".";
Console.WriteLine("\nUsando concatenação:");
Console.WriteLine(mensagemConcatenacao);


string mensagemInterpolacao = $"Meu nome é {nome}, tenho {idade} anos e moro em {cidade}.";
Console.WriteLine("\nUsando interpolação:");
Console.WriteLine(mensagemInterpolacao);