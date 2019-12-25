using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaserFast.Entidades;

namespace LaserFast
{
    class Program
    {
        static void Main(string[] args)
        {
            bool execProgram = true;
            while (execProgram)
            {
                Console.WriteLine("Seja bem vindo a LaserFast\n");
                Console.WriteLine("Escolha uma opção abaixo.\n");
                Console.WriteLine("1. Cadastrar cliente");
                Console.WriteLine("2. Cadastrar colaborador");
                Console.WriteLine("3. Criar nova comanda");
                Console.WriteLine("4. Logout");
                string key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Digite o nome do cliente");
                        string nomeCliente = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do cliente");
                        string cpfCliente = Console.ReadLine();
                        Console.WriteLine("Digite a data de nascimento do cliente");
                        DateTime datanascimentoCliente = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o Logradouro do cliente");
                        string logradouroCliente = Console.ReadLine();
                        Console.WriteLine("Digite a cidade do cliente");
                        string cidadeCliente = Console.ReadLine();
                        Cliente cliente = new Cliente(nomeCliente, cpfCliente, datanascimentoCliente, logradouroCliente, cidadeCliente);
                        Console.WriteLine("Seu número indentificador é: " + cliente.Id);
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Digite o nome do Colaborador");
                        string nomeColaborador = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do Colaborador");
                        string cpfColaborador = Console.ReadLine();
                        Console.WriteLine("Digite a data de nascimento do Colaborador");
                        DateTime datanascimentoColaborador = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o Logradouro do Colaborador");
                        string logradouroColaborador = Console.ReadLine();
                        Console.WriteLine("Digite a cidade do cliente");
                        string cidadeColaborador = Console.ReadLine();
                        Colaborador colaborador = new Colaborador(nomeColaborador, cpfColaborador, datanascimentoColaborador, logradouroColaborador, cidadeColaborador);
                        Console.WriteLine("Seu número indentificador é: " + colaborador.Id);
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Write("Cliente, digite seu número identificador: ");
                        int numIdCliente = int.Parse(Console.ReadLine());
                        Console.Write("Colaborador, digite seu número identificador: ");
                        int numIdColaborador = int.Parse(Console.ReadLine());                                                
                        Comanda comanda = new Comanda(numIdCliente, numIdColaborador);
                        numIdCliente = comanda.IdCliente;
                        numIdColaborador = comanda.IdColaborador;
                        Console.Clear();
                        comanda.Tratamento();

                        break;
                    case "4":
                        Console.WriteLine("\nVolte sempre.");
                        execProgram = false;
                        Console.ReadLine();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\nOpção Invalida");
                        Console.WriteLine("Tente Novamente\n");
                        break;
                }
            }
        }
    }
}