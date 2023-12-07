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
    public partial class SimuladorCompra : Form
    {

        private Conexion conexion;
        private List<Automovil> automoviles;
        private List<Extra> extras;
        private decimal total;

        public SimuladorCompra()
        {
            InitializeComponent();
            conexion = new Conexion();
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Obtener automóviles y extras desde la base de datos
            automoviles = conexion.ObtenerAutomoviles();
            extras = conexion.ObtenerExtras();

            // Cargar ComboBox de automóviles
            comboBoxAutomoviles.DataSource = automoviles;
            comboBoxAutomoviles.DisplayMember = "MODELO"; // Mostrar la marca en el ComboBox
            comboBoxAutomoviles.ValueMember = "BASTIDOR"; // Usar el número de bastidor como valor

            /* Cargar ComboBox de extras
            comboBoxExtras.DataSource = extras;
            comboBoxExtras.DisplayMember = "NOMBREEXTRA"; // Mostrar el nombre del extra en el ComboBox
            comboBoxExtras.ValueMember = "IDEXTRA"; // Usar el Id del extra como valor
            */
            checkedListBoxExtras.DataSource = extras;
            checkedListBoxExtras.DisplayMember = "NOMBREEXTRA"; // Nombre de la propiedad del extra que se mostrará
            checkedListBoxExtras.ValueMember = "IDEXTRA"; // Valor que se obtendrá al seleccionar un extra
        }

        private void comboBoxAutomoviles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mostrar el precio del automóvil seleccionado
            if (comboBoxAutomoviles.SelectedItem != null)
            {
                Automovil automovilSeleccionado = (Automovil)comboBoxAutomoviles.SelectedItem;
                labelPrecioAuto.Text = automovilSeleccionado.PRECIO.ToString("C");
                CalcularTotal();
            }
        }

        /*private void comboBoxExtras_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Agregar el precio del extra seleccionado al total
            if (comboBoxExtras.SelectedItem != null)
            {
                Extra extraSeleccionado = (Extra)comboBoxExtras.SelectedItem;
                total += extraSeleccionado.PRECIOEXTRA;
                labelTotal.Text = total.ToString("C");
            }
        }*/

        private void CalcularTotal()
        {
            if (comboBoxAutomoviles.SelectedItem != null)
            {
                Automovil automovilSeleccionado = (Automovil)comboBoxAutomoviles.SelectedItem;
                total = automovilSeleccionado.PRECIO;
                labelTotal.Text = total.ToString("C");
            }
        }

        private void buttonAgregarExtra_Click_1(object sender, EventArgs e)
        {
            if (checkedListBoxExtras.CheckedItems.Count > 0 && comboBoxAutomoviles.SelectedItem != null)
            {
                Automovil automovilSeleccionado = (Automovil)comboBoxAutomoviles.SelectedItem;
                total = automovilSeleccionado.PRECIO;

                foreach (var item in checkedListBoxExtras.CheckedItems)
                {
                    Extra extraSeleccionado = (Extra)item;
                    total += extraSeleccionado.PRECIOEXTRA + automovilSeleccionado.PRECIO;
                }

                labelTotal.Text = total.ToString("C");
            }
        }

        private void ObtenerExtrasSeleccionados()
        {
            List<Extra> extrasSeleccionados = new List<Extra>();

            foreach (var item in checkedListBoxExtras.CheckedItems)
            {
                Extra extra = (Extra)item;
                extrasSeleccionados.Add(extra);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        // Método para formatear el texto del Label y devolver el total a 9
        private void FormatearYDevolverTotal()
        {
            // Formatear el texto del Label
            labelTotal.Text = total.ToString("C"); // Formatea el valor a formato de moneda

            // Devolver el total a 9
            total = 0;
        }

        private void reiniciar_Click(object sender, EventArgs e)
        {
            FormatearYDevolverTotal();
        }
    }
}
