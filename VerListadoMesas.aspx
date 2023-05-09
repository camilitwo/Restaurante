<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="VerListadoMesas.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sistema Reserva de Mesas Restaurante</title>
    <style type="text/css">
        .auto-style1 {
            width: 499px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #FFFFCC">
    <div style="text-align: center; background-color: #FFFFFF; display: block; font-size: xx-large; color: #000080; font-style: italic;">
    
        Listado de Mesas<br />
        <br />
        <asp:Button ID="btn_verListado" runat="server" OnClick="btn_verListado_Click" Text="Ver Listado" />
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
                    <asp:GridView ID="gv_listadoMesas" runat="server">
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
    
    </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink5" runat="server">Volver</asp:HyperLink>
    </form>
</body>
</html>
