namespace CapaPresentacion.UserControls
{
    partial class UC_Dashboard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Dashboard));
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            lblUltimaFecha = new Label();
            label4 = new Label();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            lblPlanes = new Label();
            label7 = new Label();
            panel3 = new Panel();
            pictureBox6 = new PictureBox();
            lblCategoriasGastos = new Label();
            label10 = new Label();
            panel_Cos = new Panel();
            pictureBox2 = new PictureBox();
            lblTotalGastos = new Label();
            label6 = new Label();
            panel_croc = new Panel();
            pictureBox3 = new PictureBox();
            lblCategoriasIngresos = new Label();
            label8 = new Label();
            panel_g = new Panel();
            pictureBox1 = new PictureBox();
            lblTotalIngresos = new Label();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            pictureBox7 = new PictureBox();
            lblResultado = new Label();
            label5 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel_Cos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_croc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel_g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Purple;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(lblUltimaFecha);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(341, 229);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 102);
            panel1.TabIndex = 9;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(165, 37);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(71, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // lblUltimaFecha
            // 
            lblUltimaFecha.AutoSize = true;
            lblUltimaFecha.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUltimaFecha.ForeColor = Color.White;
            lblUltimaFecha.Location = new Point(15, 51);
            lblUltimaFecha.Name = "lblUltimaFecha";
            lblUltimaFecha.Size = new Size(92, 23);
            lblUltimaFecha.TabIndex = 0;
            lblUltimaFecha.Text = "--/--/----";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 18);
            label4.Name = "label4";
            label4.Size = new Size(173, 19);
            label4.TabIndex = 0;
            label4.Text = "Fecha último registro:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.OrangeRed;
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(lblPlanes);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(637, 229);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 102);
            panel2.TabIndex = 10;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(163, 18);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(67, 59);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // lblPlanes
            // 
            lblPlanes.AutoSize = true;
            lblPlanes.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlanes.ForeColor = Color.White;
            lblPlanes.Location = new Point(41, 50);
            lblPlanes.Name = "lblPlanes";
            lblPlanes.Size = new Size(21, 23);
            lblPlanes.TabIndex = 0;
            lblPlanes.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 17);
            label7.Name = "label7";
            label7.Size = new Size(121, 19);
            label7.TabIndex = 0;
            label7.Text = "Planes activos:";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(lblCategoriasGastos);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(55, 229);
            panel3.Name = "panel3";
            panel3.Size = new Size(226, 102);
            panel3.TabIndex = 11;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(152, 17);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(71, 60);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // lblCategoriasGastos
            // 
            lblCategoriasGastos.AutoSize = true;
            lblCategoriasGastos.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoriasGastos.ForeColor = Color.White;
            lblCategoriasGastos.Location = new Point(32, 51);
            lblCategoriasGastos.Name = "lblCategoriasGastos";
            lblCategoriasGastos.Size = new Size(21, 23);
            lblCategoriasGastos.TabIndex = 0;
            lblCategoriasGastos.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(8, 17);
            label10.Name = "label10";
            label10.Size = new Size(151, 19);
            label10.TabIndex = 0;
            label10.Text = "Categorías Gastos:";
            // 
            // panel_Cos
            // 
            panel_Cos.Anchor = AnchorStyles.None;
            panel_Cos.BackColor = Color.Crimson;
            panel_Cos.Controls.Add(pictureBox2);
            panel_Cos.Controls.Add(lblTotalGastos);
            panel_Cos.Controls.Add(label6);
            panel_Cos.Location = new Point(341, 78);
            panel_Cos.Name = "panel_Cos";
            panel_Cos.Size = new Size(236, 102);
            panel_Cos.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(165, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblTotalGastos
            // 
            lblTotalGastos.AutoSize = true;
            lblTotalGastos.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalGastos.ForeColor = Color.White;
            lblTotalGastos.Location = new Point(5, 50);
            lblTotalGastos.Name = "lblTotalGastos";
            lblTotalGastos.Size = new Size(64, 23);
            lblTotalGastos.TabIndex = 0;
            lblTotalGastos.Text = "$ 0.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(15, 18);
            label6.Name = "label6";
            label6.Size = new Size(116, 19);
            label6.TabIndex = 0;
            label6.Text = "$ Total Gastos:";
            // 
            // panel_croc
            // 
            panel_croc.Anchor = AnchorStyles.None;
            panel_croc.BackColor = Color.RoyalBlue;
            panel_croc.Controls.Add(pictureBox3);
            panel_croc.Controls.Add(lblCategoriasIngresos);
            panel_croc.Controls.Add(label8);
            panel_croc.Location = new Point(637, 78);
            panel_croc.Name = "panel_croc";
            panel_croc.Size = new Size(233, 102);
            panel_croc.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(173, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 59);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // lblCategoriasIngresos
            // 
            lblCategoriasIngresos.AutoSize = true;
            lblCategoriasIngresos.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoriasIngresos.ForeColor = Color.White;
            lblCategoriasIngresos.Location = new Point(41, 50);
            lblCategoriasIngresos.Name = "lblCategoriasIngresos";
            lblCategoriasIngresos.Size = new Size(21, 23);
            lblCategoriasIngresos.TabIndex = 0;
            lblCategoriasIngresos.Text = "0";
            // 
            // label8
            // 
            label8.AutoEllipsis = true;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(10, 17);
            label8.Name = "label8";
            label8.Size = new Size(163, 19);
            label8.TabIndex = 0;
            label8.Text = "Categorías Ingresos:";
            // 
            // panel_g
            // 
            panel_g.Anchor = AnchorStyles.None;
            panel_g.BackColor = Color.SeaGreen;
            panel_g.Controls.Add(pictureBox1);
            panel_g.Controls.Add(lblTotalIngresos);
            panel_g.Controls.Add(label3);
            panel_g.Location = new Point(55, 78);
            panel_g.Name = "panel_g";
            panel_g.Size = new Size(226, 102);
            panel_g.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(152, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblTotalIngresos
            // 
            lblTotalIngresos.AutoSize = true;
            lblTotalIngresos.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalIngresos.ForeColor = Color.White;
            lblTotalIngresos.Location = new Point(5, 50);
            lblTotalIngresos.Name = "lblTotalIngresos";
            lblTotalIngresos.Size = new Size(64, 23);
            lblTotalIngresos.TabIndex = 0;
            lblTotalIngresos.Text = "$ 0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 17);
            label3.Name = "label3";
            label3.Size = new Size(128, 19);
            label3.TabIndex = 0;
            label3.Text = "$ Total Ingresos:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(314, 23);
            label2.Name = "label2";
            label2.Size = new Size(387, 25);
            label2.TabIndex = 5;
            label2.Text = "Resumen de la Actividad del Usuario";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.MidnightBlue;
            panel4.Controls.Add(pictureBox7);
            panel4.Controls.Add(lblResultado);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(188, 371);
            panel4.Name = "panel4";
            panel4.Size = new Size(619, 102);
            panel4.TabIndex = 12;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(530, 17);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(72, 70);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 2;
            pictureBox7.TabStop = false;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.White;
            lblResultado.Location = new Point(32, 49);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 25);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "$ 0.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(8, 17);
            label5.Name = "label5";
            label5.Size = new Size(101, 19);
            label5.TabIndex = 0;
            label5.Text = "$ Resultado:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(4, 552);
            label1.Name = "label1";
            label1.Size = new Size(254, 17);
            label1.TabIndex = 13;
            label1.Text = "Copyrights © 2024. All Rights Reserved.";
            // 
            // UC_Dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel_Cos);
            Controls.Add(panel_croc);
            Controls.Add(panel_g);
            Controls.Add(label2);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "UC_Dashboard";
            Size = new Size(977, 571);
            Load += UC_Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel_Cos.ResumeLayout(false);
            panel_Cos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_croc.ResumeLayout(false);
            panel_croc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel_g.ResumeLayout(false);
            panel_g.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblUltimaFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblPlanes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblCategoriasGastos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel_Cos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTotalGastos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_croc;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblCategoriasIngresos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel_g;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTotalIngresos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}
