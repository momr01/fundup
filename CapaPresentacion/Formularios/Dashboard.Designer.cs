﻿namespace CapaPresentacion
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            panelLeft = new Panel();
            panelSideReportes = new Panel();
            btnReportes = new Button();
            panelSidePlanes = new Panel();
            btnPlanes = new Button();
            panelSideMovimientos = new Panel();
            btnMovimientos = new Button();
            panelSideCategorias = new Panel();
            panelSideGraficos = new Panel();
            panelSideGastos = new Panel();
            panelSideIngresos = new Panel();
            btnCategorias = new Button();
            btnGastos = new Button();
            btnAboutUs = new Button();
            panelSideTablero = new Panel();
            btnGraficos = new Button();
            btnIngresos = new Button();
            btnTablero = new Button();
            panel2 = new Panel();
            pbLogoN = new PictureBox();
            btnSlider = new Button();
            pbLogoCompleto = new PictureBox();
            panel3 = new Panel();
            btnCerrarSesion = new Button();
            lblHora = new Label();
            panel4 = new Panel();
            btnAlertas = new PictureBox();
            lbl2 = new Label();
            lblEmail = new Label();
            lblTitulo = new Label();
            lblUsuario = new Label();
            lbl1 = new Label();
            panelContainer = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            timerTime = new System.Windows.Forms.Timer(components);
            btnOpciones = new Button();
            panelSideOpciones = new Panel();
            panelLeft.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogoN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoCompleto).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAlertas).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(30, 50, 94);
            panelLeft.BorderStyle = BorderStyle.Fixed3D;
            panelLeft.Controls.Add(panelSideOpciones);
            panelLeft.Controls.Add(btnOpciones);
            panelLeft.Controls.Add(panelSideReportes);
            panelLeft.Controls.Add(btnReportes);
            panelLeft.Controls.Add(panelSidePlanes);
            panelLeft.Controls.Add(btnPlanes);
            panelLeft.Controls.Add(panelSideMovimientos);
            panelLeft.Controls.Add(btnMovimientos);
            panelLeft.Controls.Add(panelSideCategorias);
            panelLeft.Controls.Add(panelSideGraficos);
            panelLeft.Controls.Add(panelSideGastos);
            panelLeft.Controls.Add(panelSideIngresos);
            panelLeft.Controls.Add(btnCategorias);
            panelLeft.Controls.Add(btnGastos);
            panelLeft.Controls.Add(btnAboutUs);
            panelLeft.Controls.Add(panelSideTablero);
            panelLeft.Controls.Add(btnGraficos);
            panelLeft.Controls.Add(btnIngresos);
            panelLeft.Controls.Add(btnTablero);
            panelLeft.Controls.Add(panel2);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(223, 720);
            panelLeft.TabIndex = 0;
            // 
            // panelSideReportes
            // 
            panelSideReportes.BackColor = Color.White;
            panelSideReportes.Location = new Point(-2, 524);
            panelSideReportes.Name = "panelSideReportes";
            panelSideReportes.Size = new Size(8, 52);
            panelSideReportes.TabIndex = 13;
            panelSideReportes.Visible = false;
            // 
            // btnReportes
            // 
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReportes.ForeColor = Color.White;
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(0, 524);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(216, 52);
            btnReportes.TabIndex = 13;
            btnReportes.Text = "      Reportes";
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // panelSidePlanes
            // 
            panelSidePlanes.BackColor = Color.White;
            panelSidePlanes.Location = new Point(-1, 466);
            panelSidePlanes.Name = "panelSidePlanes";
            panelSidePlanes.Size = new Size(8, 52);
            panelSidePlanes.TabIndex = 12;
            panelSidePlanes.Visible = false;
            // 
            // btnPlanes
            // 
            btnPlanes.FlatAppearance.BorderSize = 0;
            btnPlanes.FlatStyle = FlatStyle.Flat;
            btnPlanes.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlanes.ForeColor = Color.White;
            btnPlanes.Image = (Image)resources.GetObject("btnPlanes.Image");
            btnPlanes.ImageAlign = ContentAlignment.MiddleLeft;
            btnPlanes.Location = new Point(3, 466);
            btnPlanes.Name = "btnPlanes";
            btnPlanes.Size = new Size(216, 52);
            btnPlanes.TabIndex = 11;
            btnPlanes.Text = "      Planes de Inversión";
            btnPlanes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPlanes.UseVisualStyleBackColor = true;
            btnPlanes.Click += btnPlanes_Click;
            // 
            // panelSideMovimientos
            // 
            panelSideMovimientos.BackColor = Color.White;
            panelSideMovimientos.Location = new Point(-2, 409);
            panelSideMovimientos.Name = "panelSideMovimientos";
            panelSideMovimientos.Size = new Size(8, 52);
            panelSideMovimientos.TabIndex = 10;
            panelSideMovimientos.Visible = false;
            // 
            // btnMovimientos
            // 
            btnMovimientos.FlatAppearance.BorderSize = 0;
            btnMovimientos.FlatStyle = FlatStyle.Flat;
            btnMovimientos.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMovimientos.ForeColor = Color.White;
            btnMovimientos.Image = (Image)resources.GetObject("btnMovimientos.Image");
            btnMovimientos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMovimientos.Location = new Point(0, 408);
            btnMovimientos.Name = "btnMovimientos";
            btnMovimientos.Size = new Size(216, 52);
            btnMovimientos.TabIndex = 10;
            btnMovimientos.Text = "      Movimientos";
            btnMovimientos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMovimientos.UseVisualStyleBackColor = true;
            btnMovimientos.Click += btnMovimientos_Click;
            // 
            // panelSideCategorias
            // 
            panelSideCategorias.BackColor = Color.White;
            panelSideCategorias.Location = new Point(-1, 358);
            panelSideCategorias.Name = "panelSideCategorias";
            panelSideCategorias.Size = new Size(8, 44);
            panelSideCategorias.TabIndex = 7;
            panelSideCategorias.Visible = false;
            // 
            // panelSideGraficos
            // 
            panelSideGraficos.BackColor = Color.White;
            panelSideGraficos.Location = new Point(-1, 308);
            panelSideGraficos.Name = "panelSideGraficos";
            panelSideGraficos.Size = new Size(8, 44);
            panelSideGraficos.TabIndex = 5;
            panelSideGraficos.Visible = false;
            // 
            // panelSideGastos
            // 
            panelSideGastos.BackColor = Color.White;
            panelSideGastos.Location = new Point(-1, 258);
            panelSideGastos.Name = "panelSideGastos";
            panelSideGastos.Size = new Size(8, 44);
            panelSideGastos.TabIndex = 4;
            panelSideGastos.Visible = false;
            // 
            // panelSideIngresos
            // 
            panelSideIngresos.BackColor = Color.White;
            panelSideIngresos.Location = new Point(-1, 208);
            panelSideIngresos.Name = "panelSideIngresos";
            panelSideIngresos.Size = new Size(8, 44);
            panelSideIngresos.TabIndex = 3;
            panelSideIngresos.Visible = false;
            // 
            // btnCategorias
            // 
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.Image = (Image)resources.GetObject("btnCategorias.Image");
            btnCategorias.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategorias.Location = new Point(3, 358);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(216, 44);
            btnCategorias.TabIndex = 5;
            btnCategorias.Text = "      Categorías";
            btnCategorias.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnGastos
            // 
            btnGastos.FlatAppearance.BorderSize = 0;
            btnGastos.FlatStyle = FlatStyle.Flat;
            btnGastos.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGastos.ForeColor = Color.White;
            btnGastos.Image = (Image)resources.GetObject("btnGastos.Image");
            btnGastos.ImageAlign = ContentAlignment.MiddleLeft;
            btnGastos.Location = new Point(3, 258);
            btnGastos.Name = "btnGastos";
            btnGastos.Size = new Size(218, 44);
            btnGastos.TabIndex = 3;
            btnGastos.Text = "       Gastos";
            btnGastos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGastos.UseVisualStyleBackColor = true;
            btnGastos.Click += btnGastos_Click;
            // 
            // btnAboutUs
            // 
            btnAboutUs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAboutUs.FlatAppearance.BorderSize = 0;
            btnAboutUs.FlatStyle = FlatStyle.Flat;
            btnAboutUs.ForeColor = Color.White;
            btnAboutUs.Image = (Image)resources.GetObject("btnAboutUs.Image");
            btnAboutUs.Location = new Point(3, 669);
            btnAboutUs.Name = "btnAboutUs";
            btnAboutUs.Size = new Size(46, 44);
            btnAboutUs.TabIndex = 1;
            btnAboutUs.UseVisualStyleBackColor = true;
            btnAboutUs.Click += btnAboutUs_Click;
            // 
            // panelSideTablero
            // 
            panelSideTablero.BackColor = Color.White;
            panelSideTablero.Location = new Point(-1, 158);
            panelSideTablero.Name = "panelSideTablero";
            panelSideTablero.Size = new Size(8, 44);
            panelSideTablero.TabIndex = 2;
            panelSideTablero.Visible = false;
            // 
            // btnGraficos
            // 
            btnGraficos.FlatAppearance.BorderSize = 0;
            btnGraficos.FlatStyle = FlatStyle.Flat;
            btnGraficos.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGraficos.ForeColor = Color.White;
            btnGraficos.Image = (Image)resources.GetObject("btnGraficos.Image");
            btnGraficos.ImageAlign = ContentAlignment.MiddleLeft;
            btnGraficos.Location = new Point(2, 308);
            btnGraficos.Name = "btnGraficos";
            btnGraficos.Size = new Size(216, 44);
            btnGraficos.TabIndex = 1;
            btnGraficos.Text = "      Gráficos";
            btnGraficos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGraficos.UseVisualStyleBackColor = true;
            btnGraficos.Click += btnGraficos_Click;
            // 
            // btnIngresos
            // 
            btnIngresos.FlatAppearance.BorderSize = 0;
            btnIngresos.FlatStyle = FlatStyle.Flat;
            btnIngresos.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresos.ForeColor = Color.White;
            btnIngresos.Image = (Image)resources.GetObject("btnIngresos.Image");
            btnIngresos.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresos.Location = new Point(3, 208);
            btnIngresos.Name = "btnIngresos";
            btnIngresos.Size = new Size(218, 44);
            btnIngresos.TabIndex = 1;
            btnIngresos.Text = "       Ingresos";
            btnIngresos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresos.UseVisualStyleBackColor = true;
            btnIngresos.Click += btnIngresos_Click;
            // 
            // btnTablero
            // 
            btnTablero.FlatAppearance.BorderSize = 0;
            btnTablero.FlatStyle = FlatStyle.Flat;
            btnTablero.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTablero.ForeColor = Color.White;
            btnTablero.Image = (Image)resources.GetObject("btnTablero.Image");
            btnTablero.ImageAlign = ContentAlignment.MiddleLeft;
            btnTablero.Location = new Point(5, 158);
            btnTablero.Name = "btnTablero";
            btnTablero.Size = new Size(216, 44);
            btnTablero.TabIndex = 1;
            btnTablero.Text = "      Tablero";
            btnTablero.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTablero.UseVisualStyleBackColor = true;
            btnTablero.Click += BtnDashboard_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pbLogoN);
            panel2.Controls.Add(btnSlider);
            panel2.Controls.Add(pbLogoCompleto);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 149);
            panel2.TabIndex = 0;
            // 
            // pbLogoN
            // 
            pbLogoN.Image = (Image)resources.GetObject("pbLogoN.Image");
            pbLogoN.Location = new Point(3, 71);
            pbLogoN.Name = "pbLogoN";
            pbLogoN.Size = new Size(46, 50);
            pbLogoN.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoN.TabIndex = 0;
            pbLogoN.TabStop = false;
            // 
            // btnSlider
            // 
            btnSlider.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSlider.BackgroundImage = (Image)resources.GetObject("btnSlider.BackgroundImage");
            btnSlider.FlatAppearance.BorderSize = 0;
            btnSlider.FlatStyle = FlatStyle.Flat;
            btnSlider.ForeColor = Color.White;
            btnSlider.Image = (Image)resources.GetObject("btnSlider.Image");
            btnSlider.Location = new Point(175, 3);
            btnSlider.Name = "btnSlider";
            btnSlider.Size = new Size(46, 44);
            btnSlider.TabIndex = 1;
            btnSlider.UseVisualStyleBackColor = true;
            btnSlider.Click += Button1_Click;
            // 
            // pbLogoCompleto
            // 
            pbLogoCompleto.Image = (Image)resources.GetObject("pbLogoCompleto.Image");
            pbLogoCompleto.Location = new Point(60, 47);
            pbLogoCompleto.Name = "pbLogoCompleto";
            pbLogoCompleto.Size = new Size(156, 99);
            pbLogoCompleto.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoCompleto.TabIndex = 13;
            pbLogoCompleto.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCerrarSesion);
            panel3.Controls.Add(lblHora);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(223, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(977, 49);
            panel3.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarSesion.BackgroundImage = (Image)resources.GetObject("btnCerrarSesion.BackgroundImage");
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.Location = new Point(925, -1);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(52, 50);
            btnCerrarSesion.TabIndex = 14;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.ForeColor = Color.FromArgb(30, 50, 94);
            lblHora.Location = new Point(71, 17);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(83, 19);
            lblHora.TabIndex = 8;
            lblHora.Text = "HH:MM:SS";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 50, 94);
            panel4.Controls.Add(btnAlertas);
            panel4.Controls.Add(lbl2);
            panel4.Controls.Add(lblEmail);
            panel4.Controls.Add(lblTitulo);
            panel4.Controls.Add(lblUsuario);
            panel4.Controls.Add(lbl1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(223, 49);
            panel4.Name = "panel4";
            panel4.Size = new Size(977, 100);
            panel4.TabIndex = 1;
            // 
            // btnAlertas
            // 
            btnAlertas.Dock = DockStyle.Right;
            btnAlertas.Image = (Image)resources.GetObject("btnAlertas.Image");
            btnAlertas.Location = new Point(914, 0);
            btnAlertas.Name = "btnAlertas";
            btnAlertas.Size = new Size(63, 100);
            btnAlertas.TabIndex = 15;
            btnAlertas.TabStop = false;
            btnAlertas.Click += btnAlertas_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.ForeColor = Color.White;
            lbl2.Location = new Point(85, 55);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(56, 19);
            lbl2.TabIndex = 14;
            lbl2.Text = "Email:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(160, 55);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(0, 19);
            lblEmail.TabIndex = 14;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(608, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(251, 33);
            lblTitulo.TabIndex = 14;
            lblTitulo.Text = "Bienvenid@ de vuelta!";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(160, 20);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 19);
            lblUsuario.TabIndex = 14;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = Color.White;
            lbl1.Location = new Point(85, 20);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(69, 19);
            lbl1.TabIndex = 14;
            lbl1.Text = "Usuario:";
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(223, 149);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(977, 571);
            panelContainer.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += Timer1_Tick;
            // 
            // timerTime
            // 
            timerTime.Tick += timerTime_Tick;
            // 
            // btnOpciones
            // 
            btnOpciones.FlatAppearance.BorderSize = 0;
            btnOpciones.FlatStyle = FlatStyle.Flat;
            btnOpciones.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpciones.ForeColor = Color.White;
            btnOpciones.Image = (Image)resources.GetObject("btnOpciones.Image");
            btnOpciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpciones.Location = new Point(3, 582);
            btnOpciones.Name = "btnOpciones";
            btnOpciones.Size = new Size(216, 52);
            btnOpciones.TabIndex = 14;
            btnOpciones.Text = "      Opciones";
            btnOpciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOpciones.UseVisualStyleBackColor = true;
            btnOpciones.Click += btnOpciones_Click;
            // 
            // panelSideOpciones
            // 
            panelSideOpciones.BackColor = Color.White;
            panelSideOpciones.Location = new Point(-1, 582);
            panelSideOpciones.Name = "panelSideOpciones";
            panelSideOpciones.Size = new Size(8, 52);
            panelSideOpciones.TabIndex = 14;
            panelSideOpciones.Visible = false;
            // 
            // DashboardForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(panelContainer);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panelLeft);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Text = "Form_Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += DashboardForm_Load;
            panelLeft.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogoN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoCompleto).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAlertas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbLogoCompleto;
        private System.Windows.Forms.Button btnTablero;
        private System.Windows.Forms.Button btnSlider;
        private System.Windows.Forms.Panel panelSideTablero;
        private System.Windows.Forms.Button btnGraficos;
        private System.Windows.Forms.Button btnIngresos;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTitulo;
        private PictureBox pbLogoN;
        private Button btnGastos;
        private System.Windows.Forms.Timer timerTime;
        private Button btnCerrarSesion;
        private Button btnCategorias;
        private Panel panelSideCategorias;
        private Panel panelSideGraficos;
        private Panel panelSideGastos;
        private Panel panelSideIngresos;
        private Panel panelSideMovimientos;
        private Button btnMovimientos;
        private Panel panelSidePlanes;
        private Button btnPlanes;
        private Panel panelSideReportes;
        private Button btnReportes;
        private PictureBox btnAlertas;
        private Panel panelSideOpciones;
        private Button btnOpciones;
    }
}