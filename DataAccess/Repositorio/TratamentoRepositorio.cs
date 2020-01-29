using DataAccess.Contexto;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccess.Repositorio
{
    public static class TratamentoRepositorio
    {
        public static void AdicionarTratamento(Tratamento tratamento)
        {
            using (var db = new DataAccess.Contexto.Context())
            {
                using (DbContextTransaction tr = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Tratamento.Add(tratamento);
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

        public static List<Tratamento> ListarTodos()
        {
            using (var db = new Context())
            {
                return db.Tratamento.ToList();
            }
        }

        public static Tratamento RetornarTratamentoPorCodigo(int codigo)
        {
            using (var db = new Context())
            {
                return db.Tratamento.Find(codigo);
            }
        }
    }
}
