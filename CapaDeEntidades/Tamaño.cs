using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades
{
    public class Tamaño
    {
        private int id;
        private string tamaño;
        private double precioAdicional;

        public int Id { get => id; set => id = value; }
        public string TamañoValue { get => tamaño; set => tamaño = value; }
        public double PrecioAdicional { get => precioAdicional; set => precioAdicional = value; }
    }
}
