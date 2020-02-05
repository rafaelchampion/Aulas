<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tratamentos.aspx.cs" Inherits="LaserFast.Web.Modulos.Tratamentos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <br />
        <div class="row">
            <div class="col-md-12"><h3>Lista Tratamentos</h3></div>            
            <div class="col-md-12 col-sm-12">                
                <asp:GridView runat="server" ID="grdTratamentos" Width="100%" AutoGenerateColumns="false" CssClass="table table-striped table-bordered">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" />
                        <asp:BoundField DataField="Tratamento.Nome" HeaderText="Nome" />
                        <asp:BoundField DataField="Tratamento.Valor" HeaderText="Valor" />                        
                    </Columns>
                </asp:GridView>
                <dx:ASPxGridView runat="server" Width="100%" ID="grdClientes2">
                    <Columns>
                        <dx:GridViewDataTextColumn Caption="ID" FieldName="Id"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Tratamento.Nome" FieldName="Tratamento.Nome" CellStyle-Font-Bold="true"></dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn Caption="Tratamento.Valor" FieldName="Tratamento.Valor"></dx:GridViewDataTextColumn>                        
                    </Columns>
                </dx:ASPxGridView>
            </div>
        </div>
</asp:Content>
