<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaginaCliente.aspx.cs" Inherits="PaginaCliente" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sistema Reserva de Mesas Restaurante</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" 
            Font-Size="Larger" ForeColor="#000099" Text="Sistema del Cliente"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink5" runat="server" 
            NavigateUrl="~/VerListadoMesas.aspx?pag=CLI">Ver Listado Mesas</asp:HyperLink>
        <br />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink6" runat="server" 
            NavigateUrl="~/SolicitarReserva.aspx?pag=PAS">Solicitar Reserva</asp:HyperLink>
        <br />
        <br />
        <br />
    
    </div>
    <p>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/index.aspx">Salir</asp:HyperLink>
    </p>
    </form>
</body>
</html>
