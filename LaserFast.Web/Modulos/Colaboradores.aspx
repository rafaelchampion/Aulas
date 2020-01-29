<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Colaboradores.aspx.cs" Inherits="LaserFast.Web.Modulos.Colaboradores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="row">
        <div class="col-md-12"><h3>Lista Colaboradores</h3></div>
        <div class="col-md-12 col-sm-12">
            <asp:GridView runat="server" ID="grdColaboradores" Width="100%" AutoGenerateColumns="false" CssClass="table table-striped table-bordered">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" />
                    <asp:BoundField DataField="Pessoa.Nome" HeaderText="Nome" />
                    <asp:BoundField DataField="Pessoa.Email" HeaderText="E-mail" />
                    <asp:BoundField DataField="Pessoa.Telefone" HeaderText="Telefone" />
                    <asp:BoundField DataField="Pessoa.Cpf" HeaderText="CPF" />
                    <asp:BoundField DataField="Pessoa.Logradouro" HeaderText="Logradouro" />
                    <asp:BoundField DataField="Pessoa.Numero" HeaderText="Numero" />
                    <asp:BoundField DataField="Pessoa.Complemento" HeaderText="Complemento" />
                    <asp:BoundField DataField="Pessoa.Bairro" HeaderText="Bairro" />
                    <asp:BoundField DataField="Pessoa.DataNascimento" HeaderText="Data de nascimento" DataFormatString="{0:d}"/>
                    <asp:BoundField DataField="Pessoa.Cidade" HeaderText="Cidade" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
