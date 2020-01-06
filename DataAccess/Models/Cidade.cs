using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Cidade : Base
    {
        public string Nome { get; set; }
        public virtual IEnumerable<Pessoa> Pessoas { get; set; }
    }
}
