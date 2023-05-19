using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using wAccesoDeDatos.CLASES;

namespace wAccesoDeDatos
{
    class clsConexion
    {
        public static SqlConnection crearConexion()
        {
            SqlConnection sqlConnection = new SqlConnection("server=LAPTOP-MH17Q20V; database=Colegio; integrated security=true");
            sqlConnection.Open();

            return sqlConnection;
        }
    }
}
