using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LaserFast.Web.Modulos
{
    public partial class CadastroClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSalvarDadosCliente_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = txtNomeCliente.Text;
            pessoa.Email = txtEmailCliente.Text;
            pessoa.Telefone = txtTelefoneCliente.Text;
            pessoa.CPF = txtCpfCliente.Text;
            pessoa.Logradouro = txtLogradouroCliente.Text;
            pessoa.Numero =  int.Parse(txtNumeroCliente.Text);
            pessoa.Complemento = txtComplementoCliente.Text;
            pessoa.Bairro = txtBairroCliente.Text;
            pessoa.DataNascimento = DateTime.Parse(txtDataNascimentoCliente.Text);
            pessoa.Cidade = txtCidadeCliente.Text;
            Cliente cliente = new Cliente()
            {
                Pessoa = pessoa
            };
            DataAccess.Repositorio.ClienteRepositorio.AdicionarCliente(cliente);
        }
    }
}