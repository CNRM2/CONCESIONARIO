using CONCESIONARIO.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONCESIONARIO
{
    public partial class AutomovilInfo : Form
    {
        public AutomovilInfo()
        {
            InitializeComponent();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marca = textBox1.Text; // Suponiendo que tienes un TextBox para ingresar el número de bastidor
            Conexion conexion = new Conexion(); // Instancia de tu clase Conexion
            dataGridView1.AutoGenerateColumns = false;

            // Realizar la búsqueda por número de bastidor
            DataTable resultados = conexion.BuscarAutoPorMarca(marca);
            dataGridView1.Columns["Bastidor"].DataPropertyName = "Bastidor";
            dataGridView1.Columns["Marca"].DataPropertyName = "Marca";
            dataGridView1.Columns["Modelo"].DataPropertyName = "Modelo";
            dataGridView1.Columns["Caracteristicas"].DataPropertyName = "Caracteristicas";
            dataGridView1.Columns["Precio"].DataPropertyName = "Precio";
            dataGridView1.Columns["VendedorINE"].DataPropertyName = "VendedorINE";

            MessageBox.Show("Se encontraron " + resultados.Rows.Count + " resultados.");

            // Mostrar los resultados en el DataGridView
            dataGridView1.DataSource = resultados;
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
