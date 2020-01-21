using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Cliente : Base
    {
        [ForeignKey("Pessoa")]
        public int IdPessoa { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual List<Comanda> Comandas { get; set; }
        public void ListarDadosCliente()
        {
            Console.WriteLine("\nIdentificador: " + Id);
            Console.WriteLine("Nome: " + Pessoa.Nome);
            Console.WriteLine("CPF: " + Pessoa.CPF);
            Console.WriteLine("Data de nascimento: " + Pessoa.DataNascimento);
            Console.WriteLine("Logradouro: " + Pessoa.Logradouro);
            //Console.WriteLine("Cidade: \n" + Pessoa.Cidade);
        }
    }

}
