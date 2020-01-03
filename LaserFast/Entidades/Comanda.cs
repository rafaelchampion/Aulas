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
        public int IdComanda { get; set; }
        public DateTime DataConsulta { get; set; }
        public int IdCliente { get; set; }
        public int IdColaborador { get; set; }
        public string ItemComanda { get; set; }
        private const decimal ValorTratamentoPernas = 2690;
        private const decimal ValorTratamentoCostas = 3590;
        private const decimal ValorTratamentoPeito = 2190;
        private const decimal ValorTratamentoVirilha = 6695;
        public const string NomeTratamentoPerna = "Pernas inteiras";
        public const string NomeTratamentoCostas = "Costas";
        public const string NomeTratamentoPeito = "Peito";
        public const string NomeTratamentoVirilha = "Virilha";
        public Comanda(int IdCliente, int IdColaborador)
        {
            this.IdComanda = CriadorIds.CriarNovoId(3);
            this.IdCliente = IdCliente;
            this.IdColaborador = IdColaborador;
        }

        public Comanda()
        {

        }
        public decimal ValorTratamentos(string TipoTratamento)
        {
            switch (TipoTratamento)
            {
                case "Pernas":
                    return ValorTratamentoPernas;
                case "Costas":
                    return ValorTratamentoCostas;
                case "Peito":
                    return ValorTratamentoPeito;
                case "Virilha":
                    return ValorTratamentoVirilha;
                default:
                    Console.WriteLine("Verifica a string seu bobão");
                    return 0;
            }
        }
        public void Tratamento()
        {
            Console.WriteLine("Escolha um tratamento abaixo\n");
            Console.WriteLine("1. " + NomeTratamentoPerna);
            Console.WriteLine("2. " + NomeTratamentoCostas);
            Console.WriteLine("3. " + NomeTratamentoPeito);
            Console.WriteLine("4. " + NomeTratamentoVirilha);
            int key = int.Parse(Console.ReadLine());
            if(key == 1)
            {
                ItemComanda = ("Tratamento: " + NomeTratamentoPerna + "\n" + "Valor: " + ValorTratamentos("Pernas"));

            }
            else if (key == 2)
            {
                ItemComanda = ("Tratamento: " + NomeTratamentoCostas + "\n" + "Valor: " + ValorTratamentos("Costas"));
            }
            if (key == 3)
            {
                ItemComanda = ("Tratamento: " + NomeTratamentoPeito + "\n" + "Valor: " + ValorTratamentos("Peito"));
            }
            else if (key == 4)
            {
                ItemComanda = ("Tratamento: " + NomeTratamentoVirilha + "Valor: " + ValorTratamentos("Virilha"));
            }

            switch (key)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("\nTratamento escolhido:" + NomeTratamentoPerna);
                    Console.WriteLine("R$" + ValorTratamentos("Pernas"));
                    Console.WriteLine("\nDeseja confimar? y/n");
                    string confirmarPernas = Console.ReadLine();
                    if (confirmarPernas == "y")
                    {
                        Console.Clear();
                        Console.WriteLine("\nTratamento escolhido com sucesso.");
                        Console.WriteLine("\nPressione uma tecla para retornar ao menu principal");
                        Console.ReadLine();
                    }
                    else if (confirmarPernas == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("\nTratamento não confirmado.");
                        Console.WriteLine("\nPressione uma tecla para retornar ao menu principal");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nOpção Invalida");
                        Console.WriteLine("\nVocê foi redirecionado ao menu principal");
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("\nTratamento escolhido: " + NomeTratamentoCostas);
                    Console.WriteLine("R$" + ValorTratamentos("Costas"));
                    Console.WriteLine("\nDeseja confimar? y/n");
                    string confirmarPeito = Console.ReadLine();
                    if (confirmarPeito == "y")
                    {
                        Console.Clear();
                        Console.WriteLine("\nTratamento escolhido com sucesso.");
                        Console.WriteLine("\nPressione uma tecla para retornar ao menu principal");
                        Console.ReadLine();
                    }
                    else if (confirmarPeito == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("\nTratamento não confirmado.");
                        Console.WriteLine("\nPressione uma tecla para retornar ao menu principal");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nOpção Invalida");
                        Console.WriteLine("\nVocê foi redirecionado ao menu principal");
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("\nTratamento escolhido: " + NomeTratamentoPeito );
                    Console.WriteLine("R$" + ValorTratamentos("Peito"));
                    Console.WriteLine("\nDeseja confimar? y/n");
                    string confirmarCostas = Console.ReadLine();
                    if (confirmarCostas == "y")
                    {
                        Console.Clear();
                        Console.WriteLine("\nTratamento escolhido com sucesso.");
                    }
                    else if (confirmarCostas == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("\nTratamento não confirmado.");
                        Console.WriteLine("\nPressione uma tecla para retornar ao menu principal");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nOpção Invalida");
                        Console.WriteLine("\nVocê foi redirecionado ao menu principal");
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("\nTratamento escolhido: " + NomeTratamentoVirilha);
                    Console.WriteLine("R$" + ValorTratamentos("Virilha"));
                    Console.WriteLine("\nDeseja confimar? y/n");
                    string confirmarVirilha = Console.ReadLine();
                    if (confirmarVirilha == "y")
                    {
                        Console.Clear();
                        Console.WriteLine("\nTratamento escolhido com sucesso.");
                        Console.WriteLine("\nPressione uma tecla para retornar ao menu principal");
                        Console.ReadLine();
                    }
                    else if (confirmarVirilha == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("\nTratamento não confirmado.");
                        Console.WriteLine("\nPressione uma tecla para retornar ao menu principal");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();                        
                        Console.WriteLine("\nOpção Invalida");
                        Console.WriteLine("\nVocê foi redirecionado ao menu principal");
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\nOpção Invalida");
                    Console.WriteLine("\nVocê foi redirecionado ao menu principal");
                    break;
            }
        }
        public void ListarDadosComanda()
        {
            Console.WriteLine("Id Comanda: " + IdComanda);
            Console.WriteLine("Id Cliente: " + IdCliente);
            Console.WriteLine("Id Colaborador: " + IdColaborador);
            Console.WriteLine(ItemComanda + "\n");
        }
    }
}