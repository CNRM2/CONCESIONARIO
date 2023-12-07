namespace CONCESIONARIO
{
    partial class ABMVendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLugarTrabajo = new ComboBox();
            txtINE = new TextBox();
            txtNombre = new TextBox();
            txtDomicilio = new TextBox();
            button1 = new Button();
            lbINE = new Label();
            lbNombre = new Label();
            lbDomicilio = new Label();
            lbLugarTrabajo = new Label();
            SuspendLayout();
            // 
            // txtLugarTrabajo
            // 
            txtLugarTrabajo.FlatStyle = FlatStyle.Flat;
            txtLugarTrabajo.FormattingEnabled = true;
            txtLugarTrabajo.Items.AddRange(new object[] { "TIENDAOF", "CONCESIONARIO" });
            txtLugarTrabajo.Location = new Point(398, 212);
            txtLugarTrabajo.Name = "txtLugarTrabajo";
            txtLugarTrabajo.Size = new Size(271, 28);
            txtLugarTrabajo.TabIndex = 0;
            txtLugarTrabajo.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // txtINE
            // 
            txtINE.BorderStyle = BorderStyle.FixedSingle;
            txtINE.Location = new Point(114, 134);
            txtINE.Name = "txtINE";
            txtINE.Size = new Size(238, 27);
            txtINE.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(398, 134);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(271, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtDomicilio
            // 
            txtDomicilio.BorderStyle = BorderStyle.FixedSingle;
            txtDomicilio.Location = new Point(97, 212);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(278, 27);
            txtDomicilio.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(290, 288);
            button1.Name = "button1";
            button1.Size = new Size(159, 45);
            button1.TabIndex = 4;
            button1.Text = "Agregar Vendedor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbINE
            // 
            lbINE.AutoSize = true;
            lbINE.BackColor = Color.Transparent;
            lbINE.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbINE.Location = new Point(114, 112);
            lbINE.Name = "lbINE";
            lbINE.Size = new Size(240, 23);
            lbINE.TabIndex = 5;
            lbINE.Text = "Ingresar el Numero de la INE";
            lbINE.Click += label1_Click;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.BackColor = Color.Transparent;
            lbNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbNombre.Location = new Point(403, 111);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(258, 23);
            lbNombre.TabIndex = 6;
            lbNombre.Text = "Ingresar Nombre del Vendedor";
            // 
            // lbDomicilio
            // 
            lbDomicilio.AutoSize = true;
            lbDomicilio.BackColor = Color.Transparent;
            lbDomicilio.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbDomicilio.Location = new Point(102, 186);
            lbDomicilio.Name = "lbDomicilio";
            lbDomicilio.Size = new Size(269, 23);
            lbDomicilio.TabIndex = 7;
            lbDomicilio.Text = "Ingresar Domicilio del Vendedor";
            // 
            // lbLugarTrabajo
            // 
            lbLugarTrabajo.AutoSize = true;
            lbLugarTrabajo.BackColor = Color.Transparent;
            lbLugarTrabajo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbLugarTrabajo.Location = new Point(429, 186);
            lbLugarTrabajo.Name = "lbLugarTrabajo";
            lbLugarTrabajo.Size = new Size(216, 23);
            lbLugarTrabajo.TabIndex = 8;
            lbLugarTrabajo.Text = "Ingresar Lugar de Trabajo";
            // 
            // ABMVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_bggenerator_com;
            ClientSize = new Size(800, 450);
            Controls.Add(lbLugarTrabajo);
            Controls.Add(lbDomicilio);
            Controls.Add(lbNombre);
            Controls.Add(lbINE);
            Controls.Add(button1);
            Controls.Add(txtDomicilio);
            Controls.Add(txtNombre);
            Controls.Add(txtINE);
            Controls.Add(txtLugarTrabajo);
            Name = "ABMVendedor";
            Text = "ABMVendedor";
            Load += ABMVendedor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox txtLugarTrabajo;
        private TextBox txtINE;
        private TextBox txtNombre;
        private TextBox txtDomicilio;
        private Button button1;
        private Label lbINE;
        private Label lbNombre;
        private Label lbDomicilio;
        private Label lbLugarTrabajo;
    }
}