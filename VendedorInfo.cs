using CONCESIONARIO.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONCESIONARIO
{
    public partial class VendedorInfo : Form
    {
        public VendedorInfo()
        {
            InitializeComponent();
        }

        private void VendedorInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numINE = textBox1.Text; // Suponiendo que tienes un TextBox para ingresar el número de bastidor
            Conexion conexion = new Conexion(); // Instancia de tu clase Conexion
            dataGridView1.AutoGenerateColumns = false;

            // Realizar la búsqueda por número de bastidor
            DataTable resultados = conexion.BuscarAutoPorINE(numINE);
            dataGridView1.Columns["INE"].DataPropertyName = "INE";
            dataGridView1.Columns["NOMBRE"].DataPropertyName = "NOMBRE";
            dataGridView1.Columns["DOMICILIO"].DataPropertyName = "DOMICILIO";
            dataGridView1.Columns["LUGARTRABAJO"].DataPropertyName = "LUGARTRABAJO";

            MessageBox.Show("Se encontraron " + resultados.Rows.Count + " resultados.");

            // Mostrar los resultados en el DataGridView
            dataGridView1.DataSource = resultados;
        }
    }
}
