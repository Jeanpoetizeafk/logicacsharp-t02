using System;
using System.IO;





namespace aulaRegistroArquivos
{
    public struct Cliente

    {
        public string Nome;
        public int Idade;
        public string Email;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Declara e uso basico de registro

            Cliente cliente1;
            cliente1.Nome = " João";
            cliente1.Idade = 30;
            cliente1.Email = "joao@example.com";

            Console.WriteLine("===cliente 1 ===");
            Console.WriteLine("Nome: " + cliente1.Nome);
            Console.WriteLine("Idade: " + cliente1.Idade);
            Console.WriteLine(" Email: " + cliente1.Email);
            Console.WriteLine();

            //Segunda Gravaçao e exibiçao de informaçoes
            Cliente cliente2;
            cliente2.Nome = "Maria";
            cliente2.Idade = 25;
            cliente2.Email = "maria@example.com";

            Console.WriteLine("===cliente 2 ===");
            Console.WriteLine("Nome: " + cliente2.Nome);
            Console.WriteLine("Idade: " + cliente2.Idade);
            Console.WriteLine(" Email: " + cliente2.Email);
            Console.WriteLine();

            //Organizaçao
            Cliente[] clientes = new Cliente[2];
            clientes[0].Nome = "João";
            clientes[0].Idade = 30;
            clientes[0].Email = "joao@example.com";
            clientes[1].Nome = "Maria";
            clientes[1].Idade = 25;
            clientes[1].Email = "mariaexemple.com";

            Console.WriteLine("=== Tabela de clientes ===");
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine("Nome: " + cliente.Nome);
                Console.WriteLine("Idade: " + cliente.Idade);
                Console.WriteLine("Email: " + cliente.Email);
                Console.WriteLine();
            }

            //=== gravaçao de dados em  arquivo ===
            Cliente cliente3;
            cliente3.Nome = "Carlos: ";
            cliente3.Idade = 40;
            cliente3.Email = "carlos@exemple.com";

            string caminhoArquivo = "clientes.txt";

            using (StreamWriter sw = new StreamWriter(caminhoArquivo))
            {
                Console.WriteLine("=== Gravação em arquivo ===");
                Console.WriteLine($"informações de {clientes3.nome} gravada em ' {caminhoArquivo}'.");
                Console.WriteLine();

                //Leitura do arquivo gravado
                Console.WriteLine("=== Conteudo do arquivo ===");
                string conteudo = Console.ReadLine();

                Console.WriteLine(""






        }
    }
}