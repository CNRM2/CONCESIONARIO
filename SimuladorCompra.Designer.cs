namespace CONCESIONARIO
{
    partial class SimuladorCompra
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
            comboBoxAutomoviles = new ComboBox();
            labelTotal = new Label();
            labelPrecioAuto = new Label();
            buttonAgregarExtra = new Button();
            checkedListBoxExtras = new CheckedListBox();
            reiniciar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // comboBoxAutomoviles
            // 
            comboBoxAutomoviles.FormattingEnabled = true;
            comboBoxAutomoviles.Location = new Point(312, 116);
            comboBoxAutomoviles.Name = "comboBoxAutomoviles";
            comboBoxAutomoviles.Size = new Size(164, 28);
            comboBoxAutomoviles.TabIndex = 0;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(613, 275);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(0, 20);
            labelTotal.TabIndex = 2;
            // 
            // labelPrecioAuto
            // 
            labelPrecioAuto.AutoSize = true;
            labelPrecioAuto.Location = new Point(413, 163);
            labelPrecioAuto.Name = "labelPrecioAuto";
            labelPrecioAuto.Size = new Size(0, 20);
            labelPrecioAuto.TabIndex = 3;
            // 
            // buttonAgregarExtra
            // 
            buttonAgregarExtra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAgregarExtra.Location = new Point(134, 116);
            buttonAgregarExtra.Name = "buttonAgregarExtra";
            buttonAgregarExtra.Size = new Size(116, 41);
            buttonAgregarExtra.TabIndex = 4;
            buttonAgregarExtra.Text = "Simular";
            buttonAgregarExtra.UseVisualStyleBackColor = true;
            buttonAgregarExtra.Click += buttonAgregarExtra_Click_1;
            // 
            // checkedListBoxExtras
            // 
            checkedListBoxExtras.BorderStyle = BorderStyle.FixedSingle;
            checkedListBoxExtras.FormattingEnabled = true;
            checkedListBoxExtras.Location = new Point(510, 116);
            checkedListBoxExtras.Name = "checkedListBoxExtras";
            checkedListBoxExtras.Size = new Size(197, 112);
            checkedListBoxExtras.TabIndex = 5;
            checkedListBoxExtras.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // reiniciar
            // 
            reiniciar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            reiniciar.Location = new Point(134, 189);
            reiniciar.Name = "reiniciar";
            reiniciar.Size = new Size(116, 41);
            reiniciar.TabIndex = 6;
            reiniciar.Text = "Reiniciar";
            reiniciar.UseVisualStyleBackColor = true;
            reiniciar.Click += reiniciar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(313, 93);
            label1.Name = "label1";
            label1.Size = new Size(166, 23);
            label1.TabIndex = 7;
            label1.Text = "Seleccionar Modelo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(531, 93);
            label2.Name = "label2";
            label2.Size = new Size(153, 23);
            label2.TabIndex = 8;
            label2.Text = "Seleccionar Extras";
            // 
            // SimuladorCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_bggenerator_com;
            ClientSize = new Size(834, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(reiniciar);
            Controls.Add(checkedListBoxExtras);
            Controls.Add(buttonAgregarExtra);
            Controls.Add(labelPrecioAuto);
            Controls.Add(labelTotal);
            Controls.Add(comboBoxAutomoviles);
            Name = "SimuladorCompra";
            Text = "SimuladorCompra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxAutomoviles;
        private Label labelTotal;
        private Label labelPrecioAuto;
        private Button buttonAgregarExtra;
        public CheckedListBox checkedListBoxExtras;
        private Button reiniciar;
        private Label label1;
        private Label label2;
    }
}