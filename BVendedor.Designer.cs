namespace CONCESIONARIO
{
    partial class BVendedor
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
            Button1 = new Button();
            textBoxINE = new TextBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            INE = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            DOMICILIO = new DataGridViewTextBoxColumn();
            LUGARTRABAJO = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Button1.Location = new Point(82, 139);
            Button1.Name = "Button1";
            Button1.Size = new Size(94, 29);
            Button1.TabIndex = 0;
            Button1.Text = "Buscar";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click_1;
            // 
            // textBoxINE
            // 
            textBoxINE.Location = new Point(66, 93);
            textBoxINE.Name = "textBoxINE";
            textBoxINE.Size = new Size(125, 27);
            textBoxINE.TabIndex = 1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(516, 198);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { INE, NOMBRE, DOMICILIO, LUGARTRABAJO });
            dataGridView1.Location = new Point(228, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(675, 75);
            dataGridView1.TabIndex = 3;
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
            NOMBRE.Width = 150;
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
            LUGARTRABAJO.HeaderText = "LUGARTRABAJO";
            LUGARTRABAJO.MinimumWidth = 6;
            LUGARTRABAJO.Name = "LUGARTRABAJO";
            LUGARTRABAJO.ReadOnly = true;
            LUGARTRABAJO.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(76, 67);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 4;
            label1.Text = "Ingresar INE";
            label1.Click += label1_Click;
            // 
            // BVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_bggenerator_com;
            ClientSize = new Size(977, 450);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(textBoxINE);
            Controls.Add(Button1);
            Name = "BVendedor";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button1;
        private TextBox textBoxINE;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn INE;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn DOMICILIO;
        private DataGridViewTextBoxColumn LUGARTRABAJO;
        private Label label1;
    }
}