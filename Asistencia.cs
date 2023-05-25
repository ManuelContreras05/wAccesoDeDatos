using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agregar la libreria que nos permita usar los metodos
using wAccesoDeDatos.CLASES;

namespace wAccesoDeDatos
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validacion de los cuadros de textos 
                if (txtId.Text == "")
                {
                    errorProvider1.SetError(txtId, "Debe ingresar el id del estudiante");
                    txtId.Focus();
                    return;
                }
                errorProvider1.SetError(txtId, "");

                //Validacion de nombre
                if (txtNombre.Text == "")
                {
                    errorProvider1.SetError(txtNombre, "Debe ingresar el nombre del estudiante");
                    txtNombre.Focus();
                    return;
                }
                errorProvider1.SetError(txtNombre, "");

                //Validacion Apellido
                if (txtApellido.Text == "")
                {
                    errorProvider1.SetError(txtApellido, "Debe ingresar el apellido del estudiante");
                    txtApellido.Focus();
                    return;
                }
                errorProvider1.SetError(txtApellido, "");


                //Validacion de edad 
                if (txtEdad.Text == "")
                {
                    errorProvider1.SetError(txtEdad, "Debe ingresar la edad del estudiante");
                    txtEdad.Focus();
                    return;
                }
                errorProvider1.SetError(txtEdad, "");

                //validacion de Grado
                if (cmbGrado.Text == "")
                {
                    errorProvider1.SetError(cmbGrado, "Debe ingresar el grado del estudiante");
                    cmbGrado.Focus();
                    return;
                }
                errorProvider1.SetError(cmbGrado, "");

                //validacion de telefono
                if (txtTelefono.Text == "")
                {
                    errorProvider1.SetError(txtTelefono, "Debe ingresar el telefono del estudiante");
                    txtTelefono.Focus();
                    return;
                }
                errorProvider1.SetError(txtTelefono, "");

                //Validacion de la institucion
                if (txtInstitucion.Text == "")
                {
                    errorProvider1.SetError(txtInstitucion, "Debe ingresar nombre 'Institucion o Universidad'");
                    txtInstitucion.Focus();
                    return;
                }
                errorProvider1.SetError(txtInstitucion, "");

                //Validacion de correo
                if (txtCorreo.Text == "")
                {
                    errorProvider1.SetError(txtCorreo, "Debe ingresar el correo electronico");
                    txtCorreo.Focus();
                    return;
                }
                errorProvider1.SetError(txtCorreo, "");

                //Validacion de genero 
                if (cmbGenero.Text == "")
                {
                    errorProvider1.SetError(cmbGenero, "Debe ingresar sexo del estudiante");
                    cmbGenero.Focus();
                    return;
                }
                errorProvider1.SetError(cmbGenero, "");

                //generar una instancia a la clase usuario
                clsUsuarios insertar = new clsUsuarios();
                //enviar la info directo a la clase usuario
                //esa info se enviara a la consulta y esta la enviara a la tabla asistencia
                insertar.Intid = Convert.ToInt32(txtId.Text);
                insertar.StrNombre = txtNombre.Text;
                insertar.StrApellido = txtApellido.Text;
                insertar.IntEdad = Convert.ToInt32(txtEdad.Text);
                insertar.StrGrado = cmbGrado.Text;
                insertar.IntTelefono = Convert.ToInt32(txtTelefono.Text);
                insertar.StrInstitucion = txtInstitucion.Text;
                insertar.StrCorreo = txtCorreo.Text;
                insertar.StrGenero = cmbGenero.Text;

                //Generamos instancia al metodo insertar, para enviar la info a la tabla asistencia
                int estado = clsFunciones.insertarDatos(insertar);
                if (estado > 0)
                {
                    MessageBox.Show("Datos guardados");
                    limpiar();
                }
                else 
                {
                    MessageBox.Show("Error al ingresar el dato ");
                }
                llenarTabla();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ingresar el dato " + ex);

                throw;
            }
        }
        //Crear metodo para limpiar 
        private void limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            cmbGrado.Text = "";
            txtTelefono.Text = "";
            txtInstitucion.Text = "";
            txtCorreo.Text = "";
            cmbGenero.Text = "";
            txtId.Focus();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            llenarTabla();

        }
        //metodo para llenar tabla 
        private void llenarTabla()
        {
            //gerenamos una instancia a la clase funciones para usar el metodo
            dtgData.DataSource = clsFunciones.mostrarRegistro();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {
                    errorProvider1.SetError(txtId, "Debe ingresar el id del estudiante");
                    txtId.Focus();
                    return;
                }
                errorProvider1.SetError(txtId, "");

                dtgData.DataSource = clsFunciones.buscar(Convert.ToInt32(txtId.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                    int eliminar = clsFunciones.eliminarUsuario(Convert.ToInt32(txtId.Text));

                    if (eliminar > 0)
                    {
                        MessageBox.Show("Usuario eliminado");
                        limpiar();

                    }
                    else
                    {
                        MessageBox.Show("Error en eliminar usuario ");

                    } 
                    llenarTabla();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);

                throw;
            }
        }
        
        private void dtgData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            txtId.Text = this.dtgData.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = this.dtgData.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = this.dtgData.CurrentRow.Cells[2].Value.ToString();
            txtEdad.Text = this.dtgData.CurrentRow.Cells[3].Value.ToString();
            cmbGrado.Text = this.dtgData.CurrentRow.Cells[4].Value.ToString();
            txtTelefono.Text = this.dtgData.CurrentRow.Cells[5].Value.ToString();
            txtInstitucion.Text = this.dtgData.CurrentRow.Cells[6].Value.ToString();
            txtCorreo.Text = this.dtgData.CurrentRow.Cells[7].Value.ToString();
            cmbGenero.Text = this.dtgData.CurrentRow.Cells[8].Value.ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del DataGridView y guardarlos en una lista de cadenas
            var datos = new  System.Collections.Generic.List<string>();

            foreach (DataGridViewRow fila in dtgData.Rows)
            {
                if (!fila.IsNewRow)//Omitir la ultima fila nueva
                {
                    string filaDatos = "";

                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        filaDatos += celda.Value.ToString() + "\t"; // Separar las columnas por un tabulador
                    }
                    datos.Add(filaDatos.TrimEnd('\t'));// Agregar la fila a la lista   
                }
            }
            try
            {
                using (StreamWriter archivo = new StreamWriter(@"C:\\Users\\Manuel\\OneDrive\\Escritorio\\prueba.txt")) 
                {
                    foreach (string fila in datos)
                    {
                        archivo.WriteLine(fila);
                    }
                
                }
                MessageBox.Show("Los datos se han guardado correctamente en el archivo.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
                throw;
            }

        }
    }
} 
