using DataAccess.Contexto;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositorio
{
    public static class ItemComandaRepositorio
    {
        public static List<ItemComanda> ListarItensComanda(int idcomanda)
        {
            using (var db = new Context())
            {
                return db.ItemComanda.Where(x => x.IdComanda == idcomanda).ToList();
            }
        }
        public static void AdicionarItemComanda(ItemComanda itemcomanda)
        {
            using (var db = new DataAccess.Contexto.Context())
            {
                db.ItemComanda.Add(itemcomanda);
                db.SaveChanges();
            }
        }
    }
}
