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
    public partial class ACauto : Form
    {
        private Conexion conexion;
        private List<Automovil> automoviles;
        public ACauto()
        {
            InitializeComponent();
            conexion = new Conexion(); // Inicializa la instancia de la clase Conexion
            CargarComboBoxAutos(); // Carga los autos en la ComboBox al iniciar el formulario
            comboBoxAutos.SelectedIndexChanged += comboBoxAutos_SelectedIndexChanged;
        }

        private void CargarComboBoxAutos()
        {
            // Obtener la lista de autos disponibles desde tu base de datos
            automoviles = conexion.ObtenerAutomoviles();

            // Asignar la lista de autos a la ComboBox
            comboBoxAutos.DataSource = automoviles;
            comboBoxAutos.DisplayMember = "MODELO"; // Propiedad que contiene el nombre del auto completo
            comboBoxAutos.ValueMember = "BASTIDOR"; // Propiedad que es el valor único del auto
        }

        private void comboBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAutos.SelectedItem != null)
            {
                Automovil autoSeleccionado = (Automovil)comboBoxAutos.SelectedItem;

                // Mostrar los detalles del auto seleccionado en las TextBoxes
                textBoxBastidor.Text = autoSeleccionado.BASTIDOR.ToString();
                textBoxNuevaMarca.Text = autoSeleccionado.MARCA;
                textBoxNuevoModelo.Text = autoSeleccionado.MODELO;
                textBoxNuevoPrecio.Text = autoSeleccionado.PRECIO.ToString();
                txtCaracteristicas.Text = autoSeleccionado.CARACTERISTICAS;
                txtVendedor.Text = autoSeleccionado.VENDEDOR.ToString();
                // ... continúa con el resto de propiedades del auto que deseas mostrar
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxAutos.SelectedItem != null)
            {
                Automovil autoSeleccionado = (Automovil)comboBoxAutos.SelectedItem;

                // Obtener los nuevos valores de las TextBoxes
                int nuevoBastidor = int.Parse(textBoxBastidor.Text);
                string nuevaMarca = textBoxNuevaMarca.Text;
                string nuevoModelo = textBoxNuevoModelo.Text;
                decimal nuevoPrecio = decimal.Parse(textBoxNuevoPrecio.Text);
                string nuevaCaracteristica = txtCaracteristicas.Text;
                int nuevoVendedor = int.Parse(txtVendedor.Text);

                // Actualizar los datos del auto seleccionado con los nuevos valores
                autoSeleccionado.BASTIDOR = nuevoBastidor;
                autoSeleccionado.MARCA = nuevaMarca;
                autoSeleccionado.MODELO = nuevoModelo;
                autoSeleccionado.PRECIO = nuevoPrecio;
                autoSeleccionado.CARACTERISTICAS = nuevaCaracteristica;
                autoSeleccionado.VENDEDOR = nuevoVendedor;

                // Actualizar los datos en la base de datos llamando a un método de tu clase de conexión
                bool actualizado = conexion.ActualizarAutomovil(autoSeleccionado);

                if (actualizado)
                {
                    MessageBox.Show("Datos del automóvil actualizados correctamente.");
                    // Volver a cargar los datos en el ComboBox después de la actualización
                    CargarComboBoxAutos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar los datos del automóvil.");
                }
            }
        }
    }



}
