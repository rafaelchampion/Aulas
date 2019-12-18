using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua Altura: ");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu Peso: ");
            float peso = float.Parse(Console.ReadLine());
            classeIMC imc = new classeIMC(altura, peso);
            imc.Resultado();
        }
    }
}
