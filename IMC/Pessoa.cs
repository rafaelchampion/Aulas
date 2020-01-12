using System;
using System.Collections.Generic;
using System.Text;

namespace IMC
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public void ExibirCpf()
        {
            Console.WriteLine(Cpf);
        }        
    }
}
