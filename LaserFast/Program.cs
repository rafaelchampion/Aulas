using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaserFast.Entidades;
using LaserFast.BancoDeDados;

namespace LaserFast
{
    class Program
    {
        static void Main(string[] args)
        {
            BancoDeDados.BancoDeDados.CarregarArquivosJson();
            bool execProgram = true;
            while (execProgram)
            {
                Console.WriteLine("Seja bem vindo a LaserFast\n");
                Console.WriteLine("Escolha uma opção abaixo.\n");
                Console.WriteLine("1. Cadastrar cliente");
                Console.WriteLine("2. Cadastrar colaborador");
                Console.WriteLine("3. Cadastrar comanda");

                Console.WriteLine("\n4. Listar Clientes");
                Console.WriteLine("5. Listar Colaboradores");
                Console.WriteLine("6. Listar Comandas");

                Console.WriteLine("\n7. Buscar Clientes");
                Console.WriteLine("8. Buscar Colaboradores");
                Console.WriteLine("9. Buscar Comandas");

                Console.WriteLine("\n10. Quantidade de clientes");
                Console.WriteLine("\n11. Sair");
                int key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Digite o nome do cliente");
                        string nomeCliente = Console.ReadLine();
                        Console.WriteLine("\nDigite o CPF do cliente");
                        string cpfCliente = Console.ReadLine();
                        Console.WriteLine("\nDigite a data de nascimento do cliente");
                        DateTime datanascimentoCliente = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("\nDigite o Logradouro do cliente");
                        string logradouroCliente = Console.ReadLine();
                        Console.WriteLine("\nDigite a cidade do cliente");
                        string cidadeCliente = Console.ReadLine();
                        Cliente cliente = new Cliente(nomeCliente, cpfCliente, datanascimentoCliente, logradouroCliente, cidadeCliente);
                        BancoDeDados.BancoDeDados.AddCliente(cliente);
                        Console.Clear();
                        Console.WriteLine("Seu número indentificador é: \n" + cliente.Id);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\nDigite o nome do Colaborador");
                        string nomeColaborador = Console.ReadLine();
                        Console.WriteLine("\nDigite o CPF do Colaborador");
                        string cpfColaborador = Console.ReadLine();
                        Console.WriteLine("\nDigite a data de nascimento do Colaborador");
                        DateTime datanascimentoColaborador = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("\nDigite o Logradouro do Colaborador");
                        string logradouroColaborador = Console.ReadLine();
                        Console.WriteLine("\nDigite a cidade do Colaborador");
                        string cidadeColaborador = Console.ReadLine();
                        Colaborador colaborador = new Colaborador(nomeColaborador, cpfColaborador, datanascimentoColaborador, logradouroColaborador, cidadeColaborador);
                        BancoDeDados.BancoDeDados.AddColaborador(colaborador);
                        Console.Clear();
                        Console.WriteLine("Seu número indentificador é: \n" + colaborador.Id);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Cliente, digite seu número identificador: ");
                        int numIdCliente = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Colaborador, digite seu número identificador: ");
                        int numIdColaborador = int.Parse(Console.ReadLine());                                                
                        Comanda comanda = new Comanda(numIdCliente, numIdColaborador);
                        numIdCliente = comanda.IdCliente;
                        numIdColaborador = comanda.IdColaborador;                        
                        comanda.Tratamento();
                        BancoDeDados.BancoDeDados.AddComanda(comanda);
                        break;
                    case 4:
                        foreach(Cliente item in BancoDeDados.BancoDeDados.ListaClientes)
                        {
                            item.ListarDadosCliente();
                        }
                        break;
                    case 5:
                        foreach (Colaborador item in BancoDeDados.BancoDeDados.ListaColaboradores)
                        {
                            item.ListarDadosColaborador();
                        }
                        break;
                    case 6:
                        foreach (Comanda item in BancoDeDados.BancoDeDados.ListarComandas)
                        {
                            item.ListarDadosComanda();
                        }
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("\nDigite o nome do cliente: ");
                        string nomeClienteBusca = Console.ReadLine().ToLower();
                        Cliente clienteExibir = BancoDeDados.BancoDeDados.ListaClientes.FirstOrDefault(x => x.Nome.ToLower().Contains(nomeClienteBusca));
                        if(clienteExibir != null)
                        {
                            clienteExibir.ListarDadosCliente();
                        }
                        else
                        {
                            Console.WriteLine("\nCliente Não Encontrado.");
                        }
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("\nDigite o nome do colaborador: ");
                        string nomeColaboradorBusca = Console.ReadLine().ToLower();
                        Colaborador colaboradorExibir = BancoDeDados.BancoDeDados.ListaColaboradores.FirstOrDefault(x => x.Nome.ToLower().Contains(nomeColaboradorBusca));
                        if (colaboradorExibir != null)
                        {
                            colaboradorExibir.ListarDadosColaborador();
                        }
                        else
                        {
                            Console.WriteLine("\nColaborador Não Encontrado.");
                        }
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("\nDigite o numero da comanda: ");
                        int idComandaBusca = int.Parse(Console.ReadLine());
                        Comanda comandaExibir = BancoDeDados.BancoDeDados.ListarComandas.FirstOrDefault(x => x.Id.Equals(idComandaBusca));
                        if (comandaExibir != null)
                        {
                            comandaExibir.ListarDadosComanda();
                        }
                        else
                        {
                            Console.WriteLine("\nComanda Não Encontrada.");
                        }
                        break;
                    case 10:
                        Console.WriteLine("Existem " + BancoDeDados.BancoDeDados.ListaClientes.Count() + " Clientes cadastrados.");
                        break;
                    case 11:
                        Console.WriteLine("\nVolte sempre.");
                        execProgram = false;
                        Console.ReadLine();
                        break;
                    case 12:
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