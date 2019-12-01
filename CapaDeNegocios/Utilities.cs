using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocios
{
    public class Utilities
    {
        public static double costosAdicionales;

        public static String GetDateTimeUtc()
        {
            string timeFormat = "yyyy-MM-dd HH:mm:ss";
            return DateTime.UtcNow.AddHours(-5).ToString(timeFormat);
        }

        public static void updateIngredientes()
        {

            TempObjects.ingredientes = "";
            foreach (string s in TempObjects.ingredientesList)
            {
                TempObjects.ingredientes += s + ", ";
            }


        }
        public static double calcularCostosAdd()
        {
            return costosAdicionales = (TempObjects.ingredientes.Length * 5) + TempObjects.tamañoActualVenta.PrecioAdicional;

        }



        public static double calcularTotal()
        {
            double semiCost =  TempObjects.productosActualVenta.PrecioUnitario + costosAdicionales;
            double semiCostIva = semiCost * .16;
            TempObjects.totalActualVenta = semiCost + semiCostIva; 
            return semiCost + semiCostIva;



        }
    }
}
