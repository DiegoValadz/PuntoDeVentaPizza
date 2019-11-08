using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
          //  try
          //  {
                query.CommandText = "sp_login";
                query.CommandType = CommandType.StoredProcedure;
                query.Parameters.Add("userP", MySqlDbType.VarChar).Value = User;
                query.Parameters.Add("passP", MySqlDbType.VarChar).Value = Pass;
                query.Parameters.Add("@LoginR", MySqlDbType.Int16).Direction= ParameterDirection.Output;


                query.Connection = con.abrirConexion();

                MySqlDataReader reader = query.ExecuteReader();

                reader.Read();
                res = Convert.ToInt32( reader["LoginR"]);
            query.Connection = con.cerrarConexion();

                return res;

          //  }
         //   catch (InvalidCastException)
         //   {
         //       return res;
        //    }
         //   catch (InvalidOperationException)
         //   {
         //       return res;

        //    }
        }
    }
}
