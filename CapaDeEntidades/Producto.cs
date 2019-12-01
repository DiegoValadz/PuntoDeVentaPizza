using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades
{
    public class Producto
    {
        private string id, nombre, descripcion, tamaño;
        private double precioUnitario, precioIva;

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Tamaño { get => tamaño; set => tamaño = value; }
        public double PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public double PrecioIva { get => precioIva; set => precioIva = value; }
    }
}
