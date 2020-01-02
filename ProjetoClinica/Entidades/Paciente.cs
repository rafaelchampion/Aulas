using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoClinica.Helpers;

namespace ProjetoClinica.Entidades
{
    public class Paciente : Pessoa
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public Paciente(string nome, DateTime datanascimento, string CPF, string logradouro, int numero, string bairro, string complemento)
        {
            this.Id = CriadorDeIds.CriarNovoIdPaciente();
            this.Nome = nome;
            this.DataNascimento = datanascimento;
            this.CPF = CPF;
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Complemento = complemento;
            this.DataCadastro = DateTime.Now;
        }

        public Paciente()
        {

        }

        public void ListarDadosPaciente()
        {
            Console.WriteLine("Nome:" + Nome);
            Console.WriteLine("CPF:" + CPF);
            Console.WriteLine("Data de nascimento:" + DataNascimento);
        }
    }
}
