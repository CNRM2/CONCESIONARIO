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
using static CONCESIONARIO.DAL.Conexion;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CONCESIONARIO
{
    public partial class BVendedor : Form
    {
        private Conexion conexion;
        public BVendedor()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string INE = textBoxINE.Text;
            Conexion conexion = new Conexion();
            dataGridView1.AutoGenerateColumns = false;

            // Realizar la búsqueda por número de bastidor
            DataTable resultados = conexion.BuscarVendedor(INE);
            dataGridView1.Columns["INE"].DataPropertyName = "INE";
            dataGridView1.Columns["NOMBRE"].DataPropertyName = "NOMBRE";
            dataGridView1.Columns["DOMICILIO"].DataPropertyName = "DOMICILIO";
            dataGridView1.Columns["LUGARTRABAJO"].DataPropertyName = "LUGARTRABAJO";


            MessageBox.Show("Se encontraron " + resultados.Rows.Count + " resultados.");

            // Mostrar los resultados en el DataGridView
            dataGridView1.DataSource = resultados;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int INE = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["INE"].Value);

                bool eliminado = conexion.EliminarVendedor(INE);

                if (eliminado)
                {
                    MessageBox.Show("El Vendedor ha sido eliminado correctamente.");

                }
                else
                {
                    MessageBox.Show("Hubo un problema al intentar eliminar al Vendedor.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar al Vendedor.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
