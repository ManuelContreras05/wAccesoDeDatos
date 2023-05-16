using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                SqlConnection conexion = new SqlConnection("server=LAPTOP-MH17Q20V\\SQLEXPRESS;database=dboColegio;integred security=true");
                conexion.Open();

                clsConexion clsConexion = new clsConexion(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtEdad.Text), cmbGrado.Text, Convert.ToInt32(txtTelefono.Text), txtInstitucion.Text, txtCorreo.Text, cmbGenero.Text);
                clsConexion.insertarDatos();

                MessageBox.Show("Dato ingresado");

                dtgData.DataSource = clsConexion.consultarDatos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar el dato" + ex.Message);
                throw;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=LAPTOP-MH17Q20V\\SQLEXPRESS;database=dboColegio;integred security=true");
                conexion.Open();

                clsConexion clsConexion = new clsConexion();
                dtgData.DataSource = clsConexion.consultarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el dato" + ex.Message);
                throw;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=LAPTOP-MH17Q20V\\SQLEXPRESS;database=dboColegio;integred security=true");
                conexion.Open();

                clsConexion clsConexion = new clsConexion();
                clsConexion.eliminarDato(txtNombre.Text);

                dtgData.DataSource = clsConexion.consultarDatos();


            }
            catch (Exception ex)
            {
                MessageBox.Show("error al eliminar registro" + ex.Message);
                throw;
            }
        }

        private void dtgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=LAPTOP-MH17Q20V\\SQLEXPRESS;database=dboColegio;integred security=true");
            conexion.Open();

            txtNombre.Text = dtgData.SelectedRows[0].Cells[0].Value.ToString();
            txtApellido.Text = dtgData.SelectedRows[0].Cells[1].Value.ToString();
            txtEdad.Text  = dtgData.SelectedRows[0].Cells[2].Value.ToString();
            cmbGrado.Text = dtgData.SelectedRows[0].Cells[3].Value.ToString();
            txtTelefono.Text = dtgData.SelectedRows[0].Cells[4].Value.ToString();
            txtInstitucion.Text = dtgData.SelectedRows[0].Cells[5].Value.ToString();
            txtCorreo.Text = dtgData.SelectedRows[0].Cells[6].Value.ToString();
            cmbGenero.Text = dtgData.SelectedRows[0].Cells[7].Value.ToString();

        }
    }
}
