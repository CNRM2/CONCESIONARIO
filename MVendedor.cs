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

namespace CONCESIONARIO
{
    public partial class MVendedor : Form
    {
        private Conexion conexion;
        private List<Vendedor> vendedores; // Lista de vendedores
        public MVendedor()
        {
            InitializeComponent();
            conexion = new Conexion();
            CargarComboBoxVendedores();
        }

        private void CargarComboBoxVendedores()
        {
            vendedores = conexion.ObtenerVendedores(); // Obtener la lista de vendedores desde la base de datos

            // Configurar el ComboBox con la lista de vendedores
            comboBoxVendedores.DisplayMember = "NOMBRE"; // Mostrar el nombre del vendedor en el ComboBox
            comboBoxVendedores.DataSource = vendedores;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int INE = int.Parse(textBoxINE.Text);
                string nuevoNombre = textBoxNombre.Text;
                string nuevoDomicilio = textBoxDomicilio.Text;
                string nuevoLugarTrabajo = comboBoxLugarTrabajo.SelectedItem.ToString();

                bool actualizado = conexion.ActualizarVendedor(INE, nuevoNombre, nuevoDomicilio, nuevoLugarTrabajo);

                if (actualizado)
                {
                    MessageBox.Show("Datos del vendedor actualizados correctamente.");
                    // Puedes añadir aquí alguna lógica adicional luego de actualizar
                }
                else
                {
                    MessageBox.Show("Error al actualizar los datos del vendedor.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un valor válido para el INE.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBoxVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVendedores.SelectedItem != null)
            {
                // Obtener el vendedor seleccionado del ComboBox
                Vendedor vendedorSeleccionado = (Vendedor)comboBoxVendedores.SelectedItem;

                // Mostrar los detalles del vendedor en las TextBoxes y ComboBox
                textBoxINE.Text = vendedorSeleccionado.INE.ToString();
                textBoxNombre.Text = vendedorSeleccionado.NOMBRE;
                textBoxDomicilio.Text = vendedorSeleccionado.DOMICILIO;

                // Seleccionar el lugar de trabajo en el ComboBox
                if (vendedorSeleccionado.LUGARTRABAJO == "CONCESIONARIA")
                    comboBoxLugarTrabajo.SelectedIndex = 0;
                else if (vendedorSeleccionado.LUGARTRABAJO == "TIENDAOF")
                    comboBoxLugarTrabajo.SelectedIndex = 1;
            }
        }
    }
}
