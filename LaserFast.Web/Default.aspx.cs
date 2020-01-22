﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess.Repositorio;

namespace LaserFast.Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grdClientes.DataSource = ClienteRepositorio.ListarTodos();
            grdClientes.DataBind();
        }
    }
}