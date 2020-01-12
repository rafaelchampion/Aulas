using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite sua Altura: ");
            //float altura = float.Parse(Console.ReadLine());
            //Console.WriteLine("Digite seu Peso: ");
            //float peso = float.Parse(Console.ReadLine());
            //classeIMC imc = new classeIMC(altura, peso);
            //imc.Resultado();



            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Solano";
            pessoa.Cpf = "462.690.248-03";

            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Rafael";
            pessoa1.Cpf = "000.000.000-00";

            Console.WriteLine(pessoa.Cpf);
            Console.WriteLine(pessoa1.Cpf);
            pessoa.ExibirCpf();
            pessoa1.ExibirCpf();
        }
    }
}
