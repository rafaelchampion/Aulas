using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataAccess.Contexto
{
    public class Context : DbContext
    {
        public Context() : base(DadosConexao.RetornarStringConexao())
        {
            /* For those who are seeing this exception: 
             * "The model backing the 'Production' context has changed since the database was created. 
            * Either manually delete/update the database, or call Database.SetInitializer with an IDatabaseInitializer instance." 
            * Here is what is going on and what to do about it: When a model is first created,
            * we run a DatabaseInitializer to do things like create the database if it's not there or add seed data. 
            * The default DatabaseInitializer tries to compare the database schema needed to use the model with a hash of the schema stored in an EdmMetadata table 
            * that is created with a database (when Code First is the one creating the database). 
            * Existing databases won’t have the EdmMetadata table and so won’t have the hash…and the implementation today will throw if that table is missing. 
            * We'll work on changing this behavior before we ship the fial version since it is the default. 
            * Until then, existing databases do not generally need any database initializer so it can be turned off for your context type by calling: */
            Database.SetInitializer<Context>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public virtual DbSet<Cliente> Cliente { get; set; }

        public virtual DbSet<Colaborador> Colaborador { get; set; }

        public virtual DbSet<Comanda> Comanda { get; set; }

        public virtual DbSet<ItemComanda> ItemComanda { get; set; }

        public virtual DbSet<Pessoa> Pessoa { get; set; }

        public virtual DbSet<Tratamento> Tratamento { get; set; }



        public static bool VerificarExistenciaCliente(int id)
        {
            using (var db = new Context())
            {
                var list = db.Cliente.ToList();
                bool existe = list.FirstOrDefault(x => x.Id == id) != null;
                return existe;
            }
        }
        public static bool VerificarExistenciaColaborador(int id)
        {
            using (var db = new Context())
            {
                var list = db.Colaborador.ToList();
                bool existe = list.FirstOrDefault(x => x.Id == id) != null;
                return existe;
            }
        }        
    }
}