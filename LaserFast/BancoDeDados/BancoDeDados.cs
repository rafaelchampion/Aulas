using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaserFast.Entidades;

namespace LaserFast.BancoDeDados
{
   public static class BancoDeDados
    {
        public static List<Cliente> ListaClientes { get; set; }
        public static List<Colaborador> ListaColaboradores { get; set; }
        public static List<Comanda> ListarComandas { get; set; }

        static BancoDeDados()
        {
            ListaClientes = new List<Cliente>();
            ListaColaboradores = new List<Colaborador>();
            ListarComandas = new List<Comanda>();
        }

        public static void AddCliente (Cliente cliente)
        {
            ListaClientes.Add(cliente);
        }
        public static void AddColaborador(Colaborador colaborador)
        {
            ListaColaboradores.Add(colaborador);
        }
        public static void AddComanda(Comanda comanda)
        {
            ListarComandas.Add(comanda);
        }
    }
}