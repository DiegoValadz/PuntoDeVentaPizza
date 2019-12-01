using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidades;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
    public class ConsultasUpdate
    {

        private Conexion con;
        private string myQuery;

        public ConsultasUpdate()
        {
            con = new Conexion();
        }

        public bool updateCliente(Cliente c)
        {
            try
            {
                myQuery = "update Cliente set   Nombre='" + c.Nombre + "' , Correo='" + c.Correo + "' , Telefono='" + c.Telefono + "', Direccion='" + c.Direccion + "' where ClienteID = " + c.Id;
                MySqlCommand query = new MySqlCommand(myQuery);
                query.Connection = con.abrirConexion();
                query.ExecuteNonQuery();
                query.Connection = con.cerrarConexion();
                return true;
            }
            catch (SqlException)
            {
                return false;

            }



        }
    }
}
