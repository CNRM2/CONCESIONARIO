using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONCESIONARIO.DAL;

namespace CONCESIONARIO
{

    public partial class ABMVendedor : Form
    {
        private Conexion con;
        public ABMVendedor()
        {
            InitializeComponent();
            con = new Conexion();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ABMVendedor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InsertarVendedor())
            {
                MessageBox.Show("Datos insertados correctamente.");
            }
            else
            {
                MessageBox.Show("Error al insertar los datos.");
            }
        }
        private bool InsertarVendedor()
        {
            try
            {
                int INE = int.Parse(txtINE.Text); // Convertir el valor del INE a int
                string nombre = txtNombre.Text;
                string domicilio = txtDomicilio.Text;
                string lugarTrabajo = txtLugarTrabajo.Text;

                return con.InsertarVendedor(INE, nombre, domicilio, lugarTrabajo);
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor del INE debe ser un número válido.");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
