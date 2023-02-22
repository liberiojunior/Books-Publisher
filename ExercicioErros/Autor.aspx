<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Autor.aspx.cs" Inherits="ExercicioErros.frmAutor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="assets/css/main.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="ID do Autor:"></asp:Label>
            <asp:TextBox ID="txtIdAutor" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Nome:"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server" Required Width="326px"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Required Text="Idade:"></asp:Label>
            <asp:TextBox ID="txtIdade" runat="server" CssClass="sr-only-focusable" MaxLength="3">0</asp:TextBox>
            <br />
            <br />
            <asp:GridView ID="gridAutor" runat="server" OnSelectedIndexChanged="gridAutor_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ButtonType="Button" SelectText="Editar" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:Button ID="btnGravar" runat="server" OnClick="btnGravar_Click" Text="Gravar" />
            &nbsp;<asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClick="btnExcluir_Click" />
            &nbsp;<asp:Button ID="btnLimpar" runat="server" OnClick="btnLimpar_Click" Text="Limpar" />

        </div>
    </form>
    <!-- Scripts -->
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/js/jquery.scrollex.min.js"></script>
    <script src="assets/js/jquery.scrolly.min.js"></script>
    <script src="assets/js/skel.min.js"></script>
    <script src="assets/js/util.js"></script>
    <!--[if lte IE 8]><script src="assets/js/ie/respond.min.js"></script><![endif]-->
    <script src="assets/js/main.js"></script>
</body>
</html>
