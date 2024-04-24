namespace CapaPresentacion.Formularios
{
    partial class VerEditarPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerEditarPlan));
            panel5 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btnEliminar = new Button();
            categoriaBindingSource = new BindingSource(components);
            btnEditar = new Button();
            lblNombre = new Label();
            tableDinero = new DataGridView();
            btnCerrar = new Button();
            btnAgregarDinero = new Button();
            gbEstado = new GroupBox();
            lblEstado = new Label();
            gbTiempo = new GroupBox();
            lblDiasFaltantes = new Label();
            gbCapital = new GroupBox();
            lblPorcentaje = new Label();
            gbDineroReunido = new GroupBox();
            lblDineroReunido = new Label();
            gbDineroFaltante = new GroupBox();
            lblDineroFaltante = new Label();
            pbExtra = new PictureBox();
            label8 = new Label();
            label10 = new Label();
            pbMasDatos = new PictureBox();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableDinero).BeginInit();
            gbEstado.SuspendLayout();
            gbTiempo.SuspendLayout();
            gbCapital.SuspendLayout();
            gbDineroReunido.SuspendLayout();
            gbDineroFaltante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbExtra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMasDatos).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 50, 94);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 720);
            panel5.TabIndex = 92;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 50, 94);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1190, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 720);
            panel1.TabIndex = 93;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 50, 94);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1180, 10);
            panel2.TabIndex = 94;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 50, 94);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(10, 710);
            panel3.Name = "panel3";
            panel3.Size = new Size(1180, 10);
            panel3.TabIndex = 95;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 3);
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
            label1.Location = new Point(399, 20);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 97;
            label1.Text = "Plan:";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(954, 653);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(142, 41);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar Dinero";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // categoriaBindingSource
            // 
            categoriaBindingSource.DataSource = typeof(Entidades.Categoria);
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.None;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.Blue;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(782, 653);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(142, 41);
            btnEditar.TabIndex = 112;
            btnEditar.Text = "Editar Dinero";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.FromArgb(64, 64, 64);
            lblNombre.Location = new Point(587, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 25);
            lblNombre.TabIndex = 113;
            // 
            // tableDinero
            // 
            tableDinero.AllowUserToAddRows = false;
            tableDinero.AllowUserToDeleteRows = false;
            tableDinero.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableDinero.BackgroundColor = Color.FromArgb(224, 224, 224);
            tableDinero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableDinero.Location = new Point(87, 341);
            tableDinero.MultiSelect = false;
            tableDinero.Name = "tableDinero";
            tableDinero.ReadOnly = true;
            tableDinero.RowTemplate.Height = 33;
            tableDinero.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableDinero.Size = new Size(1012, 240);
            tableDinero.TabIndex = 88;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.FromArgb(30, 50, 94);
            btnCerrar.Location = new Point(1080, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(98, 64);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAgregarDinero
            // 
            btnAgregarDinero.Anchor = AnchorStyles.None;
            btnAgregarDinero.Cursor = Cursors.Hand;
            btnAgregarDinero.FlatStyle = FlatStyle.Flat;
            btnAgregarDinero.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarDinero.ForeColor = Color.SeaGreen;
            btnAgregarDinero.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarDinero.Location = new Point(87, 653);
            btnAgregarDinero.Name = "btnAgregarDinero";
            btnAgregarDinero.Size = new Size(142, 41);
            btnAgregarDinero.TabIndex = 123;
            btnAgregarDinero.Text = "Agregar Dinero";
            btnAgregarDinero.UseVisualStyleBackColor = true;
            btnAgregarDinero.Click += btnAgregarDinero_Click;
            // 
            // gbEstado
            // 
            gbEstado.BackColor = Color.LightCyan;
            gbEstado.Controls.Add(lblEstado);
            gbEstado.Font = new Font("Century Gothic", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            gbEstado.ForeColor = Color.Blue;
            gbEstado.Location = new Point(88, 70);
            gbEstado.Name = "gbEstado";
            gbEstado.Size = new Size(314, 122);
            gbEstado.TabIndex = 124;
            gbEstado.TabStop = false;
            gbEstado.Text = "ESTADO";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.Location = new Point(86, 55);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(84, 28);
            lblEstado.TabIndex = 1;
            lblEstado.Text = "label3";
            // 
            // gbTiempo
            // 
            gbTiempo.BackColor = Color.LavenderBlush;
            gbTiempo.Controls.Add(lblDiasFaltantes);
            gbTiempo.Font = new Font("Century Gothic", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            gbTiempo.ForeColor = Color.Red;
            gbTiempo.Location = new Point(430, 70);
            gbTiempo.Name = "gbTiempo";
            gbTiempo.Size = new Size(325, 122);
            gbTiempo.TabIndex = 125;
            gbTiempo.TabStop = false;
            gbTiempo.Text = "TIEMPO FALTANTE";
            // 
            // lblDiasFaltantes
            // 
            lblDiasFaltantes.AutoSize = true;
            lblDiasFaltantes.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiasFaltantes.Location = new Point(81, 55);
            lblDiasFaltantes.Name = "lblDiasFaltantes";
            lblDiasFaltantes.Size = new Size(84, 28);
            lblDiasFaltantes.TabIndex = 3;
            lblDiasFaltantes.Text = "label3";
            // 
            // gbCapital
            // 
            gbCapital.BackColor = Color.FromArgb(192, 255, 192);
            gbCapital.Controls.Add(lblPorcentaje);
            gbCapital.Font = new Font("Century Gothic", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            gbCapital.ForeColor = Color.Green;
            gbCapital.Location = new Point(780, 70);
            gbCapital.Name = "gbCapital";
            gbCapital.Size = new Size(314, 122);
            gbCapital.TabIndex = 126;
            gbCapital.TabStop = false;
            gbCapital.Text = "% CAPITAL REUNIDO";
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPorcentaje.Location = new Point(84, 55);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(84, 28);
            lblPorcentaje.TabIndex = 1;
            lblPorcentaje.Text = "label5";
            // 
            // gbDineroReunido
            // 
            gbDineroReunido.BackColor = Color.PaleGoldenrod;
            gbDineroReunido.Controls.Add(lblDineroReunido);
            gbDineroReunido.Font = new Font("Century Gothic", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            gbDineroReunido.ForeColor = Color.FromArgb(128, 64, 64);
            gbDineroReunido.Location = new Point(280, 198);
            gbDineroReunido.Name = "gbDineroReunido";
            gbDineroReunido.Size = new Size(314, 122);
            gbDineroReunido.TabIndex = 125;
            gbDineroReunido.TabStop = false;
            gbDineroReunido.Text = "$ REUNIDO";
            // 
            // lblDineroReunido
            // 
            lblDineroReunido.AutoSize = true;
            lblDineroReunido.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDineroReunido.Location = new Point(90, 58);
            lblDineroReunido.Name = "lblDineroReunido";
            lblDineroReunido.Size = new Size(84, 28);
            lblDineroReunido.TabIndex = 1;
            lblDineroReunido.Text = "label7";
            // 
            // gbDineroFaltante
            // 
            gbDineroFaltante.BackColor = Color.FromArgb(192, 192, 255);
            gbDineroFaltante.Controls.Add(lblDineroFaltante);
            gbDineroFaltante.Font = new Font("Century Gothic", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            gbDineroFaltante.ForeColor = Color.DarkOrchid;
            gbDineroFaltante.Location = new Point(600, 198);
            gbDineroFaltante.Name = "gbDineroFaltante";
            gbDineroFaltante.Size = new Size(314, 122);
            gbDineroFaltante.TabIndex = 126;
            gbDineroFaltante.TabStop = false;
            gbDineroFaltante.Text = "$ FALTANTE";
            // 
            // lblDineroFaltante
            // 
            lblDineroFaltante.AutoSize = true;
            lblDineroFaltante.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDineroFaltante.Location = new Point(86, 58);
            lblDineroFaltante.Name = "lblDineroFaltante";
            lblDineroFaltante.Size = new Size(84, 28);
            lblDineroFaltante.TabIndex = 1;
            lblDineroFaltante.Text = "label8";
            // 
            // pbExtra
            // 
            pbExtra.Anchor = AnchorStyles.None;
            pbExtra.Image = (Image)resources.GetObject("pbExtra.Image");
            pbExtra.Location = new Point(1019, 256);
            pbExtra.Name = "pbExtra";
            pbExtra.Size = new Size(80, 64);
            pbExtra.SizeMode = PictureBoxSizeMode.Zoom;
            pbExtra.TabIndex = 127;
            pbExtra.TabStop = false;
            pbExtra.Click += pbInfo_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(87, 584);
            label8.Name = "label8";
            label8.Size = new Size(280, 17);
            label8.TabIndex = 130;
            label8.Text = "Los gastos no pueden superar los ingresos.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(87, 601);
            label10.Name = "label10";
            label10.Size = new Size(374, 17);
            label10.TabIndex = 131;
            label10.Text = "El resultado final no puede ser mayor al capital objetivo.";
            // 
            // pbMasDatos
            // 
            pbMasDatos.Anchor = AnchorStyles.None;
            pbMasDatos.Image = (Image)resources.GetObject("pbMasDatos.Image");
            pbMasDatos.Location = new Point(87, 256);
            pbMasDatos.Name = "pbMasDatos";
            pbMasDatos.Size = new Size(80, 64);
            pbMasDatos.SizeMode = PictureBoxSizeMode.Zoom;
            pbMasDatos.TabIndex = 132;
            pbMasDatos.TabStop = false;
            pbMasDatos.Click += pbMasDatos_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(tableDinero);
            panel6.Controls.Add(lblNombre);
            panel6.Controls.Add(btnCerrar);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(gbCapital);
            panel6.Controls.Add(pbExtra);
            panel6.Controls.Add(gbTiempo);
            panel6.Controls.Add(pictureBox2);
            panel6.Controls.Add(gbEstado);
            panel6.Controls.Add(pbMasDatos);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(btnEliminar);
            panel6.Controls.Add(gbDineroFaltante);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(gbDineroReunido);
            panel6.Controls.Add(btnEditar);
            panel6.Controls.Add(btnAgregarDinero);
            panel6.Location = new Point(10, 10);
            panel6.Name = "panel6";
            panel6.Size = new Size(1180, 700);
            panel6.TabIndex = 133;
            // 
            // VerEditarPlan
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerEditarPlan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_AddWork";
            WindowState = FormWindowState.Maximized;
            Load += VerEditarPlan_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableDinero).EndInit();
            gbEstado.ResumeLayout(false);
            gbEstado.PerformLayout();
            gbTiempo.ResumeLayout(false);
            gbTiempo.PerformLayout();
            gbCapital.ResumeLayout(false);
            gbCapital.PerformLayout();
            gbDineroReunido.ResumeLayout(false);
            gbDineroReunido.PerformLayout();
            gbDineroFaltante.ResumeLayout(false);
            gbDineroFaltante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbExtra).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMasDatos).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTitle;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTsNo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTsAmount;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPageNo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMBNo;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.ComboBox cmbHOA;
        private System.Windows.Forms.Button btnEliminar;
        private BindingSource categoriaBindingSource;
        private Button btnEditar;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label label2;
        private Label lblFechaInicio;
        private Label label6;
        private Label label9;
        private Label lblCapital;
        private Panel panel4;
        private DataGridView tableDinero;
        private System.Windows.Forms.Button btnCerrar;
        private Button btnAgregarDinero;
        private GroupBox gbEstado;
        private Label lblDiasFaltantes;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel2;
        private GroupBox gbTiempo;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel1;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel3;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel4;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel5;
        private GroupBox gbCapital;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel6;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel7;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel8;
        private Label lblPorcentaje;
        private GroupBox gbDineroReunido;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel9;
        private GroupBox gbDineroFaltante;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel10;
        private Label lblEstado;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label lblDineroFaltante;
        private Label lblDineroReunido;
        private PictureBox pbExtra;
        private Label txtFechaCompleto;
        private Label lblFechaCompleto;
        private Label label8;
        private Label label10;
        private PictureBox pbMasDatos;
        private Panel panel6;
        //private DragControlDemo.DragControl dragControl1;
    }
}