using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClinica.Entidades
{
    public class Profissional : Pessoa
    {
        public int Id { get; set; }
        public string Especialidade { get; set; }
    }
}