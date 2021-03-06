﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoClinica.Helpers;


namespace ProjetoClinica.Entidades
{
    public class Profissional : Pessoa
    {
        public int Id { get; set; }
        public string Especialidade { get; set; }

        public Profissional(string nome, DateTime datanascimento, string CPF, string logradouro, int numero, string bairro, string complemento)
        {
            if (this.Id != 0)
            {
                this.Id = CriadorDeIds.CriarNovoIdProfissional();
            }
            this.Nome = nome;
            this.DataNascimento = datanascimento;
            this.CPF = CPF;
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Complemento = complemento;
        }

        public Profissional()
        {

        }

        public void ListarDadosProfissional()
        {
            Console.WriteLine("Nome:" + Nome);
            Console.WriteLine("CPF:" + CPF);
            Console.WriteLine("Data de nascimento:" + DataNascimento);
        }
    }
}