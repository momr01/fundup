using System.Runtime;

namespace CapaPresentacion.UserControls
{
    partial class UC_PlanInversion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PlanInversion));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            tabPage3 = new TabPage();
            label2 = new Label();
            dpFechaFin = new Krypton.Toolkit.KryptonDateTimePicker();
            label16 = new Label();
            btnCancelar = new Button();
            txtCapital = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            label20 = new Label();
            dpFechaInicio = new Krypton.Toolkit.KryptonDateTimePicker();
            label19 = new Label();
            txtDescripcion = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            label11 = new Label();
            txtNombre = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            btnGuardar = new Button();
            label17 = new Label();
            label18 = new Label();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            label15 = new Label();
            txtnada = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            label12 = new Label();
            txtnada2 = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            label7 = new Label();
            label9 = new Label();
            dp1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            label3 = new Label();
            btnSave = new Button();
            button2 = new Button();
            dp2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            label5 = new Label();
            tabPage1 = new TabPage();
            btnVerPlan = new Button();
            btnEditarPlan = new Button();
            btnEliminarPlan = new Button();
            btnCargarPlanes = new Button();
            tablePlanesActivos = new DataGridView();
            label6 = new Label();
            tabControl1 = new TabControl();
            tabPage4 = new TabPage();
            btnVerCompletos = new Button();
            btnEliminarCompletos = new Button();
            btnCargarCompletos = new Button();
            tablePlanesFinalizados = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            label8 = new Label();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablePlanesActivos).BeginInit();
            tabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablePlanesFinalizados).BeginInit();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(dpFechaFin);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(btnCancelar);
            tabPage3.Controls.Add(txtCapital);
            tabPage3.Controls.Add(label20);
            tabPage3.Controls.Add(dpFechaInicio);
            tabPage3.Controls.Add(label19);
            tabPage3.Controls.Add(txtDescripcion);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(txtNombre);
            tabPage3.Controls.Add(btnGuardar);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(label18);
            tabPage3.Location = new Point(4, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(969, 618);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Crear";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(24, 526);
            label2.Name = "label2";
            label2.Size = new Size(255, 20);
            label2.TabIndex = 58;
            label2.Text = "*     Las fechas deben ser distintas.";
            // 
            // dpFechaFin
            // 
            dpFechaFin.Anchor = AnchorStyles.None;
            dpFechaFin.CornerRoundingRadius = -1F;
            dpFechaFin.Cursor = Cursors.IBeam;
            dpFechaFin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpFechaFin.ForeColor = Color.FromArgb(64, 64, 64);
            dpFechaFin.Location = new Point(666, 261);
            dpFechaFin.Margin = new Padding(4);
            dpFechaFin.Name = "dpFechaFin";
            dpFechaFin.Size = new Size(257, 21);
            dpFechaFin.TabIndex = 54;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(64, 64, 64);
            label16.Location = new Point(531, 262);
            label16.Name = "label16";
            label16.Size = new Size(133, 18);
            label16.TabIndex = 53;
            label16.Text = "Fecha objetivo: *";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.DimGray;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(624, 364);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(141, 45);
            btnCancelar.TabIndex = 52;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
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
            txtCapital.Location = new Point(173, 309);
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
            txtCapital.TabIndex = 51;
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
            label20.Location = new Point(24, 322);
            label20.Name = "label20";
            label20.Size = new Size(148, 18);
            label20.TabIndex = 50;
            label20.Text = "Capital objetivo: **";
            // 
            // dpFechaInicio
            // 
            dpFechaInicio.Anchor = AnchorStyles.None;
            dpFechaInicio.CornerRoundingRadius = -1F;
            dpFechaInicio.Cursor = Cursors.IBeam;
            dpFechaInicio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpFechaInicio.ForeColor = Color.FromArgb(64, 64, 64);
            dpFechaInicio.Location = new Point(173, 260);
            dpFechaInicio.Margin = new Padding(4);
            dpFechaInicio.Name = "dpFechaInicio";
            dpFechaInicio.Size = new Size(257, 21);
            dpFechaInicio.TabIndex = 49;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.None;
            label19.AutoSize = true;
            label19.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(64, 64, 64);
            label19.Location = new Point(33, 261);
            label19.Name = "label19";
            label19.Size = new Size(138, 18);
            label19.TabIndex = 48;
            label19.Text = "Fecha de inicio: *";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.None;
            txtDescripcion.AnimateReadOnly = false;
            txtDescripcion.AutoCompleteMode = AutoCompleteMode.None;
            txtDescripcion.AutoCompleteSource = AutoCompleteSource.None;
            txtDescripcion.BackgroundImageLayout = ImageLayout.None;
            txtDescripcion.CharacterCasing = CharacterCasing.Normal;
            txtDescripcion.Cursor = Cursors.IBeam;
            txtDescripcion.Depth = 0;
            txtDescripcion.ErrorMessage = "La descripción es requerida";
            txtDescripcion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.HideSelection = true;
            txtDescripcion.Hint = "Ingrese la descripción";
            txtDescripcion.LeadingIcon = null;
            txtDescripcion.Location = new Point(173, 186);
            txtDescripcion.Margin = new Padding(4);
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
            txtDescripcion.Size = new Size(750, 48);
            txtDescripcion.TabIndex = 47;
            txtDescripcion.TabStop = false;
            txtDescripcion.TextAlign = HorizontalAlignment.Left;
            txtDescripcion.TrailingIcon = null;
            txtDescripcion.UseSystemPasswordChar = false;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(64, 64, 64);
            label11.Location = new Point(69, 200);
            label11.Name = "label11";
            label11.Size = new Size(101, 18);
            label11.TabIndex = 46;
            label11.Text = "Descripción:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.AnimateReadOnly = false;
            txtNombre.AutoCompleteMode = AutoCompleteMode.None;
            txtNombre.AutoCompleteSource = AutoCompleteSource.None;
            txtNombre.BackgroundImageLayout = ImageLayout.None;
            txtNombre.CharacterCasing = CharacterCasing.Normal;
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Depth = 0;
            txtNombre.ErrorMessage = "El nombre es requerido";
            txtNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.HideSelection = true;
            txtNombre.Hint = "Ingrese un nombre";
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(173, 118);
            txtNombre.Margin = new Padding(4);
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
            txtNombre.Size = new Size(750, 48);
            txtNombre.TabIndex = 45;
            txtNombre.TabStop = false;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.TrailingIcon = null;
            txtNombre.UseSystemPasswordChar = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.SeaGreen;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(782, 364);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(141, 45);
            btnGuardar.TabIndex = 41;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(64, 64, 64);
            label17.Location = new Point(98, 136);
            label17.Name = "label17";
            label17.Size = new Size(72, 18);
            label17.TabIndex = 40;
            label17.Text = "Nombre:";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.None;
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(64, 64, 64);
            label18.Location = new Point(439, 78);
            label18.Name = "label18";
            label18.Size = new Size(115, 23);
            label18.TabIndex = 38;
            label18.Text = "Nuevo Plan";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(0, 0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(200, 100);
            tabPage2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.ButtonFace;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(76, 336);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowTemplate.Height = 40;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(845, 170);
            dataGridView2.TabIndex = 28;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(64, 64, 64);
            label15.Location = new Point(92, 91);
            label15.Name = "label15";
            label15.Size = new Size(72, 18);
            label15.TabIndex = 31;
            label15.Text = "Nombre:";
            // 
            // txtnada
            // 
            txtnada.AnimateReadOnly = false;
            txtnada.AutoCompleteMode = AutoCompleteMode.None;
            txtnada.AutoCompleteSource = AutoCompleteSource.None;
            txtnada.BackgroundImageLayout = ImageLayout.None;
            txtnada.CharacterCasing = CharacterCasing.Normal;
            txtnada.Cursor = Cursors.IBeam;
            txtnada.Depth = 0;
            txtnada.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtnada.HideSelection = true;
            txtnada.LeadingIcon = null;
            txtnada.Location = new Point(166, 75);
            txtnada.Margin = new Padding(4);
            txtnada.MaxLength = 32767;
            txtnada.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtnada.Name = "txtnada";
            txtnada.PasswordChar = '\0';
            txtnada.PrefixSuffixText = null;
            txtnada.ReadOnly = false;
            txtnada.RightToLeft = RightToLeft.No;
            txtnada.SelectedText = "";
            txtnada.SelectionLength = 0;
            txtnada.SelectionStart = 0;
            txtnada.ShortcutsEnabled = true;
            txtnada.Size = new Size(753, 48);
            txtnada.TabIndex = 16;
            txtnada.TabStop = false;
            txtnada.TextAlign = HorizontalAlignment.Left;
            txtnada.TrailingIcon = null;
            txtnada.UseSystemPasswordChar = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(64, 64, 64);
            label12.Location = new Point(63, 151);
            label12.Name = "label12";
            label12.Size = new Size(101, 18);
            label12.TabIndex = 33;
            label12.Text = "Descripción:";
            // 
            // txtnada2
            // 
            txtnada2.AnimateReadOnly = false;
            txtnada2.AutoCompleteMode = AutoCompleteMode.None;
            txtnada2.AutoCompleteSource = AutoCompleteSource.None;
            txtnada2.BackgroundImageLayout = ImageLayout.None;
            txtnada2.CharacterCasing = CharacterCasing.Normal;
            txtnada2.Cursor = Cursors.IBeam;
            txtnada2.Depth = 0;
            txtnada2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtnada2.HideSelection = true;
            txtnada2.LeadingIcon = null;
            txtnada2.Location = new Point(166, 134);
            txtnada2.Margin = new Padding(4);
            txtnada2.MaxLength = 32767;
            txtnada2.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtnada2.Name = "txtnada2";
            txtnada2.PasswordChar = '\0';
            txtnada2.PrefixSuffixText = null;
            txtnada2.ReadOnly = false;
            txtnada2.RightToLeft = RightToLeft.No;
            txtnada2.SelectedText = "";
            txtnada2.SelectionLength = 0;
            txtnada2.SelectionStart = 0;
            txtnada2.ShortcutsEnabled = true;
            txtnada2.Size = new Size(753, 48);
            txtnada2.TabIndex = 19;
            txtnada2.TabStop = false;
            txtnada2.TextAlign = HorizontalAlignment.Left;
            txtnada2.TrailingIcon = null;
            txtnada2.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(38, 195);
            label7.Name = "label7";
            label7.Size = new Size(127, 18);
            label7.TabIndex = 30;
            label7.Text = "Fecha de inicio:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(35, 244);
            label9.Name = "label9";
            label9.Size = new Size(130, 18);
            label9.TabIndex = 35;
            label9.Text = "Capital objetivo:";
            // 
            // dp1
            // 
            dp1.BorderColorFocused = Color.Blue;
            dp1.BorderColorIdle = Color.FromArgb(64, 64, 64);
            dp1.BorderColorMouseHover = Color.Blue;
            dp1.BorderThickness = 2;
            dp1.Cursor = Cursors.IBeam;
            dp1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dp1.ForeColor = Color.FromArgb(64, 64, 64);
            dp1.isPassword = false;
            dp1.Location = new Point(166, 186);
            dp1.Margin = new Padding(4);
            dp1.Name = "dp1";
            dp1.Size = new Size(178, 32);
            dp1.TabIndex = 23;
            dp1.TextAlign = HorizontalAlignment.Left;
            // 
            // txtPassword
            // 
            txtPassword.BorderColorFocused = Color.Blue;
            txtPassword.BorderColorIdle = Color.FromArgb(64, 64, 64);
            txtPassword.BorderColorMouseHover = Color.Blue;
            txtPassword.BorderThickness = 2;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(64, 64, 64);
            txtPassword.isPassword = true;
            txtPassword.Location = new Point(167, 236);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(177, 32);
            txtPassword.TabIndex = 24;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(166, 27);
            label3.Name = "label3";
            label3.Size = new Size(186, 23);
            label3.TabIndex = 39;
            label3.Text = "Planes de Inversión";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.SeaGreen;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(779, 279);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(141, 45);
            btnSave.TabIndex = 26;
            btnSave.Text = "    Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(627, 280);
            button2.Name = "button2";
            button2.Size = new Size(141, 45);
            button2.TabIndex = 27;
            button2.Text = "    Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // dp2
            // 
            dp2.BorderColorFocused = Color.Blue;
            dp2.BorderColorIdle = Color.FromArgb(64, 64, 64);
            dp2.BorderColorMouseHover = Color.Blue;
            dp2.BorderThickness = 2;
            dp2.Cursor = Cursors.IBeam;
            dp2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dp2.ForeColor = Color.FromArgb(64, 64, 64);
            dp2.isPassword = false;
            dp2.Location = new Point(742, 190);
            dp2.Margin = new Padding(4);
            dp2.Name = "dp2";
            dp2.Size = new Size(178, 32);
            dp2.TabIndex = 40;
            dp2.TextAlign = HorizontalAlignment.Left;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(617, 195);
            label5.Name = "label5";
            label5.Size = new Size(103, 18);
            label5.TabIndex = 41;
            label5.Text = "Fecha de fin:";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(btnVerPlan);
            tabPage1.Controls.Add(btnEditarPlan);
            tabPage1.Controls.Add(btnEliminarPlan);
            tabPage1.Controls.Add(btnCargarPlanes);
            tabPage1.Controls.Add(tablePlanesActivos);
            tabPage1.Controls.Add(label6);
            tabPage1.Location = new Point(4, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(969, 618);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Activos";
            // 
            // btnVerPlan
            // 
            btnVerPlan.Anchor = AnchorStyles.None;
            btnVerPlan.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVerPlan.BackColor = Color.LightGoldenrodYellow;
            btnVerPlan.Cursor = Cursors.Hand;
            btnVerPlan.FlatStyle = FlatStyle.Flat;
            btnVerPlan.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerPlan.ForeColor = Color.SeaGreen;
            btnVerPlan.Image = (Image)resources.GetObject("btnVerPlan.Image");
            btnVerPlan.Location = new Point(659, 7);
            btnVerPlan.Margin = new Padding(4, 6, 4, 6);
            btnVerPlan.Name = "btnVerPlan";
            btnVerPlan.Size = new Size(96, 72);
            btnVerPlan.TabIndex = 40;
            btnVerPlan.UseVisualStyleBackColor = false;
            btnVerPlan.Visible = false;
            btnVerPlan.Click += btnVerPlan_Click;
            // 
            // btnEditarPlan
            // 
            btnEditarPlan.Anchor = AnchorStyles.None;
            btnEditarPlan.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditarPlan.BackColor = Color.LightGoldenrodYellow;
            btnEditarPlan.Cursor = Cursors.Hand;
            btnEditarPlan.FlatStyle = FlatStyle.Flat;
            btnEditarPlan.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarPlan.ForeColor = Color.SeaGreen;
            btnEditarPlan.Image = (Image)resources.GetObject("btnEditarPlan.Image");
            btnEditarPlan.Location = new Point(763, 7);
            btnEditarPlan.Margin = new Padding(4, 6, 4, 6);
            btnEditarPlan.Name = "btnEditarPlan";
            btnEditarPlan.Size = new Size(96, 72);
            btnEditarPlan.TabIndex = 39;
            btnEditarPlan.UseVisualStyleBackColor = false;
            btnEditarPlan.Visible = false;
            btnEditarPlan.Click += btnEditarPlan_Click;
            // 
            // btnEliminarPlan
            // 
            btnEliminarPlan.Anchor = AnchorStyles.None;
            btnEliminarPlan.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminarPlan.BackColor = Color.LightGoldenrodYellow;
            btnEliminarPlan.Cursor = Cursors.Hand;
            btnEliminarPlan.FlatStyle = FlatStyle.Flat;
            btnEliminarPlan.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarPlan.ForeColor = Color.SeaGreen;
            btnEliminarPlan.Image = (Image)resources.GetObject("btnEliminarPlan.Image");
            btnEliminarPlan.Location = new Point(867, 7);
            btnEliminarPlan.Margin = new Padding(4, 6, 4, 6);
            btnEliminarPlan.Name = "btnEliminarPlan";
            btnEliminarPlan.Size = new Size(96, 72);
            btnEliminarPlan.TabIndex = 38;
            btnEliminarPlan.UseVisualStyleBackColor = false;
            btnEliminarPlan.Visible = false;
            btnEliminarPlan.Click += btnEliminarPlan_Click;
            // 
            // btnCargarPlanes
            // 
            btnCargarPlanes.Anchor = AnchorStyles.None;
            btnCargarPlanes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCargarPlanes.BackColor = Color.Lavender;
            btnCargarPlanes.Cursor = Cursors.Hand;
            btnCargarPlanes.FlatStyle = FlatStyle.Flat;
            btnCargarPlanes.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargarPlanes.ForeColor = Color.Blue;
            btnCargarPlanes.ImageAlign = ContentAlignment.MiddleLeft;
            btnCargarPlanes.Location = new Point(511, 31);
            btnCargarPlanes.Margin = new Padding(4, 6, 4, 6);
            btnCargarPlanes.Name = "btnCargarPlanes";
            btnCargarPlanes.Size = new Size(130, 36);
            btnCargarPlanes.TabIndex = 37;
            btnCargarPlanes.Text = "CARGAR";
            btnCargarPlanes.UseVisualStyleBackColor = false;
            btnCargarPlanes.Click += btnCargarPlanes_Click;
            // 
            // tablePlanesActivos
            // 
            tablePlanesActivos.AllowUserToAddRows = false;
            tablePlanesActivos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tablePlanesActivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            tablePlanesActivos.Anchor = AnchorStyles.None;
            tablePlanesActivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablePlanesActivos.BackgroundColor = Color.WhiteSmoke;
            tablePlanesActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablePlanesActivos.Location = new Point(6, 81);
            tablePlanesActivos.Name = "tablePlanesActivos";
            tablePlanesActivos.ReadOnly = true;
            tablePlanesActivos.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tablePlanesActivos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            tablePlanesActivos.RowTemplate.DefaultCellStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tablePlanesActivos.RowTemplate.Height = 30;
            tablePlanesActivos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablePlanesActivos.Size = new Size(957, 533);
            tablePlanesActivos.TabIndex = 35;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(6, 44);
            label6.Name = "label6";
            label6.Size = new Size(359, 23);
            label6.TabIndex = 31;
            label6.Text = "Listado de Planes de Inversión Activos";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(20, 10);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(977, 668);
            tabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnVerCompletos);
            tabPage4.Controls.Add(btnEliminarCompletos);
            tabPage4.Controls.Add(btnCargarCompletos);
            tabPage4.Controls.Add(tablePlanesFinalizados);
            tabPage4.Controls.Add(label1);
            tabPage4.Location = new Point(4, 46);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(969, 618);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Finalizados";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnVerCompletos
            // 
            btnVerCompletos.Anchor = AnchorStyles.None;
            btnVerCompletos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVerCompletos.BackColor = Color.LightGoldenrodYellow;
            btnVerCompletos.Cursor = Cursors.Hand;
            btnVerCompletos.FlatStyle = FlatStyle.Flat;
            btnVerCompletos.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerCompletos.ForeColor = Color.SeaGreen;
            btnVerCompletos.Image = (Image)resources.GetObject("btnVerCompletos.Image");
            btnVerCompletos.Location = new Point(763, 6);
            btnVerCompletos.Margin = new Padding(4, 6, 4, 6);
            btnVerCompletos.Name = "btnVerCompletos";
            btnVerCompletos.Size = new Size(96, 72);
            btnVerCompletos.TabIndex = 46;
            btnVerCompletos.UseVisualStyleBackColor = false;
            btnVerCompletos.Visible = false;
            btnVerCompletos.Click += btnVerCompletos_Click;
            // 
            // btnEliminarCompletos
            // 
            btnEliminarCompletos.Anchor = AnchorStyles.None;
            btnEliminarCompletos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminarCompletos.BackColor = Color.LightGoldenrodYellow;
            btnEliminarCompletos.Cursor = Cursors.Hand;
            btnEliminarCompletos.FlatStyle = FlatStyle.Flat;
            btnEliminarCompletos.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarCompletos.ForeColor = Color.SeaGreen;
            btnEliminarCompletos.Image = (Image)resources.GetObject("btnEliminarCompletos.Image");
            btnEliminarCompletos.Location = new Point(867, 6);
            btnEliminarCompletos.Margin = new Padding(4, 6, 4, 6);
            btnEliminarCompletos.Name = "btnEliminarCompletos";
            btnEliminarCompletos.Size = new Size(96, 72);
            btnEliminarCompletos.TabIndex = 44;
            btnEliminarCompletos.UseVisualStyleBackColor = false;
            btnEliminarCompletos.Visible = false;
            btnEliminarCompletos.Click += btnEliminarCompletos_Click;
            // 
            // btnCargarCompletos
            // 
            btnCargarCompletos.Anchor = AnchorStyles.None;
            btnCargarCompletos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCargarCompletos.BackColor = Color.Lavender;
            btnCargarCompletos.Cursor = Cursors.Hand;
            btnCargarCompletos.FlatStyle = FlatStyle.Flat;
            btnCargarCompletos.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargarCompletos.ForeColor = Color.Blue;
            btnCargarCompletos.ImageAlign = ContentAlignment.MiddleLeft;
            btnCargarCompletos.Location = new Point(615, 30);
            btnCargarCompletos.Margin = new Padding(4, 6, 4, 6);
            btnCargarCompletos.Name = "btnCargarCompletos";
            btnCargarCompletos.Size = new Size(130, 36);
            btnCargarCompletos.TabIndex = 43;
            btnCargarCompletos.Text = "CARGAR";
            btnCargarCompletos.UseVisualStyleBackColor = false;
            btnCargarCompletos.Click += btnCargarCompletos_Click;
            // 
            // tablePlanesFinalizados
            // 
            tablePlanesFinalizados.AllowUserToAddRows = false;
            tablePlanesFinalizados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tablePlanesFinalizados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            tablePlanesFinalizados.Anchor = AnchorStyles.None;
            tablePlanesFinalizados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablePlanesFinalizados.BackgroundColor = Color.WhiteSmoke;
            tablePlanesFinalizados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablePlanesFinalizados.Location = new Point(6, 80);
            tablePlanesFinalizados.Name = "tablePlanesFinalizados";
            tablePlanesFinalizados.ReadOnly = true;
            tablePlanesFinalizados.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tablePlanesFinalizados.RowsDefaultCellStyle = dataGridViewCellStyle8;
            tablePlanesFinalizados.RowTemplate.Height = 30;
            tablePlanesFinalizados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablePlanesFinalizados.Size = new Size(957, 533);
            tablePlanesFinalizados.TabIndex = 42;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(394, 23);
            label1.TabIndex = 41;
            label1.Text = "Listado de Planes de Inversión Finalizados";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(24, 551);
            label4.Name = "label4";
            label4.Size = new Size(508, 20);
            label4.TabIndex = 59;
            label4.Text = "*     La fecha objetivo debe ser superior a la fecha de inicio del plan.";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(24, 576);
            label8.Name = "label8";
            label8.Size = new Size(396, 20);
            label8.TabIndex = 60;
            label8.Text = "**    El capital objetivo tiene que ser mayor a 0 (cero).";
            // 
            // UC_PlanInversion
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(tabControl1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "UC_PlanInversion";
            Size = new Size(977, 668);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablePlanesActivos).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablePlanesFinalizados).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCNIC;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtFatherName;
        private System.Windows.Forms.Label label14;
        private TabPage tabPage3;
        private Krypton.Toolkit.KryptonDateTimePicker dpFechaFin;
        private Label label16;
        private Button btnCancelar;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtCapital;
        private Label label20;
        private Krypton.Toolkit.KryptonDateTimePicker dpFechaInicio;
        private Label label19;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtDescripcion;
        private Label label11;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtNombre;
        private Button btnGuardar;
        private Label label17;
        private Label label18;
        private TabPage tabPage2;
        private Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox dp2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox dp1;
        private Button button2;
        private Button btnSave;
        private Label label3;
        private Label label9;
        private Label label7;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtnada2;
        private Label label12;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtnada;
        private Label label15;
        private DataGridView dataGridView2;
        private TabPage tabPage1;
        private Button btnVerPlan;
        private Button btnEditarPlan;
        private Button btnEliminarPlan;
        private Button btnCargarPlanes;
        private DataGridView tablePlanesActivos;
        private Label label6;
        private TabControl tabControl1;
        private TabPage tabPage4;
        private Button btnVerCompletos;
        private Button btnCargarCompletos;
        private DataGridView tablePlanesFinalizados;
        private Label label1;
        private Button btnEliminarCompletos;
        private Label label2;
        private Label label8;
        private Label label4;
    }
}
