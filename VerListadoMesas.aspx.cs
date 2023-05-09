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
using clase;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((string)Session["usuario"] == null)
        {
            Response.Redirect("index.aspx");
        }
        if (Request.QueryString["pag"] == "CLI")
        {
            HyperLink5.NavigateUrl = "PaginaCliente.aspx";
        }
        else if (Request.QueryString["pag"] == "ENC")
        {
            HyperLink5.NavigateUrl = "PaginaEncargadoMesas.aspx";
        }
    }

    protected void btn_verListado_Click(object sender, EventArgs e)
    {
        ReservasHijo reservas = new ReservasHijo();
        DataTable dt = reservas.Mesa.VerListadoMesas();
        gv_listadoMesas.Columns.Clear();
        gv_listadoMesas.DataSource = dt;
        gv_listadoMesas.DataBind();
        foreach (DataColumn column in dt.Columns)
        {
            BoundField field = new BoundField();
            field.DataField = column.ColumnName;
            field.HeaderText = column.ColumnName;
            gv_listadoMesas.Columns.Add(field);
        }
    }
}
