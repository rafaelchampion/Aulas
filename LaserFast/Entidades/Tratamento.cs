using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaserFast.Helpers;

namespace LaserFast.Entidades
{
    public class Tratamento : Identificavel
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public Tratamento(string nome, decimal valor)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.Id = CriadorIds.CriarNovoId(TipoBancoDeDados.Tratamento);
        }
        public Tratamento()
        {

        }
        public void ListarDadosTratamentos()
        {
            Console.WriteLine(Id + ". " + "Tratamento: " + Nome);
            Console.WriteLine("Valor: " + Valor + "\n");
        }
    }
}
