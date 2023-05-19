using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wAccesoDeDatos
{
    public partial class Form1 : Form
    {

        form2 asistencia = new form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asistencia.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsConexion.crearConexion();
            MessageBox.Show("Conexion exitosa");
        }
    }
}
