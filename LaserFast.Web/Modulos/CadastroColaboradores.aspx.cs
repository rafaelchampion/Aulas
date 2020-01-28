using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaserFast.Web.Modulos
{
    public partial class CadastroColaboradores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSalvarDadosColaborador_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = txtNomeColaborador.Text;
            pessoa.Email = txtEmailColaborador.Text;
            pessoa.Telefone = txtTelefoneColaborador.Text;
            pessoa.CPF = txtCpfColaborador.Text;
            pessoa.Logradouro = txtLogradouroColaborador.Text;
            pessoa.Numero = int.Parse(txtNumeroColaborador.Text);
            pessoa.Complemento = txtComplementoColaborador.Text;
            pessoa.Bairro = txtBairroColaborador.Text;
            pessoa.DataNascimento = DateTime.Parse(txtDataNascimentoColaborador.Text);
            pessoa.Cidade = txtCidadeColaborador.Text;
            Colaborador colaborador = new Colaborador()
            {
                Pessoa = pessoa
            };
            DataAccess.Repositorio.ColaboradorRepositorio.AdicionarColaborador(colaborador);
        }
    }
}