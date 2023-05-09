using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.OleDb;
using ParametrosDatos;


namespace Seguridad
{
    public class ControlAcceso
    {

        public bool ValidaUsuario(ref string error, string usuario, string clave, ref string categoria)
        {
            string sql = "";
            bool EsValido = false;

            sql = "SELECT * FROM tb_Usuarios WHERE usuario='" + usuario + "' and clave='" + clave + "'";   // Consulta sql           

            Parametros obj_parametros = new Parametros(); //para obtener string de conexión

            OleDbConnection cnn = new OleDbConnection(obj_parametros.string_de_conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(sql, cnn);
            DataTable datos = new DataTable();
            try   // Ambiente controlado de ejecución, por errores externos
            {
                cnn.Open();
                da.Fill(datos);
            }
            catch (OleDbException ex)
            {
                error = ex.Message;
            }
            finally
            {
                cnn.Close();
            }

            if (datos.Rows.Count > 0) // Encontró coincidencia de usuario y clave, es dcir, es válido. Entonces obtenemnos categoría
            {  
                EsValido = true;
                categoria = datos.Rows[0]["categoria"].ToString();
            }

            return EsValido;

        } // ValidaUsuario

    }//fin clase ControlAcceso

    public class RestauranteDAO
    {
        public DataTable selectGenerico(string tabla)
        {
            string sql = "";

            sql = "SELECT * FROM :tablaGenerica ";   // Consulta sql           
            sql = sql.Replace(":tablaGenerica", tabla);
            Parametros obj_parametros = new Parametros(); //para obtener string de conexión

            OleDbConnection cnn = new OleDbConnection(obj_parametros.string_de_conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(sql, cnn);
            DataTable datos = new DataTable();
            try   // Ambiente controlado de ejecución, por errores externos
            {
                cnn.Open();
                da.Fill(datos);
            }
            catch (OleDbException ex)
            {
                return null;
            }
            finally
            {
                cnn.Close();
            }
            return datos;

        } 
    }

}  // namespace Seguridad