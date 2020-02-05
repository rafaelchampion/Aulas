﻿using DataAccess.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaserFast.Web.Modulos
{
    public partial class Tratamentos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grdTratamentos.DataSource = TratamentoRepositorio.ListarTodos();
            grdTratamentos.DataBind();
        }
    }
}