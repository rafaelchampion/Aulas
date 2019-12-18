using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    using System;

    public class Animal
    {
        public string Nome { get; set; }
        public int Peso { get; set; }
        public float Altura { get; set; }

        public Animal(string nome, int peso, float altura)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
        }
        public void imprimirPeso()
        {
            Console.WriteLine("Peso: ");
           Peso = Console.ReadLine();
        }
        public void consultarNome()
        {
            Console.WriteLine("Animal: " + Nome);
        }
    }
}