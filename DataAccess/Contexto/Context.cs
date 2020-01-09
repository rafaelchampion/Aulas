﻿using DataAccess.Models;
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
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public virtual DbSet<Cidade> Cidade { get; set; }

        public virtual DbSet<Cliente> Cliente { get; set; }

        public virtual DbSet<Colaborador> Colaborador { get; set; }

        public virtual DbSet<Comanda> Comanda { get; set; }

        public virtual DbSet<ItemComanda> ItemComanda { get; set; }

        public virtual DbSet<Pessoa> Pessoa { get; set; }

        public virtual DbSet<Tratamento> Tratamento { get; set; }
    }
}
