using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidades;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
    public class ConsultasSelect
    {
        private Conexion con;
        private string myQuery;

        public ConsultasSelect()
        {
            con = new Conexion();
        }
        public int Login(string User, string Pass)
        {
            int res = -1;
            MySqlCommand query = new MySqlCommand();
            try
            {
                query.CommandText = "sp_login";
                query.CommandType = CommandType.StoredProcedure;
                query.Parameters.Add("userP", MySqlDbType.VarChar).Value = User;
                query.Parameters.Add("passP", MySqlDbType.VarChar).Value = Pass;
                query.Parameters.Add("@LoginR", MySqlDbType.Int16).Direction = ParameterDirection.Output;


                query.Connection = con.abrirConexion();

                MySqlDataReader reader = query.ExecuteReader();

                reader.Read();
                res = Convert.ToInt32(reader["LoginR"]);
                TempObjects.usuarioActualVenta.Id = (int)reader["UsuarioID"];
                TempObjects.usuarioActualVenta.Nombre = (string)reader["Nombre"];
                query.Connection = con.cerrarConexion();
            
                return res;

            }
            catch (InvalidCastException)
            {
                return res;
            }
            catch (InvalidOperationException)
            {
                return res;

            }
        }

        public List<string> columnaSelect(string columna, string tabla)
        {
            List<string> aux = new List<string>();
            myQuery = "SELECT " + columna + " FROM " + tabla;
            MySqlCommand query = new MySqlCommand(myQuery);
            query.Connection = con.abrirConexion();
            MySqlDataReader reader = query.ExecuteReader();

            while (reader.Read())
            {
                reader.GetString(0);
                aux.Add(reader.GetString(0));
            }
            query.Connection = con.cerrarConexion();

            return aux;
        }

        public List<Repartidor> getRepartidores()
        {
            List<Repartidor> reps = new List<Repartidor>();
            myQuery = "select RepartidorID, Nombre ";
            myQuery += "from Repartidor; ";
            MySqlCommand query = new MySqlCommand(myQuery);
            query.Connection = con.abrirConexion();
            MySqlDataReader reader = query.ExecuteReader();



            while (reader.Read())
            {
                Repartidor r = new Repartidor();
                r.Id = (int)reader["RepartidorID"];
                r.Nombre = (string)reader["Nombre"];


                reps.Add(r);
            }

            query.Connection = con.cerrarConexion();

            return reps;
        }

        public List<Venta> getVentas()
        {
            List<Venta> tams = new List<Venta>();
            myQuery = "select VentaID, u.Nombre as Usuario ,p.Nombre as Producto,c.Nombre as Cliente ,r.Nombre as Repartidor,PrecioTotal,Fecha,Estado ";
            myQuery += "from venta as v inner join usuario as u on v.UsuarioID = u.UsuarioID";
            myQuery += " inner join producto as p on v.ProductoID = p.ProductoID";
            myQuery += "  inner join cliente as c on v.ClienteID = c.ClienteID ";
                myQuery += "inner join repartidor as r on v.RepartidorID = r.RepartidorID   ";
            MySqlCommand query = new MySqlCommand(myQuery);
            query.Connection = con.abrirConexion();
            MySqlDataReader reader = query.ExecuteReader();



            while (reader.Read())
            {
                Venta v = new Venta();
                v.VentaID = Convert.ToInt32(reader["VentaID"]);
                v.Usuario = (string)reader["Usuario"];
                v.Producto = (string)reader["Producto"];
                v.Cliente = (string)reader["Cliente"];
                v.Repartidor = (string)reader["Repartidor"];
                v.PrecioTotal = Convert.ToDouble(reader["PrecioTotal"]).ToString();
                v.Fecha = Convert.ToDateTime(reader["Fecha"]).ToString();
                v.EstadoVenta = (string)reader["Estado"];


                tams.Add(v);
            }

            query.Connection = con.cerrarConexion();

            return tams;



        }

        public List<Tamaño> getTamaños()
        {
            List<Tamaño> tams = new List<Tamaño>();
            myQuery = "select TamañoID, Tamaño , PrecioAñadido ";
            myQuery += "from Tamaño; ";
            MySqlCommand query = new MySqlCommand(myQuery);
            query.Connection = con.abrirConexion();
            MySqlDataReader reader = query.ExecuteReader();



            while (reader.Read())
            {
                Tamaño t = new Tamaño();
                t.Id = (int)reader["TamañoID"];
                t.TamañoValue = (string)reader["Tamaño"];
                t.PrecioAdicional = Convert.ToDouble(reader["PrecioAñadido"]);


                tams.Add(t);
            }

            query.Connection = con.cerrarConexion();

            return tams;
        }

        public List<Producto> getProductos()
        {

            List<Producto> prods = new List<Producto>();
            myQuery = "select p.ProductoID, p.Nombre , p.Descripcion ,p.PrecioUnitario ";
            myQuery +="from Producto as p; ";
            MySqlCommand query = new MySqlCommand(myQuery);
            query.Connection = con.abrirConexion();
            MySqlDataReader reader = query.ExecuteReader();



            while (reader.Read())
            {
                Producto p = new Producto();
                p.Id= ((int)reader["ProductoID"]).ToString();
                p.Nombre = (string)reader["Nombre"];
                p.Descripcion = (string)reader["Descripcion"];
                p.PrecioUnitario = Convert.ToDouble( reader["PrecioUnitario"]);
              

                prods.Add(p);
            }

            query.Connection = con.cerrarConexion();

            return prods;
                       
        }

        public List<Cliente> getClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            myQuery = "select * from cliente;";
            MySqlCommand query = new MySqlCommand(myQuery);
            query.Connection = con.abrirConexion();
            MySqlDataReader reader = query.ExecuteReader();



            while (reader.Read())
            {
                Cliente c = new Cliente();
                c.Id = ((int)reader["ClienteID"]).ToString();
                c.Nombre = (string)reader["Nombre"];
                c.Correo = (string)reader["Correo"];
                c.Telefono = (string)reader["Telefono"];
                c.Direccion = (string)reader["Direccion"];
                clientes.Add(c);
            }
        
            query.Connection = con.cerrarConexion();

            return clientes;



        }
    }
}
