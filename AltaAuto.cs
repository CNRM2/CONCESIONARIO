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
    public partial class AltaAuto : Form
    {
        private Conexion con;
        public AltaAuto()
        {
            InitializeComponent();
            con = new Conexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InsertarAuto())
            {
                MessageBox.Show("Datos insertados correctamente.");
            }
            else
            {
                MessageBox.Show("Error al insertar los datos.");
            }

        }

        private bool InsertarAuto()
        {
            try
            {
                int Bastidor = int.Parse(txtBastidor.Text); // Convertir el valor del INE a int
                string marca = txtMarca.Text;
                string modelo = txtModelo.Text;
                string caracteristicas = txtCaracteristicas.Text;
                decimal precio = decimal.Parse(txtPrecio.Text);
                string vendedor = txtVendedor.Text;

                return con.InsertarAuto(Bastidor, marca, modelo, precio, caracteristicas, vendedor);
            }
            catch (FormatException)
            {
                MessageBox.Show("El Bastidor debe de ser un numero valido");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void AltaAuto_Load(object sender, EventArgs e)
        {

        }
    }
}
