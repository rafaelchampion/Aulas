﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositorio;
using DataAccess.Contexto;
using System.Data.Entity;

namespace DataAccess.Repositorio
{
    public static class ComandaRepositorio
    {
        public static void AdicionarComanda(Comanda comanda)
        {
            using (var db = new DataAccess.Contexto.Context())
            {
                db.Comanda.Add(comanda);
                db.SaveChanges();
            }
        }

        public static void AdicionarComanda(Comanda comanda, Context db)
        {
            db.Comanda.Add(comanda);
            db.SaveChanges();
        }

        public static Comanda RetornarComandaCodigo(int codigo)
        {
            using (var db = new Context())
            {
                return db.Comanda.Find(codigo);
            }
        }
        public static Comanda RetornarComandaCodigo(int codigo, Context db)
        {
            return db.Comanda.Include(x => x.ItemComanda).FirstOrDefault(x=>x.Id ==  codigo);
        }
    }
}
