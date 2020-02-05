<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroTratamento.aspx.cs" Inherits="LaserFast.Web.Modulos.CadastroTratamento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-12">
        <h3 style="text-align: center">Cadastro Tratamentos</h3>
    </div>

    <div class="row">
        <div class="formElement">
            <div class="col-md-12">
                <label>Categoria</label>
                <dx:ASPxComboBox ID="dropdownCategoriaTratamento" runat="server" DropDownStyle="DropDownList" Width="100%">
                    <Items>
                        <dx:ListEditItem Value="Feminino" />
                        <dx:ListEditItem Value="Masculino" />
                        <dx:ListEditItem Value="Avaliação" />
                        <dx:ListEditItem Value="Cortesia" />
                        <dx:ListEditItem Value="Promocional" />
                    </Items>
                </dx:ASPxComboBox>
            </div>
        </div>

        <div class="formElement">
            <div class="col-md-12 ">
                <label>Tratamento</label>
                <dx:ASPxTextBox ID="txtCadastroNomeTratamento" runat="server" Width="100%" ></dx:ASPxTextBox>
            </div>
        </div>
        <div class="formElement">
            <div class="col-md-12 ">
                <label>Valor</label>
                <dx:ASPxTextBox ID="txtCadastroValorTratamento" runat="server" Width="100%"></dx:ASPxTextBox>
            </div>
        </div>
    </div>

    <br />
    <div class="row">
        <div class="col-md-12 col-sm-12">
            <br />
            <label class="col-md-12 col-sm-12">
                <asp:Button CssClass="btn btn-primary" runat="server" ID="btnSalvarDadosTratamento" Text="Salvar" OnClick="btnSalvarDadosTratamento_Click" />

                <%--<button type="button" class="btn btn-primary btn-block" OnClick="btnSalvarDadosTratamento_Click" id="btnSalvarDadosTratamento">Block level button</button>--%>
            </label>
        </div>
    </div>

</asp:Content>
