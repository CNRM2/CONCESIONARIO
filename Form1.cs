using CONCESIONARIO.DAL;
using System;
using System.Windows.Forms;

namespace CONCESIONARIO
{
    public partial class Form1 : Form
    {
        private Conexion con;

        public Form1()
        {
            InitializeComponent();
            con = new Conexion();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ABMVendedor abmVendedorForm = new ABMVendedor(); // Crear una instancia del formulario ABMVendedor
            abmVendedorForm.FormClosed += MostrarFormPrincipal; // Suscribir al evento FormClosed
            abmVendedorForm.Show(); // Mostrar el formulario ABMVendedor
            this.Hide(); // Ocultar el formulario actual (Form1)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VendedorInfo VendedorInfoForm = new VendedorInfo(); // Crear una instancia del formulario ABMVendedor
            VendedorInfoForm.FormClosed += MostrarFormPrincipal; // Suscribir al evento FormClosed
            VendedorInfoForm.Show(); // Mostrar el formulario ABMVendedor
            this.Hide(); // Ocultar el formulario actual (Form1)
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AutomovilInfo AutoMovilInfoForm = new AutomovilInfo(); // Crear una instancia del formulario ABMVendedor
            AutoMovilInfoForm.FormClosed += MostrarFormPrincipal; // Suscribir al evento FormClosed
            AutoMovilInfoForm.Show(); // Mostrar el formulario ABMVendedor

            this.Hide(); // Ocultar el formulario actual (Form1)

        }

        private void MostrarFormPrincipal(object sender, FormClosedEventArgs e)
        {
            this.Show(); // Mostrar nuevamente el formulario principal cuando ABMVendedor se cierra
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SimuladorCompra SimilarCompraForm = new SimuladorCompra(); // Crear una instancia del formulario ABMVendedor
            SimilarCompraForm.FormClosed += MostrarFormPrincipal; // Suscribir al evento FormClosed
            SimilarCompraForm.Show(); // Mostrar el formulario ABMVendedor

            this.Hide(); // Ocultar el formulario actual (Form1)

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ACauto ACautoForm = new ACauto(); // Crear una instancia del formulario ABMVendedor
            ACautoForm.FormClosed += MostrarFormPrincipal; // Suscribir al evento FormClosed
            ACautoForm.Show(); // Mostrar el formulario ABMVendedor

            this.Hide(); // Ocultar el formulario actual (Form1)
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BAauto BAautoForm = new BAauto(); // Crear una instancia del formulario ABMVendedor
            BAautoForm.FormClosed += MostrarFormPrincipal; // Suscribir al evento FormClosed
            BAautoForm.Show(); // Mostrar el formulario ABMVendedor

            this.Hide(); // Ocultar el formulario actual (Form1)
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AltaAuto AltaautoForm = new AltaAuto(); // Crear una instancia del formulario ABMVendedor
            AltaautoForm.FormClosed += MostrarFormPrincipal; // Suscribir al evento FormClosed
            AltaautoForm.Show(); // Mostrar el formulario ABMVendedor

            this.Hide(); // Ocultar el formulario actual (Form1)
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MVendedor MVendedorForm = new MVendedor(); // Crear una instancia del formulario ABMVendedor
            MVendedorForm.FormClosed += MostrarFormPrincipal; // Suscribir al evento FormClosed
            MVendedorForm.Show(); // Mostrar el formulario ABMVendedor

            this.Hide(); // Ocultar el formulario actual (Form1)
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BVendedor BVendedorForm = new BVendedor(); // Crear una instancia del formulario ABMVendedor
            BVendedorForm.FormClosed += MostrarFormPrincipal; // Suscribir al evento FormClosed
            BVendedorForm.Show(); // Mostrar el formulario ABMVendedor

            this.Hide(); // Ocultar el formulario actual (Form1)
        }
    }
}