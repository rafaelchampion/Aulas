using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexto
{
    internal static class DadosConexao
    {
        public const string Servidor = "estudosolano.mysql.dbaas.com.br";
        public const string NomeBanco = "estudosolano";
        public const string Usuario = "estudosolano";
        public const string Senha = "BUrW68Zd";
        public static string RetornarStringConexao()
        {
            return $"server={Servidor};user id={Usuario};password={Senha};database={NomeBanco};persistsecurityinfo=True; convert zero datetime = True";
        }
    }
}