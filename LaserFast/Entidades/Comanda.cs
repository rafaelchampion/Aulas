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
        public List<Tratamento> ListaTratamentosComanda { get; set; }
        public Comanda(int IdCliente, int IdColaborador)
        {
            this.Id = CriadorIds.CriarNovoId(TipoBancoDeDados.Comanda);
            this.IdCliente = IdCliente;
            this.IdColaborador = IdColaborador;
            this.DataConsulta = DateTime.Now;
            this.ListaTratamentosComanda = new List<Tratamento>();
        }
        public Comanda()
        {

        }
        public void Tratamento()
        {
            bool executarLoop = true;
            do
            {
                Console.WriteLine("Deseja adicionar um ou mais tratamentos na comanda? y/n");
                bool adicionar = Console.ReadLine().ToLower() == "y" ? true : false;
                Console.Clear();
                if (adicionar)
                {
                    Console.WriteLine("Escolha um tratamento abaixo\n");
                    Console.WriteLine("0. Voltar\n");
                    foreach (Tratamento item in BancoDeDados.BancoDeDados.ListaTratamentos)
                    {
                        item.ListarDadosTratamentos();
                    }
                    Console.Write("Digite sua opção: ");

                    int ItemComanda = int.Parse(Console.ReadLine());
                    Tratamento tratamento = BancoDeDados.BancoDeDados.ListaTratamentos.FirstOrDefault(x => x.Id.Equals(ItemComanda));
                    if (tratamento == null && ItemComanda == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Voltando ao menu principal\n");
                        executarLoop = false;
                    }
                    else if (tratamento != null)
                    {
                        Console.Clear();
                        Console.WriteLine("Tratamento escolhido: \n");
                        tratamento.ListarDadosTratamentos();

                        Console.WriteLine("Confirma a inclusão do tratamento na comanda? y/n");
                        bool confirmar = Console.ReadLine().ToLower() == "y" ? true : false;
                        if (confirmar)
                        {
                            ListaTratamentosComanda.Add(tratamento);
                            Console.Clear();
                            Console.WriteLine("Tratamento adicionado a lista com sucesso.\n");
                            //tratamento.ListarDadosTratamentos(); // fazer algo para quando mostrar, esconder o ID. Mostra ID apenas na linha 34
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Tratamento cancelado. Voltando às opções");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInválido.");
                        Console.ReadLine();
                    }
                }
                else
                {
                    executarLoop = false;
                    Console.WriteLine("Voltando ao menu principal");
                }
            }
            while (executarLoop);
        }
        public void ListarDadosComanda()
        {
            Console.WriteLine("\nId Comanda: " + Id);
            Console.WriteLine("Id Cliente: " + IdCliente);
            Console.WriteLine("Id Colaborador: " + IdColaborador);
        }
    }
}


































//////////////////////////////////////////////////////////////////////////////////////////////////////private bool ConfirmarTratamento(TipoTratamento tipo)
//////////////////////////////////////////////////////////////////////////////////////////////////////{
//////////////////////////////////////////////////////////////////////////////////////////////////////    Console.Clear();
//////////////////////////////////////////////////////////////////////////////////////////////////////    Console.WriteLine("\nTratamento escolhido: " + tipo);
//////////////////////////////////////////////////////////////////////////////////////////////////////    Console.WriteLine("R$" + ValorTratamentos(tipo));
//////////////////////////////////////////////////////////////////////////////////////////////////////    Console.WriteLine("\nDeseja confimar? y/n");
//////////////////////////////////////////////////////////////////////////////////////////////////////    string confirmarTratamento = Console.ReadLine();
//////////////////////////////////////////////////////////////////////////////////////////////////////   // confirmarTratamento = TratamentoConfirmado; // n tem como eu fazer isso pq um é string o outro nao
//////////////////////////////////////////////////////////////////////////////////////////////////////    if (confirmarTratamento.ToLower() == "y")
//////////////////////////////////////////////////////////////////////////////////////////////////////    {
//////////////////////////////////////////////////////////////////////////////////////////////////////        Console.Clear();
//////////////////////////////////////////////////////////////////////////////////////////////////////        Console.WriteLine("\nTratamento escolhido com sucesso.");
//////////////////////////////////////////////////////////////////////////////////////////////////////        Console.WriteLine("\nPressione uma tecla para retornar ao menu principal");
//////////////////////////////////////////////////////////////////////////////////////////////////////        Console.ReadLine();
//////////////////////////////////////////////////////////////////////////////////////////////////////        return true;
//////////////////////////////////////////////////////////////////////////////////////////////////////    }
//////////////////////////////////////////////////////////////////////////////////////////////////////    else if (confirmarTratamento.ToLower() == "n")
//////////////////////////////////////////////////////////////////////////////////////////////////////    {
//////////////////////////////////////////////////////////////////////////////////////////////////////        Console.Clear();
//////////////////////////////////////////////////////////////////////////////////////////////////////        Console.WriteLine("\nTratamento não confirmado.");
//////////////////////////////////////////////////////////////////////////////////////////////////////        Console.WriteLine("\nPressione uma tecla para retornar ao menu principal");
//////////////////////////////////////////////////////////////////////////////////////////////////////        Console.ReadLine();
//////////////////////////////////////////////////////////////////////////////////////////////////////        return false;
//////////////////////////////////////////////////////////////////////////////////////////////////////    }
//////////////////////////////////////////////////////////////////////////////////////////////////////    else
//////////////////////////////////////////////////////////////////////////////////////////////////////    {
//////////////////////////////////////////////////////////////////////////////////////////////////////        Console.Clear();
//////////////////////////////////////////////////////////////////////////////////////////////////////        Console.WriteLine("\nOpção Invalida");
//////////////////////////////////////////////////////////////////////////////////////////////////////        Console.WriteLine("\nVocê foi redirecionado ao menu principal");
//////////////////////////////////////////////////////////////////////////////////////////////////////        return false;
//////////////////////////////////////////////////////////////////////////////////////////////////////    }
//////////////////////////////////////////////////////////////////////////////////////////////////////}