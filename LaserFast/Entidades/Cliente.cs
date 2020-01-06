using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaserFast.Helpers;

namespace LaserFast.Entidades
{
    public class Cliente : Pessoa
    {

        public DateTime DataCadastro { get; set; }
        public Cliente(string nome, string cpf, DateTime datanascimento, string logradouro, string cidade)
        {
            this.Id = CriadorIds.CriarNovoId(TipoBancoDeDados.Cliente);
            this.Nome = nome;
            this.Cpf = cpf;
            this.DataNascimento = datanascimento;
            this.Logradouro = logradouro;
            this.Cidade = cidade;
            this.DataCadastro = DateTime.Now;
        }
        public Cliente()
        {

        }
        public void ListarDadosCliente()
        {
            Console.WriteLine("\nIdentificador: " + Id);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + Cpf);
            Console.WriteLine("Data de nascimento: " + DataNascimento);
            Console.WriteLine("Logradouro: " + Logradouro);
            Console.WriteLine("Cidade: \n" + Cidade);
        }
    }
}