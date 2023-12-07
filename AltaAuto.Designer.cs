namespace CONCESIONARIO
{
    partial class AltaAuto
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
            button1 = new Button();
            txtBastidor = new TextBox();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtPrecio = new TextBox();
            txtCaracteristicas = new TextBox();
            txtVendedor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(321, 307);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 0;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBastidor
            // 
            txtBastidor.Location = new Point(154, 141);
            txtBastidor.Name = "txtBastidor";
            txtBastidor.Size = new Size(125, 27);
            txtBastidor.TabIndex = 1;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(322, 141);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(125, 27);
            txtMarca.TabIndex = 2;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(485, 141);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(125, 27);
            txtModelo.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(154, 221);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 4;
            // 
            // txtCaracteristicas
            // 
            txtCaracteristicas.Location = new Point(302, 221);
            txtCaracteristicas.Name = "txtCaracteristicas";
            txtCaracteristicas.Size = new Size(157, 27);
            txtCaracteristicas.TabIndex = 5;
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(485, 221);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(125, 27);
            txtVendedor.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(166, 115);
            label1.Name = "label1";
            label1.Size = new Size(105, 23);
            label1.TabIndex = 7;
            label1.Text = "No.Bastidor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(358, 118);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 8;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(511, 118);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 9;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(322, 198);
            label4.Name = "label4";
            label4.Size = new Size(125, 23);
            label4.TabIndex = 10;
            label4.Text = "Caracteristicas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(190, 198);
            label5.Name = "label5";
            label5.Size = new Size(59, 23);
            label5.TabIndex = 11;
            label5.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(488, 198);
            label6.Name = "label6";
            label6.Size = new Size(119, 23);
            label6.TabIndex = 12;
            label6.Text = "Vendedor INE";
            // 
            // AltaAuto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_bggenerator_com;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtVendedor);
            Controls.Add(txtCaracteristicas);
            Controls.Add(txtPrecio);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(txtBastidor);
            Controls.Add(button1);
            Name = "AltaAuto";
            Text = "AltaAuto";
            Load += AltaAuto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtBastidor;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtPrecio;
        private TextBox txtCaracteristicas;
        private TextBox txtVendedor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}