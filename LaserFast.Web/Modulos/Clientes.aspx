<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="LaserFast.Web.Modulos.Clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
        <div class="row">
            <div class="col-md-12"><h3>Lista Clientes</h3></div>            
            <div class="col-md-12 col-sm-12">                
                <asp:GridView runat="server" ID="grdClientes" Width="100%" AutoGenerateColumns="false" CssClass="table table-striped table-bordered">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" />
                        <asp:BoundField DataField="Pessoa.Nome" HeaderText="Nome" />
                        <asp:BoundField DataField="Pessoa.Email" HeaderText="E-mail" />
                        <asp:BoundField DataField="Pessoa.Telefone" HeaderText="Telefone" />
                        <asp:BoundField DataField="Pessoa.CPF" HeaderText="CPF" />
                        <asp:BoundField DataField="Pessoa.Logradouro" HeaderText="Logradouro" />
                        <asp:BoundField DataField="Pessoa.Numero" HeaderText="Número" />
                        <asp:BoundField DataField="Pessoa.Complemento" HeaderText="Complemento" />
                        <asp:BoundField DataField="Pessoa.Bairro" HeaderText="Bairro" />
                        <asp:BoundField DataField="Pessoa.DataNascimento" HeaderText="Data de Nascimento" DataFormatString="{0:d}" />
                        <asp:BoundField DataField="Pessoa.Cidade" HeaderText="Cidade" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
</asp:Content>