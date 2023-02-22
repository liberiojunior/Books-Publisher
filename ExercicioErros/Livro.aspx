<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Livro.aspx.cs" Inherits="ExercicioErros.Livro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="assets/css/main.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="ID do Livro:"></asp:Label>
            <asp:TextBox ID="txtIdLivro" runat="server" Enabled="False"></asp:TextBox>
            <asp:Label ID="lblAutor" runat="server" Text="Autor:"></asp:Label>
            <asp:DropDownList ID="drpAutor" style="color:black" runat="server">
            </asp:DropDownList>
            <asp:Label ID="lblEditora" runat="server" Text="Editora:"></asp:Label>
            <asp:DropDownList ID="drpEditora" style="color:black" runat="server">
            </asp:DropDownList>
            <asp:Label ID="lblTitulo" runat="server" Text="Título do Livro:"></asp:Label>
            <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
            <asp:Label ID="lblDtCadastro" runat="server" Text="Data do cadastro:"></asp:Label>
            <br />
            <asp:TextBox ID="txtDtCadastro" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblNumPaginas" runat="server" Text="Número de Páginas:"></asp:Label>
            <br />
            <asp:TextBox ID="txtNumPaginas" Text="0" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblValor" runat="server" Text="Valor do Livro:"></asp:Label>
            <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
            <asp:GridView ID="gridLivro" runat="server" OnSelectedIndexChanged="gridLivro_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ButtonType="Button" SelectText="Editar" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:Button ID="btnGravar" runat="server" OnClick="btnGravar_Click" Text="Gravar" />
            &nbsp;<asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClick="btnExcluir_Click" />
            &nbsp;<asp:Button ID="btnLimpar" runat="server" OnClick="btnLimpar_Click" Text="Limpar" />
        </div>

    </form>
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/js/jquery.scrollex.min.js"></script>
    <script src="assets/js/jquery.scrolly.min.js"></script>
    <script src="assets/js/main.js"></script>
    <script src="assets/js/skel.min.js"></script>
    <script src="assets/js/util.js"></script>
</body>
</html>
