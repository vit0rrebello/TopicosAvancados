<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Projweb1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        teste<p>
            <asp:TextBox ID="txtDescricao" runat="server" Height="64px" Width="143px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnSalvar" runat="server" Height="18px" OnClick="btnSalvar_Click" Text="SaRvar" Width="90px" />
        </p>
        <p>
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
