using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaserFast.Entidades
{
    public class Pessoa : Identificavel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
    }
}