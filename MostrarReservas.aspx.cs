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
    }

    protected void btn_reserva_Click(object sender, EventArgs e)
    {
        ReservasHijo reservas = new ReservasHijo();
        DataTable dt = reservas.MostrarReservas();
        gv_datos.Columns.Clear();
        gv_datos.DataSource = dt;
        gv_datos.DataBind();
        foreach (DataColumn column in dt.Columns)
        {
            BoundField field = new BoundField();
            field.DataField = column.ColumnName;
            field.HeaderText = column.ColumnName;
            gv_datos.Columns.Add(field);
        }

    }
}
