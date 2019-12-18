using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal coelho = new Animal("Coelho");
            coelho.consultarNome();
            coelho.imprimirPeso();
            Console.ReadLine();
        }
    }
}
