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
                        //Solicitando o nome ao usuário
                        Console.WriteLine("Digite o nome do paciente");
                        //Lendo o nome vindo do usuário
                        string nomePaciente = Console.ReadLine();

                        //Solicitando a data de nascimento do usuário
                        Console.WriteLine("Digite a data de nascimento do paciente");
                        //Lendo a data de nascimento do usuário
                        DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

                        //Ler do usuário todos os outros campos da classe Paciente

                        //Criand o paciente (instância da classe paciente)
                        Paciente paciente = new Paciente(nomePaciente, dataNascimento);

                        //SALVAR O PACIENTE EM ALGUM LUGAR

                        Console.WriteLine("Paciente salvo com sucesso");
                        Console.WriteLine("");
                        Console.ReadLine();
                        break;
                    case 2:
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