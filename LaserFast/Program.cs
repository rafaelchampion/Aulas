using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaserFast.Entidades;
using LaserFast.BancoDeDados;
using DataAccess.Contexto;
using System.Data.Entity;

namespace LaserFast
{
    class Program
    {
        static void Main(string[] args)
        {
            BancoDeDados.BancoDeDados.CarregarArquivosJson();
            Console.WriteLine("Seja bem vindo a LaserFast");
            bool execProgram = true;
            while (execProgram)
            {
                Console.WriteLine("Escolha uma opção abaixo.\n");
                Console.WriteLine("1. Cadastrar cliente");
                Console.WriteLine("2. Cadastrar colaborador");
                Console.WriteLine("3. Cadastrar comanda");
                Console.WriteLine("4. Cadastrar Tratamentos");

                Console.WriteLine("\n5. Listar Clientes");
                Console.WriteLine("6. Listar Colaboradores");
                Console.WriteLine("7. Listar Comandas");
                Console.WriteLine("8. Listar Tratamentos");

                Console.WriteLine("\n9. Buscar Clientes");
                Console.WriteLine("10. Buscar Colaboradores");
                Console.WriteLine("11. Buscar Comandas");

                Console.WriteLine("\n12. Quantidade de clientes");

                Console.WriteLine("13. Sair");

                Console.Write("\nDigite sua opção: ");
                int key = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (key)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do cliente");
                        string nomeCliente = Console.ReadLine();
                        Console.WriteLine("\nDigite o CPF do cliente");
                        string cpfCliente = Console.ReadLine();
                        Console.WriteLine("\nDigite a data de nascimento do cliente");
                        DateTime datanascimentoCliente = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("\nDigite o Logradouro do cliente");
                        string logradouroCliente = Console.ReadLine();
                        //Cliente cliente = new Cliente(nomeCliente, cpfCliente, datanascimentoCliente, logradouroCliente, cidadeCliente);
                        //BancoDeDados.BancoDeDados.AddCliente(cliente);
                        DataAccess.Models.Pessoa pessoa = new DataAccess.Models.Pessoa()
                        {
                            Nome = nomeCliente,
                            CPF = cpfCliente,
                            DataNascimento = datanascimentoCliente,
                            Logradouro = logradouroCliente,
                        };
                        DataAccess.Models.Cliente cliente = new DataAccess.Models.Cliente()
                        {
                            Pessoa = pessoa
                        };
                        using (var db = new Context())
                        {
                            db.Cliente.Add(cliente);
                            db.SaveChanges();
                        }
                        Console.Clear();
                        Console.WriteLine("Seu número indentificador é: \n" + cliente.Id);
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:

                        Console.WriteLine("Digite o nome do Colaborador");
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
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();

                        bool check = false;
                        int numIdCliente;
                        int numIdColaborador;
                        Console.Write("Cliente, digite seu número identificador: ");
                        do
                        {
                            numIdCliente = int.Parse(Console.ReadLine());
                            check = BancoDeDados.BancoDeDados.VerificarExistenciaCliente(numIdCliente);
                            if (check == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Identificador errado");
                                Console.Write("Digite novamente: ");
                            }
                        } while (!check);
                        Console.Clear();
                        Console.Write("Colaborador, digite seu número identificador: ");
                        do
                        {
                            numIdColaborador = int.Parse(Console.ReadLine());
                            check = BancoDeDados.BancoDeDados.VerificarExistenciaColaborador(numIdColaborador);
                            if (check == false)
                            {
                                Console.WriteLine("");
                                Console.Clear();
                                Console.Write("Identificador errado\nDigite novamente: ");
                            }
                        } while (!check);
                        Console.Clear();
                        bool execComanda = true;
                        Comanda comanda = new Comanda(numIdCliente, numIdColaborador);
                        numIdCliente = comanda.IdCliente;
                        numIdColaborador = comanda.IdColaborador;


                        do
                        {
                            comanda.Tratamento();
                            if (comanda.ListaTratamentosComanda.Count > 0)// && comanda.ListarDadosComanda.Equals(0))
                            {
                                Console.WriteLine("Deseja confirmar a aquisição do tratamento? y/n");
                                string confirmarTratamento = Console.ReadLine().ToLower();
                                if (confirmarTratamento == "y" && comanda.ListaTratamentosComanda != null)
                                {
                                    Console.Clear();
                                    BancoDeDados.BancoDeDados.AddComanda(comanda);
                                    Console.WriteLine("Tratamento confirmado com sucesso.\n");
                                    Console.WriteLine("Deseja escolher outro tratamento?\n");
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Tratamento não confirmado.\n");
                                    Console.WriteLine("Deseja escolher outro tratamento?\n");
                                }                                
                            }
                            else
                            {
                                execComanda = false;
                            }
                        } while (execComanda == true);
                        break;





                    case 4:
                        Console.Clear();
                        Console.WriteLine("Digite o nome do tratamento que deseja cadastrar");
                        string nomeTratamento = Console.ReadLine();
                        Console.WriteLine("Digite o valor do tratamento digitado previamente");
                        decimal valorTratamento = decimal.Parse(Console.ReadLine());
                        Tratamento tratamento = new Tratamento(nomeTratamento, valorTratamento);
                        BancoDeDados.BancoDeDados.AddTratamento(tratamento);
                        Console.Clear();
                        break;

                    case 5:
                        foreach (Cliente item in BancoDeDados.BancoDeDados.ListaClientes)
                        {
                            item.ListarDadosCliente();
                        }
                        break;

                    case 6:
                        foreach (Colaborador item in BancoDeDados.BancoDeDados.ListaColaboradores)
                        {
                            item.ListarDadosColaborador();
                        }
                        break;

                    case 7:
                        foreach (Comanda item in BancoDeDados.BancoDeDados.ListaComandas)
                        {
                            item.ListarDadosComanda();
                        }
                        break;

                    case 8:
                        Console.Clear();
                        foreach (Tratamento item in BancoDeDados.BancoDeDados.ListaTratamentos)
                        {
                            item.ListarDadosTratamentos();
                        }
                        break;

                    case 9:
                        Console.Clear();
                        Console.WriteLine("\nDigite o nome do cliente: ");
                        string nomeClienteBusca = Console.ReadLine().ToLower();
                        Cliente clienteExibir = BancoDeDados.BancoDeDados.ListaClientes.FirstOrDefault(x => x.Nome.ToLower().Contains(nomeClienteBusca));
                        if (clienteExibir != null)
                        {
                            clienteExibir.ListarDadosCliente();
                        }
                        else
                        {
                            Console.WriteLine("\nCliente Não Encontrado.");
                        }
                        break;

                    case 10:
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

                    case 11:
                        Console.Clear();
                        Console.WriteLine("\nDigite o numero da comanda: ");
                        int idComandaBusca = int.Parse(Console.ReadLine());
                        Comanda comandaExibir = BancoDeDados.BancoDeDados.ListaComandas.FirstOrDefault(x => x.Id.Equals(idComandaBusca));
                        if (comandaExibir != null)
                        {
                            comandaExibir.ListarDadosComanda();
                        }
                        else
                        {
                            Console.WriteLine("\nComanda Não Encontrada.");
                        }
                        break;

                    case 12:
                        Console.WriteLine("Existem " + BancoDeDados.BancoDeDados.ListaClientes.Count() + " Clientes cadastrados.");
                        break;

                    case 13:
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