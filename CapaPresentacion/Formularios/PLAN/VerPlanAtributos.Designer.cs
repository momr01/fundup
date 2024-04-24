namespace CapaPresentacion.Formularios.PLAN
{
    partial class VerPlanAtributos
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
            components = new System.ComponentModel.Container();
            panel5 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            categoriaBindingSource = new BindingSource(components);
            btnCerrar = new Button();
            txtFechaCompleto = new Label();
            lblFechaCompleto = new Label();
            lblCapital = new Label();
            label9 = new Label();
            lblFechaFin = new Label();
            label6 = new Label();
            lblFechaInicio = new Label();
            label2 = new Label();
            lblDescripcion = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 50, 94);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 406);
            panel5.TabIndex = 92;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 50, 94);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(729, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 406);
            panel1.TabIndex = 93;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 50, 94);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(719, 10);
            panel2.TabIndex = 94;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 50, 94);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(10, 396);
            panel3.Name = "panel3";
            panel3.Size = new Size(719, 10);
            panel3.TabIndex = 95;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.fundupn;
            pictureBox2.Location = new Point(10, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 96;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(257, 32);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 97;
            label1.Text = "Más información";
            // 
            // categoriaBindingSource
            // 
            categoriaBindingSource.DataSource = typeof(Entidades.Categoria);
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.FromArgb(30, 50, 94);
            btnCerrar.Location = new Point(631, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(98, 64);
            btnCerrar.TabIndex = 98;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtFechaCompleto
            // 
            txtFechaCompleto.Anchor = AnchorStyles.None;
            txtFechaCompleto.AutoSize = true;
            txtFechaCompleto.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtFechaCompleto.ForeColor = Color.FromArgb(64, 64, 64);
            txtFechaCompleto.Location = new Point(329, 316);
            txtFechaCompleto.Name = "txtFechaCompleto";
            txtFechaCompleto.Size = new Size(0, 18);
            txtFechaCompleto.TabIndex = 149;
            // 
            // lblFechaCompleto
            // 
            lblFechaCompleto.Anchor = AnchorStyles.None;
            lblFechaCompleto.AutoSize = true;
            lblFechaCompleto.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaCompleto.ForeColor = Color.FromArgb(64, 64, 64);
            lblFechaCompleto.Location = new Point(92, 316);
            lblFechaCompleto.Name = "lblFechaCompleto";
            lblFechaCompleto.Size = new Size(163, 18);
            lblFechaCompleto.TabIndex = 148;
            lblFechaCompleto.Text = "Fecha de resolución:";
            // 
            // lblCapital
            // 
            lblCapital.Anchor = AnchorStyles.None;
            lblCapital.AutoSize = true;
            lblCapital.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCapital.ForeColor = Color.FromArgb(64, 64, 64);
            lblCapital.Location = new Point(329, 261);
            lblCapital.Name = "lblCapital";
            lblCapital.Size = new Size(0, 18);
            lblCapital.TabIndex = 147;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(92, 261);
            label9.Name = "label9";
            label9.Size = new Size(130, 18);
            label9.TabIndex = 146;
            label9.Text = "Capital objetivo:";
            // 
            // lblFechaFin
            // 
            lblFechaFin.Anchor = AnchorStyles.None;
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaFin.ForeColor = Color.FromArgb(64, 64, 64);
            lblFechaFin.Location = new Point(329, 207);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(0, 18);
            lblFechaFin.TabIndex = 145;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(92, 207);
            label6.Name = "label6";
            label6.Size = new Size(122, 18);
            label6.TabIndex = 144;
            label6.Text = "Fecha objetivo:";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.Anchor = AnchorStyles.None;
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaInicio.ForeColor = Color.FromArgb(64, 64, 64);
            lblFechaInicio.Location = new Point(329, 153);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(0, 18);
            lblFechaInicio.TabIndex = 143;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(92, 153);
            label2.Name = "label2";
            label2.Size = new Size(127, 18);
            label2.TabIndex = 142;
            label2.Text = "Fecha de inicio:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.None;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            lblDescripcion.Location = new Point(329, 105);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(0, 18);
            lblDescripcion.TabIndex = 141;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(92, 105);
            label4.Name = "label4";
            label4.Size = new Size(101, 18);
            label4.TabIndex = 140;
            label4.Text = "Descripción:";
            // 
            // VerPlanAtributos
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(739, 406);
            Controls.Add(txtFechaCompleto);
            Controls.Add(lblFechaCompleto);
            Controls.Add(lblCapital);
            Controls.Add(label9);
            Controls.Add(lblFechaFin);
            Controls.Add(label6);
            Controls.Add(lblFechaInicio);
            Controls.Add(label2);
            Controls.Add(lblDescripcion);
            Controls.Add(label4);
            Controls.Add(btnCerrar);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerPlanAtributos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_AddWork";
            Load += VerPlanAtributos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTitle;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTsNo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTsAmount;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPageNo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMBNo;
        private System.Windows.Forms.ComboBox cmbHOA;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtImporte;
        private Krypton.Toolkit.KryptonDateTimePicker dpFecha;
        private BindingSource categoriaBindingSource;
        private Button btnCerrar;
        private Label txtFechaCompleto;
        private Label lblFechaCompleto;
        private Label lblCapital;
        private Label label9;
        private Label lblFechaFin;
        private Label label6;
        private Label lblFechaInicio;
        private Label label2;
        private Label lblDescripcion;
        private Label label4;
        //private DragControlDemo.DragControl dragControl1;
    }
}