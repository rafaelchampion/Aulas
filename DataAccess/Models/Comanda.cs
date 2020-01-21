using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contexto;
using DataAccess.Repositorio;

namespace DataAccess.Models
{
    public class Comanda : Base
    {
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        [ForeignKey("Colaborador")]
        public int IdColaborador { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Colaborador Colaborador { get; set; }
        public virtual List<ItemComanda> ItemComanda { get; set; }

        public void ListarDadosComanda()
        {
            Console.WriteLine("\nId Comanda: " + Id);
            Console.WriteLine("Id Cliente: " + IdCliente);
            Console.WriteLine("Id Colaborador: " + IdColaborador);
        }
        public void AdicionarTratamentoComanda()
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
                    foreach (Tratamento item in TratamentoRepositorio.ListarTodos())
                    {
                        item.ListarDadosTratamentos();
                    }
                    Console.Write("Digite sua opção: ");

                    int ItemComanda = int.Parse(Console.ReadLine());
                    Tratamento tratamento = TratamentoRepositorio.RetornarTratamentoPorCodigo(ItemComanda);
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
                            ItemComanda itemListaComanda = new ItemComanda();
                            itemListaComanda.IdTratamento = tratamento.Id;
                            itemListaComanda.IdComanda = this.Id;
                            ItemComandaRepositorio.AdicionarItemComanda(itemListaComanda);
                            Console.Clear();
                            Console.WriteLine("Tratamento adicionado a lista com sucesso.\n");
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
    }
}
