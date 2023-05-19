using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace wAccesoDeDatos.CLASES
{
    public class clsUsuarios
    {
        //Creamos nuestros atributos
        private int intid; 
        private string strNombre;
        private string strApellido;
        private int intEdad;
        private string strGrado;
        private int intTelefono;
        private string strInstitucion;
        private string strCorreo;
        private string strGenero;

        //Creamos constructor de la clase 
        public clsUsuarios(int intid, string strNombre, string strApellido, int intEdad, string strGrado, int intTelefono, string strInstitucion, string strCorreo, string strGenero)
        {
            this.intid = intid;
            this.strNombre = strNombre;
            this.strApellido = strApellido;
            this.intEdad = intEdad;
            this.strGrado = strGrado;
            this.intTelefono = intTelefono;
            this.strInstitucion = strInstitucion;
            this.strCorreo = strCorreo;
            this.strGenero = strGenero;
        }

        //Creamos un segundo constructor para acceder a los metodos de la clase
        public clsUsuarios() { }

        //Generamos los metodos get y set de las variables 
        public int Intid { get => intid; set => intid = value; }
        public string StrNombre { get => strNombre; set => strNombre = value; }
        public string StrApellido { get => strApellido; set => strApellido = value; }
        public int IntEdad { get => intEdad; set => intEdad = value; }
        public string StrGrado { get => strGrado; set => strGrado = value; }
        public int IntTelefono { get => intTelefono; set => intTelefono = value; }
        public string StrInstitucion { get => strInstitucion; set => strInstitucion = value; }
        public string StrCorreo { get => strCorreo; set => strCorreo = value; }
        public string StrGenero { get => strGenero; set => strGenero = value; }

    }
}
