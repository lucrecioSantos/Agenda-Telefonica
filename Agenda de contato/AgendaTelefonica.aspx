<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgendaTelefonica.aspx.cs" Inherits="Agenda_de_contato.Views.AgendaTelefonica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Image ID="Image1" runat="server" Height="224px" ImageUrl="~/imagens/perfil.contato.jpg" Width="224px" />
            <br />
            Agenda de Contatos<br />
        <div>
            <asp:Image ID="Image3" runat="server" Height="60px" ImageUrl="~/imagens/login.png" Width="60px" />
             <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
             <br />
            <asp:Image ID="Image2" runat="server" Height="60px" ImageUrl="~/imagens/telefone.jpg" Width="60px" />
           
            
            <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
            <br />
            <asp:Image ID="Image4" runat="server" Height="60px" ImageUrl="~/imagens/email2.jpg" Width="60px" />
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
           
            
            <br />
            <asp:Button ID="bntCadastro" runat="server" Text="Cadastro" OnClick="bntCadastro_Click" />
        &nbsp;<asp:Button ID="bntAtualizar" runat="server" Text="Atualizar" OnClick="bntAtualizar_Click" />
&nbsp;<asp:Button ID="BntDExcluir" runat="server" OnClick="BntDExcluir_Click" Text="Excluir" />
&nbsp;<asp:Button ID="bntBuscar" runat="server" Text="Buscar" OnClick="bntBuscar_Click" />
        </div>
        <asp:Label ID="lblResultado" runat="server" Text="Label"></asp:Label>
        <div>


        </div>
    </form>
</body>
</html>
