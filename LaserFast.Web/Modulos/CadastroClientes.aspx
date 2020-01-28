<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroClientes.aspx.cs" Inherits="LaserFast.Web.Modulos.CadastroClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-row">
        <br />

        <div class="col-md-4 col-sm-12">
            <label for="txtNomeCliente">Nome</label>
            <asp:TextBox runat="server" ID="txtNomeCliente" Width="100%" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-4 col-sm-12">
            <label for="txtEmailCliente">E-mail</label>
            <asp:TextBox runat="server" ID="txtEmailCliente" Width="100%" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-4 col-sm-12 ">
            <label for="txtTelefoneCliente">Telefone</label>
            <asp:TextBox runat="server" ID="txtTelefoneCliente" Width="100%" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-4 col-sm-12">
            <label for="txtCpfCliente">CPF</label>
            <asp:TextBox runat="server" ID="txtCpfCliente" Width="100%" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div class="col-md-4 col-sm-12">
            <label for="txtLogradouroCliente">Logradouro</label>
            <asp:TextBox runat="server" ID="txtLogradouroCliente" Width="100%" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-4 col-sm-12">
            <label for="txtNumeroCliente">Numero</label>
            <asp:TextBox runat="server" ID="txtNumeroCliente" Width="100%" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div class="col-md-4 col-sm-12">
            <label for="txtComplementoCliente">Complemento</label>
            <asp:TextBox runat="server" ID="txtComplementoCliente" Width="100%" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div class="col-md-4 col-sm-12">
            <label for="txtBairroCliente">Bairro</label>
            <asp:TextBox runat="server" ID="txtBairroCliente" Width="100%" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-4 col-sm-12">
            <label for="txtDataNascimentoCliente">Data Nascimento</label>
            <asp:TextBox runat="server" ID="txtDataNascimentoCliente" Width="100%" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div class="col-md-4 col-sm-12">
            <label for="txtCidadeCliente">Cidade</label>
            <asp:TextBox runat="server" ID="txtCidadeCliente" Width="100%" CssClass="form-control"></asp:TextBox>
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


<%-- https://codepen.io/jaycbrf/pen/iBszr --%>