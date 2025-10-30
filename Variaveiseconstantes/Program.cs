//variavel
char letra = 'A';
string nome = "João";
float temperatura = 36.5f;
double salario = 12345.67;
bool estaChovendo = true;

//alterando variaveis 
letra = 'b';
nome = "maria";
temperatura = 37.6f;
salario = 15000.50;
estaChovendo = false;


//constantes
const char simbolo = '$';
const string saudacao = "Bem-vindo ao C#!";
const float pi = 3.14159f;
const double altura = 1.75;
const bool ehverdade = false;
const int numero = 14;



// exibindo os valores originais por interpolação 
Console.WriteLine("Valores originais:");
Console.WriteLine($"Letra: {letra}");
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Temperatura: {temperatura}");
Console.WriteLine($"Salario: {salario}");
Console.WriteLine($"Esta chovendo? {estaChovendo}");


//exibindo os valores originais por concatenação
Console.WriteLine("\nConstantes:");
Console.WriteLine("Simbolo:" + simbolo);
Console.WriteLine("Saudação: " + saudacao);
Console.WriteLine("Valor de pi: " + pi);
Console.WriteLine("altura: " + altura);
Console.WriteLine("É verdade: " + ehverdade);
Console.WriteLine("Numero: " + numero);


