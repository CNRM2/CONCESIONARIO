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
    public partial class BAauto : Form
    {
        private Conexion conexion;
        public BAauto()
        {
            InitializeComponent();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            conexion = new Conexion(); // Inicializa la conexión
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numeroBastidor = textBox1.Text;
            Conexion conexion = new Conexion(); 
            dataGridView1.AutoGenerateColumns = false;

            // Realizar la búsqueda por número de bastidor
            DataTable resultados = conexion.BuscarAutoPorBastidor(numeroBastidor);
            dataGridView1.Columns["Bastidor"].DataPropertyName = "Bastidor";
            dataGridView1.Columns["Marca"].DataPropertyName = "Marca";
            dataGridView1.Columns["Modelo"].DataPropertyName = "Modelo";
            dataGridView1.Columns["Precio"].DataPropertyName = "Precio";
            dataGridView1.Columns["Caracteristicas"].DataPropertyName = "Caracteristicas";


            MessageBox.Show("Se encontraron " + resultados.Rows.Count + " resultados.");

            // Mostrar los resultados en el DataGridView
            dataGridView1.DataSource = resultados;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int bastidorSeleccionado = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Bastidor"].Value);

                bool eliminado = conexion.EliminarAutoPorBastidor(bastidorSeleccionado);

                if (eliminado)
                {
                    MessageBox.Show("El auto ha sido eliminado correctamente.");

                }
                else
                {
                    MessageBox.Show("Hubo un problema al intentar eliminar el auto.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar el auto.");
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Precio" && e.Value != null)
            {
                if (e.Value is decimal || e.Value is double || e.Value is float)
                {
                    e.CellStyle.Format = "C"; // Establece el formato de moneda ($xxxxx.xx)
                }
            }
        }
    }
}
