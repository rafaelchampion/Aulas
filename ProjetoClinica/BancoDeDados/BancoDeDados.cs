using ProjetoClinica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClinica.BancoDeDados
{
    public static class BancoDeDados
    {
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
         }

        public static void AddProfissional(Profissional profissional)
        {
            ListaProfissionais.Add(profissional);
        }

        public static void AddConsulta(Consulta consulta)
        {
            ListaConsultas.Add(consulta);
        }
    }

}
