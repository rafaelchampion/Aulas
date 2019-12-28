using ProjetoClinica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoClinica.BancoDeDados;

namespace ProjetoClinica
{
    class Program
    {
        static void Main(string[] args)
        {
            ExibirMenu();
        }
        public static void ExibirMenu()
        {
            bool executarPrograma = true;
            while (executarPrograma)
            {
                Console.WriteLine("Bem vindo ao software de clínicas.");
                Console.WriteLine("Selecione a opção da operação que deseja realizar:");
                Console.WriteLine("1-Cadastrar paciente;");
                Console.WriteLine("2-Cadastrar profissional;");
                Console.WriteLine("3-Agendar consulta;");
                Console.WriteLine("4-Listar pacientes");
                Console.WriteLine("5-Buscar paciente pelo Nome");
                Console.WriteLine("6-Exibir quantidade de pacientes");
                Console.WriteLine("7-Sair do programa;");
                Console.WriteLine("8-Buscar pacientes pelo CPF");
                int opcaoDigitada = int.Parse(Console.ReadLine());
                switch (opcaoDigitada)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do paciente");
                        string nomePaciente = Console.ReadLine();
                        Console.WriteLine("Digite a data de nascimento do paciente");
                        DateTime dataNascimentoPaciente = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Digite seu CPF");
                        string cpfPaciente = Console.ReadLine();
                        Console.WriteLine("Digite seu Logradouro");
                        string logradouroPaciente = Console.ReadLine();
                        Console.WriteLine("Digite o Numero de sua casa");
                        int numeroPaciente = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite seu Bairro");
                        string bairroPaciente = Console.ReadLine();
                        Console.WriteLine("Digite seu Complemento");
                        string complementoPaciente = Console.ReadLine();
                        Paciente paciente = new Paciente(nomePaciente, dataNascimentoPaciente, cpfPaciente, logradouroPaciente, numeroPaciente, bairroPaciente, complementoPaciente);
                        BancoDeDados.BancoDeDados.AddPaciente(paciente);
                        //SALVAR O PACIENTE EM ALGUM LUGAR
                        Console.WriteLine(paciente.Id);
                        Console.WriteLine("Paciente salvo com sucesso");
                        Console.WriteLine("");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome do paciente");
                        string nomeProfissional = Console.ReadLine();
                        Console.WriteLine("Digite a data de nascimento do paciente");
                        DateTime dataNascimentoProfissional = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Digite seu CPF");
                        string cpfProfissional = Console.ReadLine();
                        Console.WriteLine("Digite seu Logradouro");
                        string logradouroProfissional = Console.ReadLine();
                        Console.WriteLine("Digite o Numero de sua casa");
                        int numeroProfissional = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite seu Bairro");
                        string bairroProfissional = Console.ReadLine();
                        Console.WriteLine("Digite seu Complemento");
                        string complementoProfissional = Console.ReadLine();
                        Profissional profissional = new Profissional(nomeProfissional, dataNascimentoProfissional, cpfProfissional, logradouroProfissional, numeroProfissional, bairroProfissional, complementoProfissional);
                        //SALVAR O PROFISSIONAL EM ALGUM LUGAR
                        Console.WriteLine(profissional.Id);
                        Console.WriteLine("Paciente salvo com sucesso");
                        Console.WriteLine("");
                        Console.ReadLine();
                        break;
                    case 3:
                        break;
                    case 4:
                        foreach (Paciente item in BancoDeDados.BancoDeDados.ListaPacientes)
                        {
                            item.ListarDadosPaciente();
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        Console.WriteLine( "Digite o nome do paciente que quer procurar:");
                        string nomeBuscaPaciente = Console.ReadLine().ToLower();
                        Paciente pacienteAExibir = BancoDeDados.BancoDeDados.ListaPacientes.FirstOrDefault(x => x.Nome.ToLower().Contains(nomeBuscaPaciente));
                        if (pacienteAExibir != null)
                        {
                            pacienteAExibir.ListarDadosPaciente();
                        }
                        else
                        {
                            Console.WriteLine("Paciente não encontrado");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Existem " + BancoDeDados.BancoDeDados.ListaPacientes.Count() + " pacientes cadastrados");
                        break;
                    case 7:
                        Console.WriteLine("Obrigado por usar o software de clínicas");
                        executarPrograma = false;
                        Console.ReadLine();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Digite o CPF: ");
                        string cpf = Console.ReadLine().Replace(".", "").Replace("-", "");
                        Paciente pacienteExibirCpf = BancoDeDados.BancoDeDados.ListaPacientes.FirstOrDefault(x => x.CPF.Replace(".", "").Replace("-", "").Contains(cpf));
                        // Paciente pacienteExibirCpf1 = BancoDeDados.BancoDeDados.ListaPacientes.(cpf);  (buscar por ID);
                        if (pacienteExibirCpf != null)
                        {
                            pacienteExibirCpf.ListarDadosPaciente();
                        }
                        else
                        {
                            Console.WriteLine("Paciente não encontrado");
                        }
                        break;
                    case 9:
                        Console.WriteLine("Digite o nome do profissional que quer procurar:");
                        string nomeBuscaProfissional = Console.ReadLine().ToLower();
                        Paciente profissionalAExibir = BancoDeDados.BancoDeDados.ListaPacientes.FirstOrDefault(x => x.Nome.ToLower().Contains(nomeBuscaProfissional));
                        if (profissionalAExibir != null)
                        {
                            profissionalAExibir.ListarDadosPaciente();
                        }
                        else
                        {
                            Console.WriteLine("Profissional não encontrado");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}