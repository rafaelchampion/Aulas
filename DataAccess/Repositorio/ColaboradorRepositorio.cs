using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.Repositorio
{
    public class ColaboradorRepositorio
    {
        public static void AdicionarColaborador(Colaborador colaborador)
        {
            using (var db = new DataAccess.Contexto.Context())
            {
                using (DbContextTransaction tr = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Colaborador.Add(colaborador);
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
        public static List<Colaborador> ListarTodos()
        {
            using (var db = new Contexto.Context())
            {
                return db.Colaborador.Include(x => x.Pessoa).ToList();
            }
        }
    }
}
