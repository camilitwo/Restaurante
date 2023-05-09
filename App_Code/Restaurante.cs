using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Seguridad;
/// <summary>
/// Descripción breve de Restaurante
/// </summary>
/// 
namespace clase
{
    public class ReservasPadre
    {
        private string cantidad_persona;
        private string fecha;
        private string nombre;
        private string num_mesa;
        private string rut_cliente;

        public string Cantidad_Persona
        {
            get
            {
                return cantidad_persona;
            }

            set
            {
                cantidad_persona = value;
            }
        }

        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Num_mesa
        {
            get
            {
                return num_mesa;
            }

            set
            {
                num_mesa = value;
            }
        }

        public string Rut_cliente
        {
            get
            {
                return rut_cliente;
            }

            set
            {
                rut_cliente = value;
            }
        }

        public void CancelarReserva()
        {

        }

        public void SolicitarReserva()
        {

        }
    }

    public class ReservasHijo: ReservasPadre
    {
        public Mesa Mesa
        {
            get
            {
                return new Mesa();
            }

            set
            {
            }
        }

        public DataTable MostrarReservas()
        {
            RestauranteDAO dao = new RestauranteDAO();
            return dao.selectGenerico("tb_reservas");
        }
    }

    public class Mesa
    {

        public DataTable VerListadoMesas()
        {
            RestauranteDAO dao = new RestauranteDAO();
            
            return dao.selectGenerico("tb_mesas");
        }

    }
}

