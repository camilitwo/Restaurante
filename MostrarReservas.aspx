<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="MostrarReservas.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sistema Reserva de Mesas Restaurante</title>
    <style type="text/css">
        .auto-style1 {
            width: 258px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #FFFFCC">
    <div style="text-align: center; background-color: #FFFFFF; display: block; font-size: xx-large; color: #000080; font-style: italic;">
    
        Reserva<br />
        <br />
        <asp:Button ID="btn_reserva" runat="server" OnClick="btn_reserva_Click" Text="Mostrar Reserva" />
        <br />
        <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:GridView ID="gv_datos" runat="server">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <br />
        <br />
    
    </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink5" runat="server" 
        NavigateUrl="~/PaginaEncargadoMesas.aspx">Volver</asp:HyperLink>
    </form>
</body>
</html>
