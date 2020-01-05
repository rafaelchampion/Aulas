using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaserFast.Helpers;

namespace LaserFast.Entidades
{
    public class Colaborador : Pessoa
    {
        public Colaborador(string nome, string cpf, DateTime datanascimento, string logradouro, string cidade)
        {
            this.Id = CriadorIds.CriarNovoId(TipoBancoDeDados.Colaborador);
            Nome = nome;
            Cpf = cpf;
            DataNascimento = datanascimento;
            Logradouro = logradouro;
            Cidade = cidade;
        }
        public Colaborador()
        {

        }
        public void ListarDadosColaborador()
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