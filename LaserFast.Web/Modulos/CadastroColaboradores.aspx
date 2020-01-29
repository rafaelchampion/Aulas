<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroColaboradores.aspx.cs" Inherits="LaserFast.Web.Modulos.CadastroColaboradores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-row">
        <br />
        <div class="formElementPessoa">
        <div class="col-md-4 col-sm-12">
            <label for="txtNomeColaborador">Nome</label>
            <asp:TextBox runat="server" ID="txtNomeColaborador" Width="100%" CssClass="form-control"></asp:TextBox>
        </div>
            </div>
        <div class="formElementPessoa">
        <div class="col-md-4 col-sm-12">
            <label for="txtNomeColaborador">E-mail</label>
            <asp:TextBox runat="server" ID="txtEmailColaborador" Width="100%" CssClass="form-control"></asp:TextBox>
        </div>
            </div>
        <div class="formElementPessoa">
        <div class="col-md-4 col-sm-12">
            <label for="txtNomeColaborador">Telefone</label>
            <asp:TextBox runat="server" ID="txtTelefoneColaborador" Width="100%" CssClass="form-control"></asp:TextBox>
        </div>
            </div>
        <div class="formElementPessoa">
        <div class="col-md-4 col-sm-12">
            <label for="txtNomeColaborador">CPF</label>
            <asp:TextBox runat="server" ID="txtCpfColaborador" Width="100%" CssClass="form-control"></asp:TextBox>
        </div>
            </div>
        <br />
        <div class="formElementPessoa">
        <div class="col-md-4 col-sm-12">
            <label for="txtNomeColaborador">Logradouro</label>
            <asp:TextBox runat="server" ID="txtLogradouroColaborador" Width="100%" CssClass="form-control"></asp:TextBox>
        </div>
            </div>
        <div class="formElementPessoa">
        <div class="col-md-4 col-sm-12">
            <label for="txtNomeColaborador">Numero</label>
            <asp:TextBox runat="server" ID="txtNumeroColaborador" Width="100%" CssClass="form-control"></asp:TextBox>
        </div>
            </div>
        <div class="formElementPessoa">
        <div class="col-md-4 col-sm-12">
            <label for="txtNomeColaborador">Complemento</label>
            <asp:TextBox runat="server" ID="txtComplementoColaborador" Width="100%" CssClass="form-control"></asp:TextBox>
        </div>
            </div>
        <br />
        <div class="formElementPessoa">
        <div class="col-md-4 col-sm-12">
            <label for="txtNomeColaborador">Bairro</label>
            <asp:TextBox runat="server" ID="txtBairroColaborador" Width="100%" CssClass="form-control"></asp:TextBox>
        </div>
            </div>
        <div class="formElementPessoa">
        <div class="col-md-4 col-sm-12">
            <label for="txtNomeColaborador">Data Nascimento</label>
            <asp:TextBox runat="server" ID="txtDataNascimentoColaborador" Width="100%" CssClass="form-control"></asp:TextBox>
        </div>
            </div>
        <div class="formElementPessoa">
        <div class="col-md-4 col-sm-12">
            <label for="txtNomeColaborador">Cidade</label>
            <asp:TextBox runat="server" ID="txtCidadeColaborador" Width="100%" CssClass="form-control"></asp:TextBox>
        </div>
            </div>
    </div>
    <div class="row">
        <div class="col-md-12 col-sm-12">
            <br />
            <label class="col-md-12 control-label">
                <asp:Button CssClass="btn btn-primary" runat="server" ID="btnSalvarDadosColaborador" Text="Salvar" OnClick="btnSalvarDadosColaborador_Click" />
            </label>
        </div>        
    </div>
</asp:Content>
