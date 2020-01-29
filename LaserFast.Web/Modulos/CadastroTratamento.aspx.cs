using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaserFast.Web.Modulos
{
    public partial class CadastroTratamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvarDadosTratamento_Click(object sender, EventArgs e)
        {
            Tratamento tratamento = new Tratamento();
            tratamento.Nome = txtCadastroNomeTratamento.Text;
            tratamento.Valor = decimal.Parse(txtCadastroValorTratamento.Text);
            DataAccess.Repositorio.TratamentoRepositorio.AdicionarTratamento(tratamento);
        }

    }
}