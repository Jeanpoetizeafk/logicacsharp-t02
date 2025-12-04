using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica14
{
    //Classe base (superclasse)
    internal class Animal
    {
        //Propriedade de classe animal
        public string Nome { get; set; } //atributo público do tipo string

        //Método que será sobrecarregado nas classes derivadas
        public virtual void EmitirSom()
        {
            Console.WriteLine($"O animal {Nome} emite um som.");
        }
    }
    // Classe derivada (subclasse) - "herança"
    internal class Cachorro : Animal
    {
        //Sobrescrevendoo método "EmitirSom"
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} late: Au Au!");
        }
    }

    //Outra Classe derivada
    internal class Gato : Animal
    {
        //sobescrevendo o metodo EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} mia: Miau!");
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando instancias das classes derivadas
            Animal meuCachorro = new Cachorro { Nome = "rex" };
            Animal meuGato = new Gato { Nome = "felix" };
            Animal meuCoelho = new Animal { Nome = "Lulu" };

            //Chamando o metodo EmitirSom para cada animal
            meuCachorro.EmitirSom(); //Saida: Rex Lata: Au Au!
            meuGato.EmitirSom();// Saida: Felix mia: Miau!

            // Utilizando Polimorfismo: Array de animais
            Animal[] animeis = { meuCachorro, meuGato, meuCoelho };

                foreach (var animal in animeis)
            {
                animal.EmitirSom(); // Cada objeto chama o metodo adequado de sua classe

            }
        }
    }

}