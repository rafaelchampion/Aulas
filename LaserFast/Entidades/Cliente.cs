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
        public Cliente(string nome, string cpf, DateTime datanascimento, string logradouro, string cidade)
        {
            this.Id = CriadorIds.CriarNovoId(1);
            this.Nome = nome;
            this.Cpf = cpf;
            this.DataNascimento = datanascimento;
            this.Logradouro = logradouro;
            this.Cidade = cidade;
        }
        public void ListarDadosCliente()
        {
            Console.Clear();
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + Cpf);
            Console.WriteLine("Data de nascimento: " + DataNascimento);
            Console.WriteLine("Logradouro: " + Logradouro);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("\nAperte qualquer tecla para voltar ao Menu Principal.");
        }
    }
}