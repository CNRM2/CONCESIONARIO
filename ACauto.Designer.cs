namespace CONCESIONARIO
{
    partial class ACauto
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
            textBoxBastidor = new TextBox();
            textBoxNuevaMarca = new TextBox();
            textBoxNuevoPrecio = new TextBox();
            textBoxNuevoModelo = new TextBox();
            button2 = new Button();
            comboBoxAutos = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCaracteristicas = new TextBox();
            label7 = new Label();
            txtVendedor = new TextBox();
            SuspendLayout();
            // 
            // textBoxBastidor
            // 
            textBoxBastidor.Location = new Point(263, 80);
            textBoxBastidor.Name = "textBoxBastidor";
            textBoxBastidor.Size = new Size(125, 27);
            textBoxBastidor.TabIndex = 0;
            // 
            // textBoxNuevaMarca
            // 
            textBoxNuevaMarca.Location = new Point(416, 80);
            textBoxNuevaMarca.Name = "textBoxNuevaMarca";
            textBoxNuevaMarca.Size = new Size(125, 27);
            textBoxNuevaMarca.TabIndex = 1;
            // 
            // textBoxNuevoPrecio
            // 
            textBoxNuevoPrecio.Location = new Point(416, 151);
            textBoxNuevoPrecio.Name = "textBoxNuevoPrecio";
            textBoxNuevoPrecio.Size = new Size(125, 27);
            textBoxNuevoPrecio.TabIndex = 2;
            // 
            // textBoxNuevoModelo
            // 
            textBoxNuevoModelo.Location = new Point(569, 80);
            textBoxNuevoModelo.Name = "textBoxNuevoModelo";
            textBoxNuevoModelo.Size = new Size(125, 27);
            textBoxNuevoModelo.TabIndex = 3;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(431, 215);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBoxAutos
            // 
            comboBoxAutos.FormattingEnabled = true;
            comboBoxAutos.Location = new Point(51, 80);
            comboBoxAutos.Name = "comboBoxAutos";
            comboBoxAutos.Size = new Size(167, 28);
            comboBoxAutos.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 57);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 9;
            label1.Text = "Seleccionar Modelo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(286, 57);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 10;
            label2.Text = "N.Bastidor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(609, 57);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 11;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(452, 128);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 12;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(455, 57);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 13;
            label5.Text = "Marca";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(273, 128);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 15;
            label6.Text = "Caracteristicas";
            // 
            // txtCaracteristicas
            // 
            txtCaracteristicas.Location = new Point(263, 151);
            txtCaracteristicas.Name = "txtCaracteristicas";
            txtCaracteristicas.Size = new Size(125, 27);
            txtCaracteristicas.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(582, 128);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 17;
            label7.Text = "INE Vendedor";
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(569, 151);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(125, 27);
            txtVendedor.TabIndex = 16;
            // 
            // ACauto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_bggenerator_com;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(txtVendedor);
            Controls.Add(label6);
            Controls.Add(txtCaracteristicas);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxAutos);
            Controls.Add(button2);
            Controls.Add(textBoxNuevoModelo);
            Controls.Add(textBoxNuevoPrecio);
            Controls.Add(textBoxNuevaMarca);
            Controls.Add(textBoxBastidor);
            Name = "ACauto";
            Text = "ACauto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxBastidor;
        private TextBox textBoxNuevaMarca;
        private TextBox textBoxNuevoPrecio;
        private TextBox textBoxNuevoModelo;
        private Button button2;
        private ComboBox comboBoxAutos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCaracteristicas;
        private Label label7;
        private TextBox txtVendedor;
    }
}