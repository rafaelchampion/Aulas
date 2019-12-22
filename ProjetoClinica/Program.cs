using ProjetoClinica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine("4-Sair do programa;");
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
                        //SALVAR O PACIENTE EM ALGUM LUGAR
                        Console.Writeline(paciente.Id);
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
                        Console.WriteLine(Profissional.Id);
                        Console.WriteLine("Paciente salvo com sucesso");
                        Console.WriteLine("");
                        Console.ReadLine();
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine("Obrigado por usar o software de clínicas");
                        executarPrograma = false;
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}