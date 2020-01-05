using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaserFast.Helpers;

namespace LaserFast.Entidades
{
    public class Comanda : Identificavel
    {
        public DateTime DataConsulta { get; set; }
        public int IdCliente { get; set; }
        public int IdColaborador { get; set; }
        public string ItemComanda { get; set; }
        public bool TratamentoConfirmado { get; set; }
        private const decimal ValorTratamentoPernas = 2690;
        private const decimal ValorTratamentoCostas = 3590;
        private const decimal ValorTratamentoPeito = 2190;
        private const decimal ValorTratamentoVirilha = 6695;
        public Comanda(int IdCliente, int IdColaborador)
        {
            this.Id = CriadorIds.CriarNovoId(TipoBancoDeDados.Comanda);
            this.IdCliente = IdCliente;
            this.IdColaborador = IdColaborador;
            this.DataConsulta = DateTime.Now;
        }
        public Comanda()
        {

        }
        public decimal ValorTratamentos(TipoTratamento tipo)
        {
            switch (tipo)
            {
                case TipoTratamento.Pernas:
                    return ValorTratamentoPernas;
                case TipoTratamento.Costas:
                    return ValorTratamentoCostas;
                case TipoTratamento.Peito:
                    return ValorTratamentoPeito;
                case TipoTratamento.Virilha:
                    return ValorTratamentoVirilha;
                default:
                    Console.WriteLine("Verifica a string seu bobão");
                    return 0;
            }
        }
        public void Tratamento()
        {
            Console.WriteLine("Escolha um tratamento abaixo\n");
            Console.WriteLine("1. " + TipoTratamento.Pernas);
            Console.WriteLine("2. " + TipoTratamento.Costas);
            Console.WriteLine("3. " + TipoTratamento.Peito);
            Console.WriteLine("4. " + TipoTratamento.Virilha);
            int key = int.Parse(Console.ReadLine());
            if (key == 1)
            {
                ItemComanda = ("Tratamento: " + TipoTratamento.Pernas + "\n" + "Valor: " + ValorTratamentos(TipoTratamento.Pernas));
                TratamentoConfirmado = ConfirmarTratamento(TipoTratamento.Pernas);
            }
            else if (key == 2)
            {
                ItemComanda = ("Tratamento: " + TipoTratamento.Costas + "\n" + "Valor: " + ValorTratamentos(TipoTratamento.Costas));
                TratamentoConfirmado = ConfirmarTratamento(TipoTratamento.Costas);
            }
            else if (key == 3)
            {
                ItemComanda = ("Tratamento: " + TipoTratamento.Peito + "\n" + "Valor: " + ValorTratamentos(TipoTratamento.Peito));
                TratamentoConfirmado = ConfirmarTratamento(TipoTratamento.Peito);
            }
            else if (key == 4)
            {
                ItemComanda = ("Tratamento: " + TipoTratamento.Virilha + "Valor: " + ValorTratamentos(TipoTratamento.Virilha));
                TratamentoConfirmado = ConfirmarTratamento(TipoTratamento.Virilha);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nOpção Invalida");
                Console.WriteLine("\nVocê foi redirecionado ao menu principal");
            }
        }
        private bool ConfirmarTratamento(TipoTratamento tipo)
        {
            Console.Clear();
            Console.WriteLine("\nTratamento escolhido: " + tipo);
            Console.WriteLine("R$" + ValorTratamentos(tipo));
            Console.WriteLine("\nDeseja confimar? y/n");
            string confirmarTratamento = Console.ReadLine();
            if (confirmarTratamento.ToLower() == "y")
            {
                Console.Clear();
                Console.WriteLine("\nTratamento escolhido com sucesso.");
                Console.WriteLine("\nPressione uma tecla para retornar ao menu principal");
                Console.ReadLine();
                return true;
            }
            else if (confirmarTratamento.ToLower() == "n")
            {
                Console.Clear();
                Console.WriteLine("\nTratamento não confirmado.");
                Console.WriteLine("\nPressione uma tecla para retornar ao menu principal");
                Console.ReadLine();
                return false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nOpção Invalida");
                Console.WriteLine("\nVocê foi redirecionado ao menu principal");
                return false;
            }
        }
        public void ListarDadosComanda()
        {
            Console.WriteLine("Id Comanda: " + Id);
            Console.WriteLine("Id Cliente: " + IdCliente);
            Console.WriteLine("Id Colaborador: " + IdColaborador);
            Console.WriteLine(ItemComanda + "\n");
        }
    }

}