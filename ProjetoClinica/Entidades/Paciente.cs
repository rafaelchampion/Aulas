using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClinica.Entidades
{
    public class Paciente : Pessoa
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public Paciente(string nome, DateTime abobrinha)
        {
            Nome = nome;
            DataNascimento = abobrinha;
        }

    }
}
