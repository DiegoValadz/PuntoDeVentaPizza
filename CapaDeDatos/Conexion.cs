using System.Data;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
    public class Conexion
    {
        private MySqlConnection conexionBD;
        private string msg;

        public Conexion(string URL)
        {
            conexionBD = new MySqlConnection(URL);
        }

        public Conexion()
        {
            // msg = "server=DESKTOP-GKTAMUP; port=3306; user id=root; password=1234; database=PizzaDB ;";
             msg = "Server=127.0.0.1;Database=pizzadb; Uid=root;Pwd=Pa55word;";
           // msg = "Server=127.0.0.1;Database=pizzadb; Uid=root;Pwd=1234;";
            conexionBD = new MySqlConnection(msg);
        }

        public MySqlConnection abrirConexion()
        {
            if (conexionBD.State == ConnectionState.Closed)
            {
                conexionBD.Open();
            }
            return conexionBD;
        }

        public MySqlConnection cerrarConexion()
        {
            if (conexionBD.State == ConnectionState.Open)
            {
                conexionBD.Close();
            }
            return conexionBD;
        }
    }
}
