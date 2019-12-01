using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades
{
    public class Venta
    {
        private int ventaID;
        private string ingredientes, tamaño, repartidor, precioTotal, fecha, estadoVenta;
        private string usuario;
        private string producto;
        private string cliente;

        public int VentaID { get => ventaID; set => ventaID = value; }
        public string Ingredientes { get => ingredientes; set => ingredientes = value; }
        public string Tamaño { get => tamaño; set => tamaño = value; }
        public string Repartidor { get => repartidor; set => repartidor = value; }
        public string PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string EstadoVenta { get => estadoVenta; set => estadoVenta = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Producto { get => producto; set => producto = value; }
        public string Cliente { get => cliente; set => cliente = value; }
    }
}
