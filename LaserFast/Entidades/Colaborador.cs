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
            this.Id = CriadorIds.CriarNovoId(2);
            Nome = nome;
            Cpf = cpf;
            DataNascimento = datanascimento;
            Logradouro = logradouro;
            Cidade = cidade;
        }
    }
}