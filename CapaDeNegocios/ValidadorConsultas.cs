using CapaDeDatos;
using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class ValidadorConsultas
    {
        public static int accesoSP(Usuario usuario)
        {
            ConsultasSelect cs = new ConsultasSelect();
            return cs.Login(usuario.UserName, usuario.Contraseña);
        }

        public static List<Cliente> getClientes()
        {
            ConsultasSelect cs = new ConsultasSelect();
            return cs.getClientes();
        }

        public static string insertarCliente(Cliente clienteNuevo)
        {
            string status = "";
            ConsultasInsert ci = new ConsultasInsert();
            status = ci.insertCliente(clienteNuevo);
            return status;



        }

        public static bool updateCliente(Cliente clienteModifi)
        {
            ConsultasUpdate cu = new ConsultasUpdate();
            return cu.updateCliente(clienteModifi);


        }

        public static void deleteCliente(string id)
        {
            ConsultasDelete cd = new ConsultasDelete();
            cd.deleteCliente(id);


        }

        public static List<Producto> getProductos()
        {
            ConsultasSelect cs = new ConsultasSelect();
            return cs.getProductos();
        }

        public static List<Tamaño> getTamaños()
        {
            ConsultasSelect cs = new ConsultasSelect();
            return cs.getTamaños();
        }

        public static List<string> getColumna(string columna, string tabla)
        {
            ConsultasSelect cs = new ConsultasSelect();
            return cs.columnaSelect(columna,tabla);
        }

        public static List<Repartidor> getRepartidores()
        {
            ConsultasSelect cs = new ConsultasSelect();
            return cs.getRepartidores();
        }

        public static string generarVenta()
        {
            string status = "";

            ConsultasInsert ci = new ConsultasInsert();
            status = ci.insertarVenta();
            return status;
        }

        public static List<Venta> getVentas()
        {
            ConsultasSelect cs = new ConsultasSelect();
            return cs.getVentas();
        }

        public static bool deleteVenta(string id)
        {

            ConsultasDelete cd = new ConsultasDelete();
            return cd.deleteVenta(id);

        }
    }
}
