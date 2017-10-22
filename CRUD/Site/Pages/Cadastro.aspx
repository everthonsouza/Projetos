<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
</head>
    <script src="../Scripts/bootstrap.js"></script>
    <script src="../Scripts/jquery-1.9.0.min.js"></script>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="span10 offset1">
            <div class="row">
                <h3 class="well">Cadastro de Clientes</h3>
                <br />

                Nome: <asp:TextBox ID="txtNome" runat="server" placeholder="Nome completo" Width="45%" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Por favor, digite seu nome." ForeColor="Red" />
                <br />
                
                Endereço: <asp:TextBox ID="txtEndereco" runat="server" placeholder="Endereço" Width="50%" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredEndereco" runat="server" ControlToValidate="txtEndereco" ErrorMessage="Por favor, digite seu endereço." ForeColor="Red" />
                <br />

                E-mail: <asp:TextBox ID="txtEmail" runat="server" placeholder="E-mail" Width="45%" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Por favor, digite seu e-mail." ForeColor="Red" />
                <br />

                <p>
                    <asp:Label ID="lblMensagem" runat="server"></asp:Label>
                </p>

                <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-primary" OnClick="btnCadastrarCliente"/>
                <a href="/Default.aspx" class="btn btn-primary">Voltar</a>
            </div>
            
        </div>
    
    </div>
    </form>
</body>
</html>
