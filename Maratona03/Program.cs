using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Array com 10 peças de carro
        string[] pecas = {
            "Buzina",
            "Volante",
            "Farol",
            "Bomba de agua",
            "Retrovisor",
            "Bico injetor",
            "Radiador",
            "Filtro de Ar",
            "Velas de Ignição",
            "Pastilha de Freio"
        };

        // Imprimindo cada peça usando foreach
        Console.WriteLine("Lista de peças de carro:\n");

        foreach (string peca in pecas)
        {
            Console.WriteLine(peca);
        }

        // "Array associativo" em C# = Dictionary
        Dictionary<string, string> gato = new Dictionary<string, string>()
        {
            { "Nome", "Bills" },
            { "Idade", "3 anos" },
            { "Cor", "e pele" },
            { "Raça", "Sphynx" },
            { "Peso", "3 kg" }
        };

        Console.WriteLine("\nDados do gato que chegou no petshop:\n");

        // Percorrendo o dicionário com foreach
        foreach (var dado in gato)
        {
            Console.WriteLine($"{dado.Key}: {dado.Value}");
        }

        // Adicionando o loop de interação ao final do Main
        string resposta;
        do
        {
            Console.Write("Digite $ para continuar ou qualquer outra tecla para sair: ");
            resposta = Console.ReadLine();

        } while (resposta == "$");

        Console.WriteLine("Programa encerrado!");

        // Segundo exercício: tabuada do 3
        int contador = 1;

        do
        {
            Console.WriteLine($"3 x {contador} = {3 * contador}");
            contador++;
        }
        while (contador <= 10);
    }
}
