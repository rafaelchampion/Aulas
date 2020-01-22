<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LaserFast.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView runat="server" ID="grdClientes" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id"></asp:BoundField>
            <asp:BoundField DataField="Pessoa.Nome" HeaderText="Nome"></asp:BoundField>
            <asp:BoundField DataField="Pessoa.DataNascimento" HeaderText="Data de nascimento" DataFormatString="{0:d}"></asp:BoundField>
            <asp:BoundField DataField="Pessoa.CPF" HeaderText="CPF"></asp:BoundField>
            <asp:BoundField DataField="Pessoa.Cidade" HeaderText="Cidade"></asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>
