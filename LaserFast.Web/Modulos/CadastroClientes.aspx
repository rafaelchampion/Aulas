<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroClientes.aspx.cs" Inherits="LaserFast.Web.Modulos.CadastroClientes" %>
<%@ Register Assembly="DevExpress.Web.v18.2 , Version=18.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-row">
        <br />

        <div class="formElementPessoa">
        <div class="col-md-4 col-sm-12">
            <label for="txtNomeCliente">Nome</label>
            <dx:ASPxTextBox runat="server" id="txtNomeCliente" Width="100%"></dx:ASPxTextBox>
        </div>
            </div>

        <div class="formElementPessoa">
        <div class="col-md-4 col-sm-12">
            <label for="txtEmailCliente">E-mail</label>
            <dx:ASPxTextBox runat="server" ID="txtEmailCliente" Width="100%" ></dx:ASPxTextBox>
        </div>
            </div>
        <div class="formElementPessoa">
        <div class="col-md-4 col-sm-12 ">
            <label for="txtTelefoneCliente">Telefone</label>
            <dx:ASPxTextBox runat="server" ID="txtTelefoneCliente" Width="100%" ></dx:ASPxTextBox>
        </div>
            </div>
        <div class="formElementPessoa">
        <div class="col-md-4 col-sm-12">
            <label for="txtCpfCliente">CPF</label>
            <dx:ASPxTextBox runat="server" ID="txtCpfCliente" Width="100%" ></dx:ASPxTextBox>
        </div>
            </div>
        <br />
        <div class="formElementPessoa">
        <div class="col-md-4 col-sm-12">
            <label for="txtLogradouroCliente">Logradouro</label>
            <dx:ASPxTextBox runat="server" ID="txtLogradouroCliente" Width="100%" ></dx:ASPxTextBox>
        </div>
            </div>
        <div class="formElementPessoa">
        <div class="col-md-4 col-sm-12">
            <label for="txtNumeroCliente">Numero</label>
            <dx:ASPxTextBox runat="server" ID="txtNumeroCliente" Width="100%" ></dx:ASPxTextBox>
        </div>
            </div>
        <br />
        <div class="formElementPessoa">
        <div class="col-md-4 col-sm-12">
            <label for="txtComplementoCliente">Complemento</label>
            <dx:ASPxTextBox runat="server" ID="txtComplementoCliente" Width="100%" ></dx:ASPxTextBox>
        </div>
            </div>
        <br />
        <div class="formElementPessoa">
        <div class="col-md-4 col-sm-12">
            <label for="txtBairroCliente">Bairro</label>
            <dx:ASPxTextBox runat="server" ID="txtBairroCliente" Width="100%" ></dx:ASPxTextBox>
        </div>
            </div>
        <div class="formElementPessoa">
        <div class="col-md-4 col-sm-12">
            <label for="txtDataNascimentoCliente">Data Nascimento</label>
            <dx:ASPxTextBox runat="server" ID="txtDataNascimentoCliente" Width="100%" ></dx:ASPxTextBox>
        </div>
            </div>
        <br />
            <div class="formElementPessoa">
        <div class="col-md-4 col-sm-12">
            <label for="txtCidadeCliente">Cidade</label>
            <dx:ASPxTextBox runat="server" ID="txtCidadeCliente" Width="100%" ></dx:ASPxTextBox>
        </div>
                </div>
    </div>
    <div class="row">
        <div class="col-md-12 col-sm-12">
            <br />
            <label class="col-md-12 control-label">
                <asp:Button CssClass="btn btn-primary" runat="server" ID="btnSalvarDadosCliente" Text="Salvar" OnClick="btnSalvarDadosCliente_Click" />
            </label>
        </div>
    </div>
</asp:Content>