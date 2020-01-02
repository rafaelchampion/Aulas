using ProjetoClinica.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProjetoClinica.Helpers;

namespace ProjetoClinica.BancoDeDados
{
    public static class BancoDeDados
    {
        private const string DriveArquivoJson = "D:\\";
        private const string CaminhoArquivoJson = "BancoDedados\\";

        public static List<Paciente> ListaPacientes { get; set; }
        public static List<Profissional> ListaProfissionais { get; set; }
        public static List<Consulta> ListaConsultas { get; set; }

        static BancoDeDados()
        {
            ListaPacientes = new List<Paciente>();
            ListaProfissionais = new List<Profissional>();
            ListaConsultas = new List<Consulta>();
        }
        public static void AddPaciente(Paciente paciente)
        {
            ListaPacientes.Add(paciente);
            SalvarArquivoJson(TipoBancoDeDados.Paciente);
        }

        public static void AddProfissional(Profissional profissional)
        {
            ListaProfissionais.Add(profissional);
            SalvarArquivoJson(TipoBancoDeDados.Profissional);
        }

        public static void AddConsulta(Consulta consulta)
        {
            ListaConsultas.Add(consulta);
            SalvarArquivoJson(TipoBancoDeDados.Consulta);
        }

        private static void SalvarArquivoJson(TipoBancoDeDados tipo)
        {
            switch (tipo)
            {
                case TipoBancoDeDados.Paciente:
                    StreamWriter escritorPacientes = new StreamWriter($"{DriveArquivoJson}{CaminhoArquivoJson}ListaPacientes.json");
                    string jsonPacientes = JsonConvert.SerializeObject(ListaPacientes);
                    escritorPacientes.WriteLine(jsonPacientes);
                    escritorPacientes.Dispose();
                    break;
                case TipoBancoDeDados.Profissional:
                    StreamWriter escritorProfissionais = new StreamWriter($"{DriveArquivoJson}{CaminhoArquivoJson}ListaProfissionais.json");
                    string jsonProfissionais = JsonConvert.SerializeObject(ListaProfissionais);
                    escritorProfissionais.WriteLine(jsonProfissionais);
                    escritorProfissionais.Dispose();
                    break;
                case TipoBancoDeDados.Consulta:
                    StreamWriter escritorConsultas = new StreamWriter($"{DriveArquivoJson}{CaminhoArquivoJson}ListaConsultas.json");
                    string jsonConsultas = JsonConvert.SerializeObject(ListaConsultas);
                    escritorConsultas.WriteLine(jsonConsultas);
                    escritorConsultas.Dispose();
                    break;
                default:
                    break;
            }
        }

        public static void CarregarArquivosJson()
        {
            //Pacientes
            if (File.Exists($"{DriveArquivoJson}{CaminhoArquivoJson}ListaPacientes.json"))
            {
                StreamReader leitorArquivoPacientes = new StreamReader($"{DriveArquivoJson}{CaminhoArquivoJson}ListaPacientes.json");
                string pacientes = leitorArquivoPacientes.ReadToEnd();
                leitorArquivoPacientes.Dispose();
                ListaPacientes = JsonConvert.DeserializeObject<List<Paciente>>(pacientes);
                int maxId = ListaPacientes.Max(x => x.Id) + 1;
                CriadorDeIds.IncializarIdPaciente(maxId);
            }

            //Profissionais
            if (File.Exists($"{DriveArquivoJson}{CaminhoArquivoJson}ListaProfissionais.json"))
            {
                StreamReader leitorArquivoProfissionais = new StreamReader($"{DriveArquivoJson}{CaminhoArquivoJson}ListaProfissionais.json");
                string profissionais = leitorArquivoProfissionais.ReadToEnd();
                leitorArquivoProfissionais.Dispose();
                ListaProfissionais = JsonConvert.DeserializeObject<List<Profissional>>(profissionais);
                int maxId = ListaProfissionais.Max(x => x.Id) + 1;
                CriadorDeIds.IncializarIdProfissional(maxId);
            }

            //Consultas
            if (File.Exists($"{DriveArquivoJson}{CaminhoArquivoJson}ListaConsultas.json"))
            {
                StreamReader leitorArquivoConsultas = new StreamReader($"{DriveArquivoJson}{CaminhoArquivoJson}ListaConsultas.json");
                string consultas = leitorArquivoConsultas.ReadToEnd();
                leitorArquivoConsultas.Dispose();
                ListaConsultas = JsonConvert.DeserializeObject<List<Consulta>>(consultas);
                int maxId = ListaConsultas.Max(x => x.Id) + 1;
                CriadorDeIds.IncializarIdPConsulta(maxId);
            }
        }
    }
}
