using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Comanda : Base
    {
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        [ForeignKey("Colaborador")]
        public int IdColaborador { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Colaborador Colaborador { get; set; }
        public virtual IEnumerable<ItemComanda> ItensComanda { get; set; }
    }
}
