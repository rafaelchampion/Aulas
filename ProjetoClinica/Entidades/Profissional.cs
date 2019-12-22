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

        public Profissional(string nome, DateTime datanascimento, string CPF, string logradouro, int numero, string bairro, string complemento)
        {
            this.Id = CriadorDeIds.CriarNovoIdProfissional();
            this.Nome = nome;
            this.DataNascimento = datanascimento;
            this.CPF = CPF;
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Complemento = complemento;
        }
    }
}