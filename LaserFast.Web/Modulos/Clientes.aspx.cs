﻿using DataAccess.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaserFast.Web.Modulos
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grdClientes2.DataSource = ClienteRepositorio.ListarTodos();
            grdClientes2.DataBind();
        }
    }
}