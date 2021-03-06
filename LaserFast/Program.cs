﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaserFast.Entidades;
using LaserFast.BancoDeDados;
using DataAccess.Contexto;
using System.Data.Entity;
using DataAccess.Repositorio;

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
                Console.WriteLine("13. Quantidade de colaboradores");
                Console.WriteLine("14. Quantidade de comandas");
                Console.WriteLine("15. Quantidade de tratamentos");
                Console.WriteLine("\n16. Sair");

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
                        Console.WriteLine("\nDigite a cidade do cliente");
                        string cidadeCliente = Console.ReadLine();
                        //Cliente cliente = new Cliente(nomeCliente, cpfCliente, datanascimentoCliente, logradouroCliente, "Guapiaçu");
                        //BancoDeDados.BancoDeDados.AddCliente(cliente);
                        DataAccess.Models.Pessoa pessoaCliente = new DataAccess.Models.Pessoa()
                        {
                            Nome = nomeCliente,
                            CPF = cpfCliente,
                            DataNascimento = datanascimentoCliente,
                            Logradouro = logradouroCliente,
                            Cidade = cidadeCliente,
                        };
                        DataAccess.Models.Cliente cliente = new DataAccess.Models.Cliente()
                        {
                            Pessoa = pessoaCliente
                        };
                        ClienteRepositorio.AdicionarCliente(cliente);
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
                        DataAccess.Models.Pessoa pessoaColaborador = new DataAccess.Models.Pessoa()
                        {
                            Nome = nomeColaborador,
                            CPF = cpfColaborador,
                            DataNascimento = datanascimentoColaborador,
                            Logradouro = logradouroColaborador,
                            Cidade = cidadeColaborador,
                        };
                        DataAccess.Models.Colaborador colaborador = new DataAccess.Models.Colaborador()
                        {
                            Pessoa = pessoaColaborador
                        };
                        ColaboradorRepositorio.AdicionarColaborador(colaborador);
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
                            check = DataAccess.Contexto.Context.VerificarExistenciaCliente(numIdCliente);
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
                            check = DataAccess.Contexto.Context.VerificarExistenciaColaborador(numIdColaborador);
                            if (check == false)
                            {
                                Console.WriteLine("");
                                Console.Clear();
                                Console.Write("Identificador errado\nDigite novamente: ");
                            }
                        } while (!check);
                        Console.Clear();
                        DataAccess.Models.Comanda comandaDB = new DataAccess.Models.Comanda();
                        using (var db = new Context())
                        {
                            comandaDB.IdCliente = numIdCliente;
                            comandaDB.IdColaborador = numIdColaborador;
                        }
                        ComandaRepositorio.AdicionarComanda(comandaDB);
                        comandaDB.AdicionarTratamentoComanda(); 
                        comandaDB = ComandaRepositorio.RetornarComandaCodigo(comandaDB.Id, new Context());
                        if (comandaDB.ItemComanda.ToList().Count > 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Tratamentos escolhidos na lista: ");
                            foreach (DataAccess.Models.ItemComanda ItemComanda in comandaDB.ItemComanda.ToList())
                            {
                                ItemComanda.Tratamento.ListarDadosTratamentos();
                            }
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Digite o nome do tratamento que deseja cadastrar");
                        string nomeTratamento = Console.ReadLine();
                        Console.WriteLine("Digite o valor do tratamento digitado previamente");
                        decimal valorTratamento = decimal.Parse(Console.ReadLine());
                        DataAccess.Models.Tratamento tratamento = new DataAccess.Models.Tratamento()
                        {
                            Nome = nomeTratamento,
                            Valor = valorTratamento,
                        };
                        using (var db = new Context())
                        {
                            db.Tratamento.Add(tratamento);
                            db.SaveChanges();
                        }
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        using (var db = new Context())
                        {
                            foreach (DataAccess.Models.Cliente item in db.Cliente.ToList())
                            {
                                item.ListarDadosCliente();
                            }
                        }
                        break;
                    case 6:
                        Console.Clear();
                        using (var db = new Context())
                        {

                            foreach (DataAccess.Models.Colaborador item in db.Colaborador.ToList())
                            {
                                item.ListarDadosColaborador();
                            }
                        }
                        break;
                    case 7:
                        Console.Clear();
                        using (var db = new Context())
                        {
                            foreach (DataAccess.Models.Comanda item in db.Comanda.ToList())
                            {
                                item.ListarDadosComanda();
                            }
                        }
                        break;
                    case 8:
                        Console.Clear();
                        using (var db = new Context())
                        {
                            foreach (DataAccess.Models.Tratamento item in db.Tratamento.ToList())
                            {
                                item.ListarDadosTratamentos();
                            }
                        }
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("\nDigite o nome do cliente: ");
                        string nomeClienteBusca = Console.ReadLine().ToLower();
                        using (var db = new Context())
                        {
                            DataAccess.Models.Cliente clienteExibir = db.Cliente.FirstOrDefault(x => x.Pessoa.Nome.ToLower().Contains(nomeClienteBusca));         //BancoDeDados.BancoDeDados.ListaClientes.FirstOrDefault(x => x.Nome.ToLower().Contains(nomeClienteBusca));
                            if (clienteExibir != null)
                            {
                                clienteExibir.ListarDadosCliente();
                            }
                            else
                            {
                                Console.WriteLine("\nCliente Não Encontrado.");
                            }
                        }
                        break;
                    case 10:
                        Console.Clear();
                        Console.WriteLine("\nDigite o nome do colaborador: ");
                        string nomeColaboradorBusca = Console.ReadLine().ToLower();
                        using (var db = new Context())
                        {
                            DataAccess.Models.Colaborador colaboradorExibir = db.Colaborador.FirstOrDefault(x => x.Pessoa.Nome.ToLower().Contains(nomeColaboradorBusca));     //Colaborador colaboradorExibir = BancoDeDados.BancoDeDados.ListaColaboradores.FirstOrDefault(x => x.Nome.ToLower().Contains(nomeColaboradorBusca));
                            if (colaboradorExibir != null)
                            {
                                colaboradorExibir.ListarDadosColaborador();
                            }
                            else
                            {
                                Console.WriteLine("\nColaborador Não Encontrado.");
                            }
                        }
                        break;
                    case 11:
                        Console.Clear();
                        Console.WriteLine("\nDigite o numero da comanda: ");
                        int idComandaBusca = int.Parse(Console.ReadLine());
                        using (var db = new Context())
                        {
                            DataAccess.Models.Comanda comandaExibir = db.Comanda.FirstOrDefault(x => x.Id.Equals(idComandaBusca));   //Comanda comandaExibir = BancoDeDados.BancoDeDados.ListaComandas.FirstOrDefault(x => x.Id.Equals(idComandaBusca));
                            if (comandaExibir != null)
                            {
                                comandaExibir.ListarDadosComanda();
                            }
                            else
                            {
                                Console.WriteLine("\nComanda Não Encontrada.");
                            }
                        }
                        break;
                    case 12:
                        using (var db = new Context())
                        {
                            int count = db.Cliente.Count();
                            Console.WriteLine(count);
                        }
                        break;
                    case 13:
                        using (var db = new Context())
                        {
                            int count = db.Colaborador.Count();
                            Console.WriteLine(count);
                        }
                        break;
                    case 14:
                        using (var db = new Context())
                        {
                            int count = db.Comanda.Count();
                            Console.WriteLine(count);
                        }
                        break;
                    case 15:
                        using (var db = new Context())
                        {
                            int count = db.Tratamento.Count();
                            Console.WriteLine(count);
                        }
                        break;
                    case 16:
                        Console.WriteLine("Volte sempre.");
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