using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class ConsultasDelete
    {
        private Conexion con;
        private string myQuery;

        public ConsultasDelete()
        {
            con = new Conexion();
        }

        public bool deleteCliente(string id)
        {
            try
            {
                myQuery = "delete from Cliente where ClienteID = " + id;
                MySqlCommand query = new MySqlCommand(myQuery);
                query.Connection = con.abrirConexion();
                query.ExecuteNonQuery();
                query.Connection = con.cerrarConexion();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }

        }

        public bool deleteVenta(string id)
        {
            try
            {
                myQuery = "delete from Venta where VentaID = " + id;
                MySqlCommand query = new MySqlCommand(myQuery);
                query.Connection = con.abrirConexion();
                query.ExecuteNonQuery();
                query.Connection = con.cerrarConexion();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }
    }
}
