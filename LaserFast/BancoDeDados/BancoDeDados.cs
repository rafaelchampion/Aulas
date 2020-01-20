using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using LaserFast.Entidades;
using Newtonsoft.Json;
using LaserFast.Helpers;
using DataAccess.Contexto;
using System.Data.Entity;

namespace LaserFast.BancoDeDados
{
    public static class BancoDeDados
    {
        private const string DriveArquivoJson = "C:\\";
        private const string CaminhoArquivoJson = "\\Users\\SOLANOG\\Documents\\BancoDeDados\\";
        public static List<Cliente> ListaClientes { get; set; }
        public static List<Colaborador> ListaColaboradores { get; set; }
        public static List<Comanda> ListaComandas { get; set; }
        public static List<Tratamento> ListaTratamentos { get; set; }

        static BancoDeDados()
        {
            ListaClientes = new List<Cliente>();
            ListaColaboradores = new List<Colaborador>();
            ListaComandas = new List<Comanda>();
            ListaTratamentos = new List<Tratamento>();

        }
        public static void AddCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
            SalvarArquivoJson(TipoBancoDeDados.Cliente);
        }
        public static void AddColaborador(Colaborador colaborador)
        {
            ListaColaboradores.Add(colaborador);
            SalvarArquivoJson(TipoBancoDeDados.Colaborador);
        }
        public static void AddComanda(Comanda comanda)
        {
            ListaComandas.Add(comanda);
            SalvarArquivoJson(TipoBancoDeDados.Comanda);
        }
        public static void AddTratamento(Tratamento tratamento)
        {
            ListaTratamentos.Add(tratamento);
            SalvarArquivoJson(TipoBancoDeDados.Tratamento);
        }


        //public static bool VerificarExistenciaCliente(int id)
        //{
        //    using (var db = new Context())
        //    {
        //        var list = db.Cliente.ToList();
        //        bool existe = list.FirstOrDefault(x => x.Id == id) != null;
        //        return existe;
        //    }
        //}
        //public static bool VerificarExistenciaColaborador(int id)
        //{
        //    bool existe = ListaColaboradores.FirstOrDefault(x => x.Id == id) != null;
        //    return existe;
        //}





        private static void SalvarArquivoJson(TipoBancoDeDados tipo)
        {
            switch (tipo)
            {
                case TipoBancoDeDados.Cliente:
                    StreamWriter escritorClientes = new StreamWriter($"{DriveArquivoJson}{CaminhoArquivoJson}ListaClientes.json");
                    string jsonClientes = JsonConvert.SerializeObject(ListaClientes);
                    escritorClientes.WriteLine(jsonClientes);
                    escritorClientes.Dispose();
                    break;
                case TipoBancoDeDados.Colaborador:
                    StreamWriter escritorColaboradores = new StreamWriter($"{DriveArquivoJson}{CaminhoArquivoJson}ListaColaboradores.json");
                    string jsonColaboradores = JsonConvert.SerializeObject(ListaColaboradores);
                    escritorColaboradores.WriteLine(jsonColaboradores);
                    escritorColaboradores.Dispose();
                    break;
                case TipoBancoDeDados.Comanda:
                    StreamWriter escritorComandas = new StreamWriter($"{DriveArquivoJson}{CaminhoArquivoJson}ListaComandas.json");
                    string jsonComandas = JsonConvert.SerializeObject(ListaComandas);
                    escritorComandas.WriteLine(jsonComandas);
                    escritorComandas.Dispose();
                    break;
                case TipoBancoDeDados.Tratamento:
                    StreamWriter escritorTratamentos = new StreamWriter($"{DriveArquivoJson}{CaminhoArquivoJson}ListaTratamentos.json");
                    string jsonTratamentos = JsonConvert.SerializeObject(ListaTratamentos);
                    escritorTratamentos.WriteLine(jsonTratamentos);
                    escritorTratamentos.Dispose();
                    break;
            }
        }
        public static void CarregarArquivosJson()
        {
            if (File.Exists($"{DriveArquivoJson}{CaminhoArquivoJson}ListaClientes.json"))
            {
                StreamReader leitorArquivoClientes = new StreamReader($"{DriveArquivoJson}{CaminhoArquivoJson}ListaClientes.json");
                string clientes = leitorArquivoClientes.ReadToEnd();
                leitorArquivoClientes.Dispose();
                ListaClientes = JsonConvert.DeserializeObject<List<Cliente>>(clientes);
                int maxId = ListaClientes.Max(x => x.Id) + 1;
                CriadorIds.InicializarClienteId(maxId);
            }
            if (File.Exists($"{DriveArquivoJson}{CaminhoArquivoJson}ListaColaboradores.json"))
            {
                StreamReader leitordeArquivoColaboradores = new StreamReader($"{DriveArquivoJson}{CaminhoArquivoJson}ListaColaboradores.json");
                string colaboradores = leitordeArquivoColaboradores.ReadToEnd();
                leitordeArquivoColaboradores.Dispose();
                ListaColaboradores = JsonConvert.DeserializeObject<List<Colaborador>>(colaboradores);
                int maxId = ListaColaboradores.Max(x => x.Id) + 1;
                CriadorIds.InicializarColaboradorId(maxId);
            }
            if (File.Exists($"{DriveArquivoJson}{CaminhoArquivoJson}ListaComandas.json"))
            {
                StreamReader leitordeArquivoComandas = new StreamReader($"{DriveArquivoJson}{CaminhoArquivoJson}ListaComandas.json");
                string comandas = leitordeArquivoComandas.ReadToEnd();
                leitordeArquivoComandas.Dispose();
                ListaComandas = JsonConvert.DeserializeObject<List<Comanda>>(comandas);
                int maxId = ListaComandas.Max(x => x.Id) + 1;
                CriadorIds.InicializarComandaId(maxId);
            }
            if (File.Exists($"{DriveArquivoJson}{CaminhoArquivoJson}ListaTratamentos.json"))
            {
                StreamReader leitordeArquivoTratamentos = new StreamReader($"{DriveArquivoJson}{CaminhoArquivoJson}ListaTratamentos.json");
                string tratamentos = leitordeArquivoTratamentos.ReadToEnd();
                leitordeArquivoTratamentos.Dispose();
                ListaTratamentos = JsonConvert.DeserializeObject<List<Tratamento>>(tratamentos);
                int maxId = ListaTratamentos.Max(x => x.Id) + 1;
                CriadorIds.InicializarTratamentoId(maxId);
            }
        }
    }
}