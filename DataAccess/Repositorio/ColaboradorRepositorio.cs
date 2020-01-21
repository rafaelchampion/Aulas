using System;
using System.Collections.Generic;
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
                db.Colaborador.Add(colaborador);
                db.SaveChanges();
            }
        }
    }
}
