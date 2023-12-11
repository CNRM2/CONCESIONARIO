namespace CONCESIONARIO
{
    partial class VentaInfo
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
            txtIDVenta = new TextBox();
            dataGridView1 = new DataGridView();
            IDVENTA = new DataGridViewTextBoxColumn();
            FECHA = new DataGridViewTextBoxColumn();
            METODOPAGO = new DataGridViewTextBoxColumn();
            STOCK = new DataGridViewTextBoxColumn();
            NOMBREVENDEDOR = new DataGridViewTextBoxColumn();
            BASTIDOR = new DataGridViewTextBoxColumn();
            MODELO = new DataGridViewTextBoxColumn();
            PRECIO_MODELO = new DataGridViewTextBoxColumn();
            IDEXTRA = new DataGridViewTextBoxColumn();
            PRECIO_EXTRA = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(563, 310);
            button1.Name = "button1";
            button1.Size = new Size(102, 42);
            button1.TabIndex = 0;
            button1.Text = "Buscar Venta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtIDVenta
            // 
            txtIDVenta.Location = new Point(552, 269);
            txtIDVenta.Name = "txtIDVenta";
            txtIDVenta.Size = new Size(125, 27);
            txtIDVenta.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDVENTA, FECHA, METODOPAGO, STOCK, NOMBREVENDEDOR, BASTIDOR, MODELO, PRECIO_MODELO, IDEXTRA, PRECIO_EXTRA });
            dataGridView1.Location = new Point(35, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1272, 153);
            dataGridView1.TabIndex = 2;
            // 
            // IDVENTA
            // 
            IDVENTA.HeaderText = "IDVENTA";
            IDVENTA.MinimumWidth = 6;
            IDVENTA.Name = "IDVENTA";
            IDVENTA.ReadOnly = true;
            IDVENTA.Width = 75;
            // 
            // FECHA
            // 
            FECHA.HeaderText = "FECHA";
            FECHA.MinimumWidth = 6;
            FECHA.Name = "FECHA";
            FECHA.ReadOnly = true;
            FECHA.Width = 125;
            // 
            // METODOPAGO
            // 
            METODOPAGO.HeaderText = "METODOPAGO";
            METODOPAGO.MinimumWidth = 6;
            METODOPAGO.Name = "METODOPAGO";
            METODOPAGO.ReadOnly = true;
            METODOPAGO.Width = 125;
            // 
            // STOCK
            // 
            STOCK.HeaderText = "STOCK";
            STOCK.MinimumWidth = 6;
            STOCK.Name = "STOCK";
            STOCK.ReadOnly = true;
            STOCK.Width = 125;
            // 
            // NOMBREVENDEDOR
            // 
            NOMBREVENDEDOR.HeaderText = "NOMBREVENDEDOR";
            NOMBREVENDEDOR.MinimumWidth = 6;
            NOMBREVENDEDOR.Name = "NOMBREVENDEDOR";
            NOMBREVENDEDOR.ReadOnly = true;
            NOMBREVENDEDOR.Width = 150;
            // 
            // BASTIDOR
            // 
            BASTIDOR.HeaderText = "BASTIDOR";
            BASTIDOR.MinimumWidth = 6;
            BASTIDOR.Name = "BASTIDOR";
            BASTIDOR.ReadOnly = true;
            BASTIDOR.Width = 125;
            // 
            // MODELO
            // 
            MODELO.HeaderText = "MODELO";
            MODELO.MinimumWidth = 6;
            MODELO.Name = "MODELO";
            MODELO.ReadOnly = true;
            MODELO.Width = 125;
            // 
            // PRECIO_MODELO
            // 
            PRECIO_MODELO.HeaderText = "PRECIO MODELO";
            PRECIO_MODELO.MinimumWidth = 6;
            PRECIO_MODELO.Name = "PRECIO_MODELO";
            PRECIO_MODELO.ReadOnly = true;
            PRECIO_MODELO.Width = 125;
            // 
            // IDEXTRA
            // 
            IDEXTRA.HeaderText = "IDEXTRA";
            IDEXTRA.MinimumWidth = 6;
            IDEXTRA.Name = "IDEXTRA";
            IDEXTRA.ReadOnly = true;
            IDEXTRA.Width = 125;
            // 
            // PRECIO_EXTRA
            // 
            PRECIO_EXTRA.HeaderText = "PRECIOEXTRA";
            PRECIO_EXTRA.MinimumWidth = 6;
            PRECIO_EXTRA.Name = "PRECIO_EXTRA";
            PRECIO_EXTRA.ReadOnly = true;
            PRECIO_EXTRA.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(508, 243);
            label1.Name = "label1";
            label1.Size = new Size(228, 23);
            label1.TabIndex = 3;
            label1.Text = "INGRESAR ID DE LA VENTA";
            // 
            // VentaInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_bggenerator_com;
            ClientSize = new Size(1335, 484);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(txtIDVenta);
            Controls.Add(button1);
            Name = "VentaInfo";
            Text = "VentaInfo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtIDVenta;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IDVENTA;
        private DataGridViewTextBoxColumn FECHA;
        private DataGridViewTextBoxColumn METODOPAGO;
        private DataGridViewTextBoxColumn STOCK;
        private DataGridViewTextBoxColumn NOMBREVENDEDOR;
        private DataGridViewTextBoxColumn BASTIDOR;
        private DataGridViewTextBoxColumn MODELO;
        private DataGridViewTextBoxColumn PRECIO_MODELO;
        private DataGridViewTextBoxColumn IDEXTRA;
        private DataGridViewTextBoxColumn PRECIO_EXTRA;
        private Label label1;
    }
}