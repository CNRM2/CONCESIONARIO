namespace CONCESIONARIO
{
    partial class VendedorInfo
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
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            INE = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            DOMICILIO = new DataGridViewTextBoxColumn();
            LUGARTRABAJO = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(104, 199);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { INE, NOMBRE, DOMICILIO, LUGARTRABAJO });
            dataGridView1.Location = new Point(312, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(725, 105);
            dataGridView1.TabIndex = 2;
            // 
            // INE
            // 
            INE.HeaderText = "INE";
            INE.MinimumWidth = 6;
            INE.Name = "INE";
            INE.ReadOnly = true;
            INE.Width = 125;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.MinimumWidth = 6;
            NOMBRE.Name = "NOMBRE";
            NOMBRE.ReadOnly = true;
            NOMBRE.Width = 200;
            // 
            // DOMICILIO
            // 
            DOMICILIO.HeaderText = "DOMICILIO";
            DOMICILIO.MinimumWidth = 6;
            DOMICILIO.Name = "DOMICILIO";
            DOMICILIO.ReadOnly = true;
            DOMICILIO.Width = 200;
            // 
            // LUGARTRABAJO
            // 
            LUGARTRABAJO.HeaderText = "LUGAR DE TRABAJO";
            LUGARTRABAJO.MinimumWidth = 6;
            LUGARTRABAJO.Name = "LUGARTRABAJO";
            LUGARTRABAJO.ReadOnly = true;
            LUGARTRABAJO.Width = 150;
            // 
            // VendedorInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_bggenerator_com;
            ClientSize = new Size(1113, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "VendedorInfo";
            Text = "VendedorInfo";
            Load += VendedorInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn INE;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn DOMICILIO;
        private DataGridViewTextBoxColumn LUGARTRABAJO;
    }
}