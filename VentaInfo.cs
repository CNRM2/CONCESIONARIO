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
    public partial class VentaInfo : Form
    {
        private Conexion conexion;
        public VentaInfo()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string IDVenta = txtIDVenta.Text;
            Conexion conexion = new Conexion();
            dataGridView1.AutoGenerateColumns = false;

            // Realizar la búsqueda por número de bastidor
            DataTable resultados = conexion.CargarVentas(IDVenta);
            dataGridView1.Columns["IDVENTA"].DataPropertyName = "IDVENTA";
            dataGridView1.Columns["FECHA"].DataPropertyName = "FECHA";
            dataGridView1.Columns["METODOPAGO"].DataPropertyName = "METODOPAGO";
            dataGridView1.Columns["STOCK"].DataPropertyName = "STOCK";
            dataGridView1.Columns["NOMBREVENDEDOR"].DataPropertyName = "NOMBRE_VENDEDOR";
            dataGridView1.Columns["BASTIDOR"].DataPropertyName = "BASTIDOR";
            dataGridView1.Columns["MODELO"].DataPropertyName = "MODELO";
            dataGridView1.Columns["PRECIO_MODELO"].DataPropertyName = "PRECIO_MODELO";
            dataGridView1.Columns["IDEXTRA"].DataPropertyName = "IDEXTRA";
            dataGridView1.Columns["PRECIO_EXTRA"].DataPropertyName = "PRECIO_EXTRA";


            MessageBox.Show("Se encontraron " + resultados.Rows.Count + " resultados.");

            // Mostrar los resultados en el DataGridView
            dataGridView1.DataSource = resultados;
        }

    }
}
