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

        public static void updateCliente(Cliente clienteModifi)
        {
            throw new NotImplementedException();
        }
    }
}
