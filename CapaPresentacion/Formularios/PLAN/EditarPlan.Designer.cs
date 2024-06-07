namespace CapaPresentacion.Formularios
{
    partial class EditarPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarPlan));
            panel5 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCancelar = new Button();
            txtNombre = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            txtDescripcion = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            categoriaBindingSource = new BindingSource(components);
            btnEditar = new Button();
            dpFechaFin = new Krypton.Toolkit.KryptonDateTimePicker();
            label16 = new Label();
            txtCapital = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            label20 = new Label();
            dpFechaInicio = new Krypton.Toolkit.KryptonDateTimePicker();
            label19 = new Label();
            label8 = new Label();
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
            panel5.Size = new Size(10, 478);
            panel5.TabIndex = 92;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 50, 94);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(926, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 478);
            panel1.TabIndex = 93;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 50, 94);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(916, 10);
            panel2.TabIndex = 94;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 50, 94);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(10, 468);
            panel3.Name = "panel3";
            panel3.Size = new Size(916, 10);
            panel3.TabIndex = 95;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 16);
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
            label1.Location = new Point(376, 42);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 97;
            label1.Text = "Editar Plan";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(78, 119);
            label4.Name = "label4";
            label4.Size = new Size(83, 18);
            label4.TabIndex = 99;
            label4.Text = "Nombre: *";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(50, 185);
            label5.Name = "label5";
            label5.Size = new Size(112, 18);
            label5.TabIndex = 101;
            label5.Text = "Descripción: *";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.DimGray;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(710, 394);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 41);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = false;
            txtNombre.AutoCompleteMode = AutoCompleteMode.None;
            txtNombre.AutoCompleteSource = AutoCompleteSource.None;
            txtNombre.BackgroundImageLayout = ImageLayout.None;
            txtNombre.CharacterCasing = CharacterCasing.Normal;
            txtNombre.Depth = 0;
            txtNombre.ErrorMessage = "El nombre es requerido";
            txtNombre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.HideSelection = true;
            txtNombre.Hint = "Ingrese un nombre";
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(163, 102);
            txtNombre.MaxLength = 32767;
            txtNombre.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtNombre.Name = "txtNombre";
            txtNombre.PasswordChar = '\0';
            txtNombre.PrefixSuffixText = null;
            txtNombre.ReadOnly = false;
            txtNombre.RightToLeft = RightToLeft.No;
            txtNombre.SelectedText = "";
            txtNombre.SelectionLength = 0;
            txtNombre.SelectionStart = 0;
            txtNombre.ShortcutsEnabled = true;
            txtNombre.Size = new Size(690, 48);
            txtNombre.TabIndex = 106;
            txtNombre.TabStop = false;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.TrailingIcon = null;
            txtNombre.UseSystemPasswordChar = false;
            // 
            // txtDescripcion
            // 
            txtDescripcion.AnimateReadOnly = false;
            txtDescripcion.AutoCompleteMode = AutoCompleteMode.None;
            txtDescripcion.AutoCompleteSource = AutoCompleteSource.None;
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.BackgroundImageLayout = ImageLayout.None;
            txtDescripcion.CharacterCasing = CharacterCasing.Normal;
            txtDescripcion.Depth = 0;
            txtDescripcion.ErrorMessage = "La descripción es requerida";
            txtDescripcion.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtDescripcion.HideSelection = true;
            txtDescripcion.Hint = "Ingrese una descripción";
            txtDescripcion.LeadingIcon = null;
            txtDescripcion.Location = new Point(163, 168);
            txtDescripcion.MaxLength = 32767;
            txtDescripcion.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PasswordChar = '\0';
            txtDescripcion.PrefixSuffixText = null;
            txtDescripcion.ReadOnly = false;
            txtDescripcion.RightToLeft = RightToLeft.No;
            txtDescripcion.SelectedText = "";
            txtDescripcion.SelectionLength = 0;
            txtDescripcion.SelectionStart = 0;
            txtDescripcion.ShortcutsEnabled = true;
            txtDescripcion.Size = new Size(690, 48);
            txtDescripcion.TabIndex = 111;
            txtDescripcion.TabStop = false;
            txtDescripcion.TextAlign = HorizontalAlignment.Left;
            txtDescripcion.TrailingIcon = null;
            txtDescripcion.UseSystemPasswordChar = false;
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
            btnEditar.ForeColor = Color.SeaGreen;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(531, 394);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(142, 41);
            btnEditar.TabIndex = 112;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // dpFechaFin
            // 
            dpFechaFin.Anchor = AnchorStyles.None;
            dpFechaFin.CornerRoundingRadius = -1F;
            dpFechaFin.Cursor = Cursors.IBeam;
            dpFechaFin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpFechaFin.ForeColor = Color.FromArgb(64, 64, 64);
            dpFechaFin.Location = new Point(596, 244);
            dpFechaFin.Margin = new Padding(4);
            dpFechaFin.Name = "dpFechaFin";
            dpFechaFin.Size = new Size(257, 21);
            dpFechaFin.TabIndex = 118;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(64, 64, 64);
            label16.Location = new Point(481, 245);
            label16.Name = "label16";
            label16.Size = new Size(114, 18);
            label16.TabIndex = 117;
            label16.Text = "Fecha de fin: *";
            // 
            // txtCapital
            // 
            txtCapital.Anchor = AnchorStyles.None;
            txtCapital.AnimateReadOnly = false;
            txtCapital.AutoCompleteMode = AutoCompleteMode.None;
            txtCapital.AutoCompleteSource = AutoCompleteSource.None;
            txtCapital.BackgroundImageLayout = ImageLayout.None;
            txtCapital.CharacterCasing = CharacterCasing.Normal;
            txtCapital.Cursor = Cursors.IBeam;
            txtCapital.Depth = 0;
            txtCapital.ErrorMessage = "El capital es requerido";
            txtCapital.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCapital.HideSelection = true;
            txtCapital.Hint = "Ingrese el capital objetivo";
            txtCapital.LeadingIcon = null;
            txtCapital.Location = new Point(165, 293);
            txtCapital.Margin = new Padding(4);
            txtCapital.MaxLength = 32767;
            txtCapital.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtCapital.Name = "txtCapital";
            txtCapital.PasswordChar = '\0';
            txtCapital.PrefixSuffixText = null;
            txtCapital.ReadOnly = false;
            txtCapital.RightToLeft = RightToLeft.No;
            txtCapital.SelectedText = "";
            txtCapital.SelectionLength = 0;
            txtCapital.SelectionStart = 0;
            txtCapital.ShortcutsEnabled = true;
            txtCapital.Size = new Size(257, 48);
            txtCapital.TabIndex = 116;
            txtCapital.TabStop = false;
            txtCapital.TextAlign = HorizontalAlignment.Left;
            txtCapital.TrailingIcon = null;
            txtCapital.UseSystemPasswordChar = false;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.None;
            label20.AutoSize = true;
            label20.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.FromArgb(64, 64, 64);
            label20.Location = new Point(23, 306);
            label20.Name = "label20";
            label20.Size = new Size(141, 18);
            label20.TabIndex = 115;
            label20.Text = "Capital objetivo: *";
            // 
            // dpFechaInicio
            // 
            dpFechaInicio.Anchor = AnchorStyles.None;
            dpFechaInicio.CornerRoundingRadius = -1F;
            dpFechaInicio.Cursor = Cursors.IBeam;
            dpFechaInicio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpFechaInicio.ForeColor = Color.FromArgb(64, 64, 64);
            dpFechaInicio.Location = new Point(165, 244);
            dpFechaInicio.Margin = new Padding(4);
            dpFechaInicio.Name = "dpFechaInicio";
            dpFechaInicio.Size = new Size(257, 21);
            dpFechaInicio.TabIndex = 114;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.None;
            label19.AutoSize = true;
            label19.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(64, 64, 64);
            label19.Location = new Point(26, 245);
            label19.Name = "label19";
            label19.Size = new Size(138, 18);
            label19.TabIndex = 113;
            label19.Text = "Fecha de inicio: *";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(16, 449);
            label8.Name = "label8";
            label8.Size = new Size(153, 16);
            label8.TabIndex = 119;
            label8.Text = "* Campos obligatorios";
            // 
            // EditarPlan
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(936, 478);
            Controls.Add(label8);
            Controls.Add(dpFechaFin);
            Controls.Add(label16);
            Controls.Add(txtCapital);
            Controls.Add(label20);
            Controls.Add(dpFechaInicio);
            Controls.Add(label19);
            Controls.Add(btnEditar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditarPlan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_AddWork";
            Load += EditarPlan_Load;
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
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTsNo;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTsAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPageNo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMBNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbHOA;
        private System.Windows.Forms.Button btnCancelar;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtNombre;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtImporte;
        private Krypton.Toolkit.KryptonDateTimePicker dpFecha;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtDescripcion;
        private BindingSource categoriaBindingSource;
        private Button btnEditar;
        private Krypton.Toolkit.KryptonDateTimePicker dpFechaFin;
        private Label label16;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtCapital;
        private Label label20;
        private Krypton.Toolkit.KryptonDateTimePicker dpFechaInicio;
        private Label label19;
        private Label label8;
        //private DragControlDemo.DragControl dragControl1;
    }
}