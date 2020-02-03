<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroTratamento.aspx.cs" Inherits="LaserFast.Web.Modulos.CadastroTratamento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="col-md-12">
        <h3 style="text-align: center">Cadastro Tratamentos</h3>
    </div>

    <div class="row">
    <div class="formElement">        
        <div class="col-md-12">
            <label>Área       </label>
            <asp:DropDownList runat="server" ID="areaTratamento" Width="100%" CssClass="btn btn-secondary dropdown-toggle">
                <asp:ListItem Text="Item 1" Value="1" />
                <asp:ListItem Text="Item 5" Value="5" />
                <asp:ListItem Text="Item 3" Value="3" />
                <asp:ListItem Text="Item 4" Value="4" />
                <asp:ListItem Text="Item 2" Value="2" />
            </asp:DropDownList>
        </div>
    </div>


    <div class="formElement">
        <div class="col-md-12 ">
            <label>Tratamento</label>
            <asp:TextBox runat="server" ID="txtCadastroNomeTratamento" Width="100%" CssClass="form-control"></asp:TextBox>
        </div>
    </div>

    <div class="formElement">
        <div class="col-md-12 ">
            <label>Valor       </label>
            <asp:TextBox runat="server" ID="txtCadastroValorTratamento" Width="100%" CssClass="form-control"></asp:TextBox>
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
