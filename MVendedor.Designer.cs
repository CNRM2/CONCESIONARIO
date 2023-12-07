namespace CONCESIONARIO
{
    partial class MVendedor
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
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBoxVendedores = new ComboBox();
            button2 = new Button();
            textBoxDomicilio = new TextBox();
            textBoxNombre = new TextBox();
            textBoxINE = new TextBox();
            comboBoxLugarTrabajo = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(519, 122);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 28;
            label5.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(346, 198);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 26;
            label3.Text = "Domicilio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(331, 122);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 25;
            label2.Text = "INE Vendedor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(116, 122);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 24;
            label1.Text = "Seleccionar Vendedor";
            // 
            // comboBoxVendedores
            // 
            comboBoxVendedores.FormattingEnabled = true;
            comboBoxVendedores.Location = new Point(110, 145);
            comboBoxVendedores.Name = "comboBoxVendedores";
            comboBoxVendedores.Size = new Size(167, 28);
            comboBoxVendedores.TabIndex = 23;
            comboBoxVendedores.SelectedIndexChanged += comboBoxVendedores_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(421, 346);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 22;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxDomicilio
            // 
            textBoxDomicilio.Location = new Point(322, 221);
            textBoxDomicilio.Name = "textBoxDomicilio";
            textBoxDomicilio.Size = new Size(304, 27);
            textBoxDomicilio.TabIndex = 21;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(475, 145);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(151, 27);
            textBoxNombre.TabIndex = 19;
            // 
            // textBoxINE
            // 
            textBoxINE.Location = new Point(322, 145);
            textBoxINE.Name = "textBoxINE";
            textBoxINE.Size = new Size(125, 27);
            textBoxINE.TabIndex = 18;
            // 
            // comboBoxLugarTrabajo
            // 
            comboBoxLugarTrabajo.FormattingEnabled = true;
            comboBoxLugarTrabajo.Items.AddRange(new object[] { "CONCESIONARIO", "TIENDAOF" });
            comboBoxLugarTrabajo.Location = new Point(392, 284);
            comboBoxLugarTrabajo.Name = "comboBoxLugarTrabajo";
            comboBoxLugarTrabajo.Size = new Size(151, 28);
            comboBoxLugarTrabajo.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(404, 261);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 30;
            label4.Text = "Lugar de Trabajo";
            // 
            // MVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_bggenerator_com;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(comboBoxLugarTrabajo);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxVendedores);
            Controls.Add(button2);
            Controls.Add(textBoxDomicilio);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxINE);
            Name = "MVendedor";
            Text = "MVendedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxVendedores;
        private Button button2;
        private TextBox textBoxDomicilio;
        private TextBox textBoxNombre;
        private TextBox textBoxINE;
        private ComboBox comboBoxLugarTrabajo;
        private Label label4;
    }
}