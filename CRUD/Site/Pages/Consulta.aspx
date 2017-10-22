<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Site.Pages.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consulta</title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
</head>
    <script src="../Scripts/bootstrap.js"></script>
    <script src="../Scripts/jquery-1.9.0.min.js"></script>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="span10 offset1">
            <div class="row">
                <h3 class="well">Consulta de Clientes</h3>

                <asp:GridView ID="gridClientes" runat="server" CssClass="table table-hover table-striped" GridLines="None" AutoGenerateColumns="false" BackColor="#99ccff">
                    <Columns>
                        <asp:BoundField DataField="Codigo" HeaderText="Código" />
                        <asp:BoundField DataField="Nome" HeaderText="Nome" />
                        <asp:BoundField DataField="Endereco" HeaderText="Endereço" />
                        <asp:BoundField DataField="Email" HeaderText="E-mail" />
                    </Columns>
                    <RowStyle CssClass="cursor-pointer" />
                </asp:GridView>

                <p>
                    <asp:Label ID="lblMensagem" runat="server"></asp:Label>
                </p>
                <a href="/Default.aspx" class="btn btn-primary">Voltar</a>
            </div>
            
        </div>
    
    </div>
    </form>
</body>
</html>
