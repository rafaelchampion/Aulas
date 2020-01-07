using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Pessoa : Base
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        [ForeignKey("Cidade")]
        public int IdCidade { get; set; }
        public DateTime DataNascimento { get; set; }

        public virtual Cidade Cidade { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Colaborador Colaborador { get; set; }
    }
}
