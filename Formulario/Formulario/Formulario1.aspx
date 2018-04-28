<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario1.aspx.cs" Inherits="Formulario.Formulario1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Formulario</h1>

            <p>Nome: <asp:TextBox ID="txtNome" runat="server"></asp:TextBox></p>
            <p>RG: <asp:TextBox ID="TextRg" runat="server"></asp:TextBox></p>
            <p>CPF: <asp:TextBox ID="TextCpf" runat="server"></asp:TextBox></p>
            <p>Linguagem Preferida: <asp:TextBox ID="TextLinguagem" runat="server"></asp:TextBox></p>
            <p>Adjetivo dessa linguagem: <asp:TextBox ID="TextAdj" runat="server"></asp:TextBox></p>
            <p>Cidade: <asp:TextBox ID="TextCidade" runat="server"></asp:TextBox></p>
            <p>Dia: <asp:TextBox ID="TextDia" runat="server"></asp:TextBox></p>
            <p>Ano: <asp:TextBox ID="TextAno" runat="server"></asp:TextBox></p>
            <p>Maior ou menor de idade: <asp:TextBox ID="TextIdade" runat="server"></asp:TextBox></p>

        </div>
        <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Printar" />
        <br />
        <br />
        Eu,
        <asp:Label ID="lblNome" runat="server" Text="Label"></asp:Label>
&nbsp;portador do RG:
        <asp:Label ID="lblRg" runat="server"></asp:Label>
        , CPF:
        <asp:Label ID="lblCpf" runat="server"></asp:Label>
        .<br />
        Adoro estudar
        <asp:Label ID="lblLinguagem" runat="server"></asp:Label>
&nbsp;porque é uma linguagem
        <asp:Label ID="lblAdj" runat="server"></asp:Label>
        .<br />
        <br />
        <asp:Label ID="lblCidade" runat="server"></asp:Label>
        ,
        <asp:Label ID="lblDia" runat="server"></asp:Label>
&nbsp;de
        <asp:Label ID="lblAno" runat="server"></asp:Label>
        .<br />
        <br />
        *Declaro ser
        <asp:Label ID="lblIdade" runat="server"></asp:Label>
&nbsp;de idade.<p>
            <asp:Button ID="btnImprimir" runat="server" OnClick="btnImprimir_Click" Text="Imprimir" />
            <asp:Button ID="btnListar" runat="server" Text="Listar" Width="64px" />
        </p>
    </form>
</body>
</html>
