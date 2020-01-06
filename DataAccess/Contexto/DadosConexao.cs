using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexto
{
    internal static class DadosConexao
    {
        public static string Servidor;
        public static string NomeBanco;
        public static string Usuario;
        public static string Senha;
        public static string RetornarStringConexao()
        {
            return $"server={Servidor};user id={Usuario};password={Senha};database={NomeBanco};persistsecurityinfo=True";
        }
    }
}
