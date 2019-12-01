using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades
{
    public class TempObjects
    {
        public static List<Producto> productos = new List<Producto>();
        public static List<Tamaño> tamaños = new List<Tamaño>();
        public static List<Cliente> clientes = new List<Cliente>();
        public static List<Repartidor> repartidores = new List<Repartidor>();
        public static List<Venta> ventas = new List<Venta>();

        public static Repartidor repartidoreActualVenta = new Repartidor();
        public static Cliente clienteActualVenta = new Cliente();
        public static Producto productosActualVenta = new Producto();
        public static Usuario usuarioActualVenta = new Usuario();
        public static Tamaño tamañoActualVenta = new Tamaño();
        public static double totalActualVenta = 0;

        public static List<string> ingredientesList = new List<string>();
        public static string ingredientes = "";
        public static string ticketActualVenta = "";
        public static string fechaActualVenta = "";

    }
}
