namespace CapaPresentacion.Formularios
{
    partial class VerPlanCompletoInfo
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
            label6 = new Label();
            lblDifObjetivo = new Label();
            lblDiasEnCompletar = new Label();
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
            panel5.Size = new Size(10, 360);
            panel5.TabIndex = 92;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 50, 94);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(729, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 360);
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
            panel3.Location = new Point(10, 350);
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
            label1.Location = new Point(264, 51);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 97;
            label1.Text = "¡Más información!";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(128, 139);
            label6.Name = "label6";
            label6.Size = new Size(358, 23);
            label6.TabIndex = 103;
            label6.Text = "Para completar este plan, tardaste";
            // 
            // lblDifObjetivo
            // 
            lblDifObjetivo.AutoSize = true;
            lblDifObjetivo.Font = new Font("Century Gothic", 15F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lblDifObjetivo.Location = new Point(191, 221);
            lblDifObjetivo.Name = "lblDifObjetivo";
            lblDifObjetivo.Size = new Size(353, 23);
            lblDifObjetivo.TabIndex = 104;
            lblDifObjetivo.Text = "25 días antes de la fecha objetivo.";
            // 
            // lblDiasEnCompletar
            // 
            lblDiasEnCompletar.AutoSize = true;
            lblDiasEnCompletar.Font = new Font("Century Gothic", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblDiasEnCompletar.Location = new Point(516, 139);
            lblDiasEnCompletar.Name = "lblDiasEnCompletar";
            lblDiasEnCompletar.Size = new Size(84, 23);
            lblDiasEnCompletar.TabIndex = 105;
            lblDiasEnCompletar.Text = "30 días.";
            // 
            // VerPlanCompletoInfo
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(739, 360);
            Controls.Add(lblDiasEnCompletar);
            Controls.Add(lblDifObjetivo);
            Controls.Add(label6);
            Controls.Add(btnCerrar);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerPlanCompletoInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_AddWork";
            Load += VerPlanCompletoInfo_Load;
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
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPageNo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMBNo;
        private System.Windows.Forms.Label lblDifObjetivo;
        private System.Windows.Forms.ComboBox cmbHOA;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtImporte;
        private Krypton.Toolkit.KryptonDateTimePicker dpFecha;
        private BindingSource categoriaBindingSource;
        private Button btnCerrar;
        private Label lblDiasEnCompletar;
        //private DragControlDemo.DragControl dragControl1;
    }
}