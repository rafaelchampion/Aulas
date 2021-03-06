﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.Repositorio
{
    public static class ClienteRepositorio
    {
        public static void AdicionarCliente(Cliente cliente)
        {
            using (var db = new DataAccess.Contexto.Context())
            {
                using (DbContextTransaction tr = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Cliente.Add(cliente);
                        db.SaveChanges();
                        tr.Commit();
                    }
                    catch (Exception ex)
                    {
                        tr.Rollback();                        
                        throw new Exception(ex.Message);
                    }
                }
            }
        }

        public static List<Cliente> ListarTodos()
        {
            using (var db = new Contexto.Context())
            {
                return db.Cliente.Include(x => x.Pessoa).ToList();
            }
        }
    }
}