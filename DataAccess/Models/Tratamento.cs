﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Tratamento : Base
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public virtual IEnumerable<ItemComanda> ItensComanda { get; set; }
        public void ListarDadosTratamentos()
        {
            Console.WriteLine(Id + ". " + "Tratamento: " + Nome);
            Console.WriteLine("Valor: " + Valor + "\n");
        }
    }
}
