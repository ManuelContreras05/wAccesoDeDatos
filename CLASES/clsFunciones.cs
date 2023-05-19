using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace wAccesoDeDatos.CLASES
{
    class clsFunciones
    {
        //Crear metodo para insertar info en la base de datos
        public static int insertarDatos(clsUsuarios add)
        {

            int estado = 0;

            SqlCommand comando = new SqlCommand(string.Format("insert into tblEstudiantes values(@intid,@strNombre,@strApellido,@intEdad,@strGrado,@intTelefono,@strInstitucion,@strCorreo,@strGenero)",
               add.Intid, add.StrNombre, add.StrApellido, add.IntEdad, add.StrGrado, add.IntTelefono, add.StrInstitucion, add.StrCorreo, add.StrGenero),clsConexion.crearConexion());

            comando.Parameters.AddWithValue("@intid", add.Intid);
            comando.Parameters.AddWithValue("@strNombre", add.StrNombre);
            comando.Parameters.AddWithValue("@strApellido", add.StrApellido);
            comando.Parameters.AddWithValue("@intEdad", add.IntEdad);
            comando.Parameters.AddWithValue("@strGrado", add.StrGrado);
            comando.Parameters.AddWithValue("@intTelefono", add.IntTelefono);
            comando.Parameters.AddWithValue("@strInstitucion", add.StrInstitucion);
            comando.Parameters.AddWithValue("@strCorreo", add.StrCorreo);
            comando.Parameters.AddWithValue("@strGenero", add.StrGenero);

            estado = comando.ExecuteNonQuery();

            return estado;
        }

        //Craar metodo para mostrar info de la tabla alumno
        public static List<clsUsuarios> mostrarRegistro()
        {
            //obtiene info de la clase usuarios
            List<clsUsuarios> lista = new List<clsUsuarios>();
            //Hacemos la consulta en la tabla de datos
            SqlCommand comando = new SqlCommand(string.Format("select * from tblEstudiantes"), clsConexion.crearConexion());
            //creamos un data reader para leer esa informacion que nos manda la info de comando
            SqlDataReader leer = comando.ExecuteReader();

            while (leer.Read())
            {
                clsUsuarios datos = new clsUsuarios();

                datos.Intid = leer.GetInt32(0);
                datos.StrNombre = leer.GetString(1);
                datos.StrApellido = leer.GetString(2);
                datos.IntEdad = leer.GetInt32(3);
                datos.StrGrado = leer.GetString(4);
                datos.IntTelefono = leer.GetInt32(5);
                datos.StrInstitucion = leer.GetString(6);
                datos.StrCorreo = leer.GetString(7);
                datos.StrGenero = leer.GetString(8);

                lista.Add(datos);

            }
            
            return lista;
        }

        //Crear metodo para hacer una busqueda
        public static List<clsUsuarios> buscar(int id) 
        {
            List<clsUsuarios> lista = new List<clsUsuarios>();

            SqlCommand comando = new SqlCommand(string.Format("select * from tblEstudiantes where id = '{0}'", id),clsConexion.crearConexion());

            SqlDataReader leer = comando.ExecuteReader();

            while (leer.Read()) 
            {

                clsUsuarios datos = new clsUsuarios();

                datos.Intid = leer.GetInt32(0);
                datos.StrNombre = leer.GetString(1);
                datos.StrApellido = leer.GetString(2);
                datos.IntEdad = leer.GetInt32(3);
                datos.StrGrado = leer.GetString(4);
                datos.IntTelefono = leer.GetInt32(5);
                datos.StrInstitucion = leer.GetString(6);
                datos.StrCorreo = leer.GetString(7);
                datos.StrGenero = leer.GetString(8);

                lista.Add(datos); 

            } 

            return lista;   
        }
        //Crear metodo para obtener la info del usuario seleccionado
        //public static clsUsuarios obtenerUsuario(int id)
        //{
        //    clsUsuarios datos = new clsUsuarios();

        //    SqlCommand comando = new SqlCommand(string.Format("select * from tblEstudiantes where id = '{0}'", id), clsConexion.crearConexion());

        //    SqlDataReader leer = comando.ExecuteReader();

        //    while (leer.Read())
        //    {
        //        datos.Intid = leer.GetInt32(0);
        //        datos.StrNombre = leer.GetString(1);
        //        datos.StrApellido = leer.GetString(2);
        //        datos.IntEdad = leer.GetInt32(3);
        //        datos.StrGrado = leer.GetString(4);
        //        datos.IntTelefono = leer.GetInt32(5);
        //        datos.StrInstitucion = leer.GetString(6);
        //        datos.StrCorreo = leer.GetString(7);
        //        datos.StrGenero = leer.GetString(8);
        //    }
        //    return datos;
        //}
        //Metodo para elminar registro
        public static int eliminarUsuario(clsUsuarios add)
        {
           
            int estado = 0;

            SqlCommand comando = new SqlCommand(string.Format("delete from tblEstudiantes values(@intid,@strNombre,@strApellido,@intEdad,@strGrado,@intTelefono,@strInstitucion,@strCorreo,@strGenero)", clsConexion.crearConexion()));

            SqlDataReader leer = comando.ExecuteReader();

            return estado;

            //SqlCommand comando = new SqlCommand(string.Format("delete from tblEstudiantes where id = '{0}'", id), clsConexion.crearConexion());

            //int eliminado = comando.ExecuteNonQuery();

            //return eliminado;
        }
    }
}
