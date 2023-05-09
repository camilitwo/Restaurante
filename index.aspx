<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="index.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sistema Reserva de Mesas Restaurante</title>
</head>
<body >
    <form id="form1" runat="server">
    <div style="text-align: center; color: #003399;">
    
        <br />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="True" 
            Font-Size="Larger" ForeColor="#003399" Text="Control de Acceso"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Large" ForeColor="#003399" Text="Usuarios: cliente y encargado (clave = usuario)"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TB_Usuario" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Clave"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TB_Clave" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Bt_ingreso" runat="server" ForeColor="#003399" 
            onclick="Bt_ingreso_Click" Text="Ingresar" Width="113px" />
        <br />
        <br />
        <br />
        <asp:TextBox ID="TB_Mensaje" runat="server" ReadOnly="True" Width="217px" 
            BorderStyle="None"></asp:TextBox>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
