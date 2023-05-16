using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace wAccesoDeDatos
{
    class clsConexion
    {
        public string strNombre { get; set; }
        public string strApellido { get; set; }
        public int intEdad { get; set; }
        public string strGrado { get; set; }
        public int intTelefono { get; set; }
        public string strInstitucion { get; set; }
        public string strCorreo { get; set; }
        public string strGenero { get; set; }

        public clsConexion() { }

        public clsConexion(string strNombre, string strApellido, int intEdad, string strGrado, int intTelefono, string strInstitucion, string strCorreo, string strGenero)
        {
            this.strNombre = strNombre;
            this.strApellido = strApellido;
            this.intEdad = intEdad;
            this.strGrado = strGrado;
            this.intTelefono = intTelefono;
            this.strInstitucion = strInstitucion;
            this.strCorreo = strCorreo;
            this.strGenero = strGenero;
        } 
        public bool insertarDatos()
        {
            SqlConnection conexion = new SqlConnection("server=LAPTOP-MH17Q20V\\SQLEXPRESS;database=dboColegio;integred security=true");
            conexion.Open();
            string insertar = "insert into tblAsistencia values(@strNombre,@strApellido,@intEdad,@strGrado,@intTelefono,@strInstitucion,@strCorreo,@strGenero)";
            SqlCommand sql = new SqlCommand(insertar, conexion);
            sql.Parameters.AddWithValue("@strNombre", this.strNombre);
            sql.Parameters.AddWithValue("@strApellido", this.strApellido);
            sql.Parameters.AddWithValue("@intEdad", this.intEdad);
            sql.Parameters.AddWithValue("@strGrado", this.strGrado);
            sql.Parameters.AddWithValue("@intTelefono", this.intTelefono);
            sql.Parameters.AddWithValue("@strInstitucion", this.strInstitucion);
            sql.Parameters.AddWithValue("@strCorreo",this.strCorreo);
            sql.Parameters.AddWithValue("@strGenero",this.strGenero);

            return true;
        }
        public DataTable consultarDatos()
        {
            SqlConnection conexion = new SqlConnection("server=LAPTOP-MH17Q20V\\SQLEXPRESS;database=dboColegio;integred security=true");
            conexion.Open();

            DataTable dt = new DataTable();
            string consulta = "select * from tblAsistencia";
            SqlCommand cmd = new SqlCommand(consulta, conexion);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(dt);

            return dt;
        }
        
        public bool eliminarDato(string strNombre)
        {
            SqlConnection conexion = new SqlConnection("server=LAPTOP-MH17Q20V\\SQLEXPRESS;database=dboColegio;integred security=true");
            conexion.Open();

            this.strNombre = strNombre;
            string eliminar = "delete tblAsistencia where strNombre = @strNombre";
            SqlCommand sql = new SqlCommand(eliminar, conexion);
            sql.Parameters.AddWithValue("@strNombre", this.strNombre);
            sql.ExecuteNonQuery();

            return true;

        }
    }
}
