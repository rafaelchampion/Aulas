<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="LaserFast.Web.Modulos.Clientes" %>
<%@ Register Assembly="DevExpress.Web.v18.2 , Version=18.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

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
                <dx:ASPxGridView runat="server" Width="100%" ID="grdClientes2">
                    <Columns>
                        <dx:GridViewDataTextColumn Caption="ID" FieldName="Id"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Pessoa.Nome" FieldName="Pessoa.Nome" CellStyle-Font-Bold="true"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Pessoa.Email" FieldName="Pessoa.Email"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Pessoa.Telefone" FieldName="Pessoa.Telefone"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Pessoa.CPF" FieldName="Pessoa.CPF"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Pessoa.Logradouro" FieldName="Pessoa.Logradouro"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Pessoa.Numero" FieldName="Pessoa.Numero"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Pessoa.Bairro" FieldName="Pessoa.Bairro"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataDateColumn Caption="Pessoa.DataNascimento" FieldName="Pessoa.DataNascimento"></dx:GridViewDataDateColumn>
                        <dx:GridViewDataTextColumn Caption="Pessoa.Cidade" FieldName="Pessoa.Cidade"></dx:GridViewDataTextColumn>
                    </Columns>
                </dx:ASPxGridView>
            </div>
        </div>
</asp:Content>