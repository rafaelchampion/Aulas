using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class ItemComanda : Base
    {
        [ForeignKey("Comanda")]
        public int IdComanda { get; set; }
        [ForeignKey("Tratamento")]
        public int IdTratamento { get; set; }

        public virtual Comanda Comanda { get; set; }
        public virtual Tratamento Tratamento { get; set; }
    }
}
