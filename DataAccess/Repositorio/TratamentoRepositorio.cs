using DataAccess.Contexto;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositorio
{
    public static class TratamentoRepositorio
    {
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
