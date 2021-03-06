﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="LaserFast.Web.Modulos.Clientes" %>
<%@ Register Assembly="DevExpress.Web.v18.2 , Version=18.2.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
        <div class="row">
            <div class="col-md-12"><h3>Lista Clientes</h3></div>            
            <div class="col-md-12 col-sm-12">                
                <dx:ASPxGridView runat="server" Width="100%" ID="grdClientes2">
                    <Columns>
                        <dx:GridViewDataTextColumn Caption="Código" FieldName="Id"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Nome" FieldName="Pessoa.Nome"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="E-mail" FieldName="Pessoa.Email"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Telefone" FieldName="Pessoa.Telefone"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="CPF" FieldName="Pessoa.CPF"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Logradouro" FieldName="Pessoa.Logradouro"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Numero" FieldName="Pessoa.Numero"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Bairro" FieldName="Pessoa.Bairro"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataDateColumn Caption="Data de Nascimento" FieldName="Pessoa.DataNascimento"></dx:GridViewDataDateColumn>
                        <dx:GridViewDataTextColumn Caption="Cidade" FieldName="Pessoa.Cidade"></dx:GridViewDataTextColumn>
                    </Columns>
                </dx:ASPxGridView>
            </div>
        </div>
</asp:Content>