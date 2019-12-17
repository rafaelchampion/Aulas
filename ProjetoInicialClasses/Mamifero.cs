using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoInicialClasses
{
    public class Mamifero
    {
        public string Nome { get; set; }
        public double Tamanho { get; set; }
        public int Idade { get; set; }

        public Mamifero(string nome, double tamanho, int idade)
        {
            Nome = nome;
            Tamanho = tamanho;
            Idade = idade;
        }

        public double Come()
        {
            double quantidadeDeComida = 1 * Tamanho;
            return quantidadeDeComida;
        }

        public void Anda()
        {
            Console.WriteLine(Nome + " andou.");
        }
    }
}
