using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Mamifero elefante = new Mamifero("Elefante", 10, 15);
            elefante.Anda();

            double quantidadeDeComidaQueOElefanteComeu = 0;

            double teste = elefante.Come();

            Console.WriteLine("Elefante comeu " + teste);
            Console.WriteLine("Elefante comeu " + elefante.Come());

            Console.ReadLine();
        }
    }
}
