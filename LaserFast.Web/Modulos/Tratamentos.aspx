<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tratamentos.aspx.cs" Inherits="LaserFast.Web.Modulos.Tratamentos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div class="row">
        <div class="col-md-12" style="text-align: center">
            <h3>Lista Tratamentos</h3>
        </div>
        <div align="center">
            <div class="col-md-12 col-sm-12">
                <dx:ASPxGridView runat="server" Width="75%" ID="grdTratamentos">
                    <Columns>
                        <dx:GridViewDataTextColumn Caption="Código" FieldName="Id"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Nome" FieldName="Nome"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="E-mail" FieldName="Valor"></dx:GridViewDataTextColumn>
                    </Columns>
                </dx:ASPxGridView>
            </div>
        </div>
    </div>
</asp:Content>
