using System;
using System.Collections.Generic;

class Progran
{

    static void Main()
    {

        List<string> nomes = new List<string>();

        // adicionando elementos
        nomes.Add("Ana");
        nomes.Add("Bruno");
        nomes.Add("Carlos");

        Console.WriteLine(nomes[0]); //Ana
        Console.WriteLine(nomes[1]); //Bruno
        Console.WriteLine(nomes[2]); //Carlos



        Console.WriteLine("lista apos adicionar elementos:");
        foreach ( String nome in nomes )
        {
            Console.WriteLine(nome);
        }

        //adiciona novo nome
        nomes.Add("Daniel");

        Console.WriteLine("\nLista apos adicionar 'Daniel':");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        //Removendo elementos
        nomes.Remove("Bruno"); // Remove pelo valor

        Console.WriteLine("\nLista apos remover 'Bruno':");
        foreach ( String nome in nomes )
        {
            Console.WriteLine(nome);
        }

        // Removendo pelo indice
        nomes.RemoveAt(0); //Remove o primeiro (Ana)

        Console.WriteLine("\nLista apos remover o indice 0 (Ana):");
        foreach( String nome in nomes )
        {
            Console.WriteLine(nome);
        }

        // Limpando toda a lista
        nomes.Clear();

        Console.WriteLine("\nLista apos Clear():");
        Console.WriteLine("Quantidade de elementos:" + nomes.Count);


    }

}