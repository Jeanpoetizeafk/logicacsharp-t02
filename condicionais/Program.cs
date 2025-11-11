//1.Condicional IF
string nome = "Ana";

if (nome == "Ana")
{
    Console.WriteLine("ola, Ana!");
}
//2.
string texto = "";

if (string.IsNullOrEmpty(texto))
{
    Console.WriteLine("a string esta vazia.");
}

//3.Condicional IF/ELSE
int idade = 16;

if (idade >=18) //Se
{
    Console.WriteLine("Voce é maior de idade.");
}
else //Se não
{
    Console.WriteLine("Voce é menor de idade.");
}
//3.1 numero Impar sempre 1, Par 0
int numero = 7;

if (numero % 2 == 0)
{
    Console.WriteLine("0 Numero é par");
}
else
{
    Console.WriteLine("0 Numero é impar.");
}
//4
double nota = 6.5;

if (nota >= 9.0)
{
    Console.WriteLine("Voce obteve uma execelente nota! Aprovado com distinçao.");   
}
else if (nota >=7.0)
{
    Console.WriteLine("voce esta aprovado.");
}
else if (nota >=5.0)
{
    Console.WriteLine("Voce esta de recuperaçao.");
}
else if (nota >= 3.0)
    {
    Console.WriteLine("Voce esta com risco de Reprovaçao.");
}
else
{
    Console.WriteLine("Voce foi reprovdo!");
}
//5.Condicional Switch
double pontuaçao = 8.5;

//Arredondando a nota para o inteiro mais proximo - Floor arrendonda para baixo  - Round() Para cime se for 8.6 
int faixaNota = (int)Math.Round(pontuaçao);

switch (faixaNota)
{
    case 10:
         Console.WriteLine("Voce obteve um excelente nota! Aprovado com distinçao.");
            break;
            case 9:
            case 8:
                Console.WriteLine("Voce esta aprovado.");
                break;
            case 7:
            case 6:
                Console.WriteLine("Voce esta em Recuperaçao.");
                break;
            case 5:
            case 4:
            case 3:
                Console.WriteLine("Voce esta com risco de reprovaçao.");
                break;
            default:
                Console.WriteLine("Voce foi reprovado.");
                break;


}