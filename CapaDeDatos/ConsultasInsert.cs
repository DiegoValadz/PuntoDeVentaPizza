using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidades;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
    public class ConsultasInsert
    {
        private Conexion con;
        private string myQuery;

        public ConsultasInsert()
        {
            con = new Conexion();
        }

        public string insertCliente(Cliente clienteNuevo)
        {
            try
            {
                myQuery = "INSERT INTO cliente ";
                myQuery += "(ClienteID, Nombre,Correo,Telefono,Direccion)";
                myQuery += "VALUES(@ClienteID, @Nombre, @Correo, @Telefono,@Direccion)";
                MySqlCommand query = new MySqlCommand(myQuery);
                query.Connection = con.abrirConexion();

                query.Parameters.Add("@ClienteID", MySqlDbType.Int32).Value = Convert.ToInt32(clienteNuevo.Id);
                query.Parameters.Add("@Nombre", MySqlDbType.VarChar).Value = clienteNuevo.Nombre;
                query.Parameters.Add("@Correo", MySqlDbType.VarChar).Value = clienteNuevo.Correo;
                query.Parameters.Add("@Telefono", MySqlDbType.VarChar).Value = clienteNuevo.Telefono;
                query.Parameters.Add("@Direccion", MySqlDbType.VarChar).Value = clienteNuevo.Direccion;

                query.ExecuteNonQuery();
                query.Connection = con.cerrarConexion();
                return "El Cliente ha sido agregado con exito";
            }
            catch (MySqlException)
            {
                //  MessageBox.Show("No se pudo agregar la máquina porque el ID ya existe");
                return "El cliente no es valido o ya existe.";

            }
        }

        public string insertarVenta()
        {
        //    try
        //    {
                myQuery = "INSERT INTO venta ";
                myQuery += "(UsuarioID, ProductoID,Ingredientes,ClienteID,TamañoID,RepartidorID,PrecioTotal,Fecha,Estado)";
                myQuery += "VALUES(@UsuarioID, @ProductoID, @Ingredientes, @ClienteID,@TamañoID, @RepartidorID, @PrecioTotal,@Fecha,@Estado)";
                MySqlCommand query = new MySqlCommand(myQuery);
                query.Connection = con.abrirConexion();

                query.Parameters.Add("@UsuarioID", MySqlDbType.Int32).Value = TempObjects.usuarioActualVenta.Id;
                query.Parameters.Add("@ProductoID", MySqlDbType.Int32).Value = TempObjects.productosActualVenta.Id;
                query.Parameters.Add("@Ingredientes", MySqlDbType.VarChar).Value = TempObjects.ingredientes;
                query.Parameters.Add("@ClienteID", MySqlDbType.Int32).Value = TempObjects.clienteActualVenta.Id;
                query.Parameters.Add("@TamañoID", MySqlDbType.Int32).Value = TempObjects.tamañoActualVenta.Id;
                query.Parameters.Add("@RepartidorID", MySqlDbType.Int32).Value = TempObjects.repartidoreActualVenta.Id;
                query.Parameters.Add("@PrecioTotal", MySqlDbType.VarChar).Value = TempObjects.totalActualVenta;
                query.Parameters.Add("@Fecha", MySqlDbType.Datetime).Value = TempObjects.fechaActualVenta;
                query.Parameters.Add("@Estado", MySqlDbType.VarChar).Value = "Completada";


                query.ExecuteNonQuery();
                query.Connection = con.cerrarConexion();
                return "La Venta ha sido agregado con exito";
       //     }
        //    catch (MySqlException)
         //   {
                //  MessageBox.Show("No se pudo agregar la máquina porque el ID ya existe");
                return "La Venta no pudo ser procesada.";

       //     }
        }
    }
}
