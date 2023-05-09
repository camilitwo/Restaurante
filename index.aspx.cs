using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using Seguridad;
using System.Data.OleDb;


public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TB_Mensaje.Visible = false;
    }
    protected void Bt_ingreso_Click(object sender, EventArgs e)
    {
        string error_retornado_BD = "";
        bool usuario_es_valido = false;

        string usuario, clave;
        string categoria_BD = "";

        usuario = TB_Usuario.Text;
        clave = TB_Clave.Text;

        ControlAcceso obj_control_acceso = new ControlAcceso();

        usuario_es_valido = obj_control_acceso.ValidaUsuario(ref error_retornado_BD, usuario, clave, ref categoria_BD);
        if (usuario_es_valido == true)
        {
            if (error_retornado_BD == "")
            {
                Session["usuario"] = usuario;
                TB_Mensaje.Text = "";
                if (categoria_BD == "CLI") 
                   Response.Redirect("PaginaCliente.aspx");
                else if (categoria_BD == "ENC")
                   Response.Redirect("PaginaEncargadoMesas.aspx");

                
            }
            else
            {
                TB_Mensaje.Visible = true;
                TB_Mensaje.Text = error_retornado_BD;  // Problemas con BD
            }
        }
        else
        {
            TB_Mensaje.Visible = true;
            TB_Mensaje.Text = "Usuario no existe o clave incorrecta";
        }
    } 
}
