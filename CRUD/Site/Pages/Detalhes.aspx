<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Pages.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Detalhes</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
</head>
    <script src="../Scripts/bootstrap.js"></script>
    <script src="../Scripts/jquery-1.9.0.min.js"></script>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="span10 offset1">
            <div class="well">Detalhes do Cliente</div>
            <br />
  
                ID do Cliente:<asp:TextBox id="txtCodigo" runat="server" CssClass="form-control" Width="5%"></asp:TextBox>
                <br />
                <asp:Button ID="btnPesquisa" runat="server" Text="Pesquisar" CssClass="btn btn-primary" OnClick="btnPesquisarCliente"/>
                <a href="/Default.aspx" class="btn btn-primary">Voltar</a>

                <br /><br />
                
            <asp:Panel ID="pnlDados" runat="server">
                Nome: <asp:TextBox ID="txtNome" runat="server" Width="45%" CssClass="form-control"></asp:TextBox>
                <br />
                
                Endereço: <asp:TextBox ID="txtEndereco" runat="server" Width="50%" CssClass="form-control"></asp:TextBox>
                <br />

                E-mail: <asp:TextBox ID="txtEmail" runat="server" Width="45%" CssClass="form-control"></asp:TextBox>
                <br />

                <asp:Button ID="btnExclui" runat="server" Text="Excluir" CssClass="btn btn-danger" OnClick="btnExcluirCliente" />
                <asp:Button ID="btnAtualiza" runat="server" Text="Atualizar" CssClass="btn btn-warning" OnClick="btnAtualizarCliente"/>
            </asp:Panel>
        
            <p>
                <asp:Label ID="lblMensagem" runat="server"></asp:Label>
            </p>

        </div>
    
    </div>
    </form>
</body>
</html>
