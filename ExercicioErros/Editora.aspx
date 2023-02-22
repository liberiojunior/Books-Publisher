<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editora.aspx.cs" Inherits="ExercicioErros.Editora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="assets/css/main.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:GridView ID="gridEditora" runat="server" >
            </asp:GridView>
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
