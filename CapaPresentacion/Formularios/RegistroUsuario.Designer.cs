namespace CapaPresentacion.Formularios
{
    partial class RegistroUsuarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuarioForm));
            panel5 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            gbDatosPersonales = new GroupBox();
            txtRegistroDni = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            txtRegistroApellido = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            txtRegistroNombre = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            cboRegistroLocalidad = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            localidadBindingSource = new BindingSource(components);
            cboRegistroProvincia = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            provinciaBindingSource = new BindingSource(components);
            lblRegistroApellido = new Label();
            gbRegistroDomicilio = new GroupBox();
            txtRegistroNroDomicilio = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            txtRegistroDomicilio = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            lblRegistroProvincia = new Label();
            dtRegistroFechaNacimiento = new DateTimePicker();
            lblRegistroLocalidad = new Label();
            lblRegistroFechaNacimiento = new Label();
            lblRegistroDni = new Label();
            lblRegistroNombre = new Label();
            gbDatosUsuario = new GroupBox();
            txtRegistroContraseña = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            txtRegistroEmail = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            lblRegistroContraseña = new Label();
            lblRegistroEmail = new Label();
            btnRegistrarse = new Bunifu.Framework.UI.BunifuThinButton2();
            btnCancelar = new Button();
            gbDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)localidadBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)provinciaBindingSource).BeginInit();
            gbRegistroDomicilio.SuspendLayout();
            gbDatosUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 50, 94);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 540);
            panel5.TabIndex = 92;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 50, 94);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1167, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 540);
            panel1.TabIndex = 93;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 50, 94);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1157, 10);
            panel2.TabIndex = 94;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 50, 94);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(10, 530);
            panel3.Name = "panel3";
            panel3.Size = new Size(1157, 10);
            panel3.TabIndex = 95;
            // 
            // gbDatosPersonales
            // 
            gbDatosPersonales.Controls.Add(txtRegistroDni);
            gbDatosPersonales.Controls.Add(txtRegistroApellido);
            gbDatosPersonales.Controls.Add(txtRegistroNombre);
            gbDatosPersonales.Controls.Add(cboRegistroLocalidad);
            gbDatosPersonales.Controls.Add(cboRegistroProvincia);
            gbDatosPersonales.Controls.Add(lblRegistroApellido);
            gbDatosPersonales.Controls.Add(gbRegistroDomicilio);
            gbDatosPersonales.Controls.Add(lblRegistroProvincia);
            gbDatosPersonales.Controls.Add(dtRegistroFechaNacimiento);
            gbDatosPersonales.Controls.Add(lblRegistroLocalidad);
            gbDatosPersonales.Controls.Add(lblRegistroFechaNacimiento);
            gbDatosPersonales.Controls.Add(lblRegistroDni);
            gbDatosPersonales.Controls.Add(lblRegistroNombre);
            gbDatosPersonales.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbDatosPersonales.Location = new Point(12, 12);
            gbDatosPersonales.Name = "gbDatosPersonales";
            gbDatosPersonales.Size = new Size(699, 515);
            gbDatosPersonales.TabIndex = 0;
            gbDatosPersonales.TabStop = false;
            gbDatosPersonales.Text = "Datos personales";
            // 
            // txtRegistroDni
            // 
            txtRegistroDni.AnimateReadOnly = false;
            txtRegistroDni.AutoCompleteMode = AutoCompleteMode.None;
            txtRegistroDni.AutoCompleteSource = AutoCompleteSource.None;
            txtRegistroDni.BackgroundImageLayout = ImageLayout.None;
            txtRegistroDni.CharacterCasing = CharacterCasing.Normal;
            txtRegistroDni.Depth = 0;
            txtRegistroDni.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRegistroDni.HideSelection = true;
            txtRegistroDni.Hint = "Ingrese su Dni";
            txtRegistroDni.LeadingIcon = null;
            txtRegistroDni.Location = new Point(31, 184);
            txtRegistroDni.MaxLength = 10;
            txtRegistroDni.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtRegistroDni.Name = "txtRegistroDni";
            txtRegistroDni.PasswordChar = '\0';
            txtRegistroDni.PrefixSuffixText = null;
            txtRegistroDni.ReadOnly = false;
            txtRegistroDni.RightToLeft = RightToLeft.No;
            txtRegistroDni.SelectedText = "";
            txtRegistroDni.SelectionLength = 0;
            txtRegistroDni.SelectionStart = 0;
            txtRegistroDni.ShortcutsEnabled = true;
            txtRegistroDni.Size = new Size(285, 48);
            txtRegistroDni.TabIndex = 39;
            txtRegistroDni.TabStop = false;
            txtRegistroDni.TextAlign = HorizontalAlignment.Left;
            txtRegistroDni.TrailingIcon = null;
            txtRegistroDni.UseSystemPasswordChar = false;
            txtRegistroDni.KeyPress += txtRegistroDni_KeyPress;
            // 
            // txtRegistroApellido
            // 
            txtRegistroApellido.AnimateReadOnly = false;
            txtRegistroApellido.AutoCompleteMode = AutoCompleteMode.None;
            txtRegistroApellido.AutoCompleteSource = AutoCompleteSource.None;
            txtRegistroApellido.BackgroundImageLayout = ImageLayout.None;
            txtRegistroApellido.CharacterCasing = CharacterCasing.Normal;
            txtRegistroApellido.Depth = 0;
            txtRegistroApellido.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRegistroApellido.HideSelection = true;
            txtRegistroApellido.Hint = "Ingrese su apellido";
            txtRegistroApellido.LeadingIcon = null;
            txtRegistroApellido.Location = new Point(375, 67);
            txtRegistroApellido.MaxLength = 100;
            txtRegistroApellido.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtRegistroApellido.Name = "txtRegistroApellido";
            txtRegistroApellido.PasswordChar = '\0';
            txtRegistroApellido.PrefixSuffixText = null;
            txtRegistroApellido.ReadOnly = false;
            txtRegistroApellido.RightToLeft = RightToLeft.No;
            txtRegistroApellido.SelectedText = "";
            txtRegistroApellido.SelectionLength = 0;
            txtRegistroApellido.SelectionStart = 0;
            txtRegistroApellido.ShortcutsEnabled = true;
            txtRegistroApellido.Size = new Size(285, 48);
            txtRegistroApellido.TabIndex = 38;
            txtRegistroApellido.TabStop = false;
            txtRegistroApellido.TextAlign = HorizontalAlignment.Left;
            txtRegistroApellido.TrailingIcon = null;
            txtRegistroApellido.UseSystemPasswordChar = false;
            txtRegistroApellido.KeyPress += txtRegistroApellido_KeyPress;
            // 
            // txtRegistroNombre
            // 
            txtRegistroNombre.AnimateReadOnly = false;
            txtRegistroNombre.AutoCompleteMode = AutoCompleteMode.None;
            txtRegistroNombre.AutoCompleteSource = AutoCompleteSource.None;
            txtRegistroNombre.BackgroundImageLayout = ImageLayout.None;
            txtRegistroNombre.CharacterCasing = CharacterCasing.Normal;
            txtRegistroNombre.Depth = 0;
            txtRegistroNombre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRegistroNombre.HideSelection = true;
            txtRegistroNombre.Hint = "Ingrese su nombre";
            txtRegistroNombre.LeadingIcon = null;
            txtRegistroNombre.Location = new Point(31, 67);
            txtRegistroNombre.MaxLength = 100;
            txtRegistroNombre.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtRegistroNombre.Name = "txtRegistroNombre";
            txtRegistroNombre.PasswordChar = '\0';
            txtRegistroNombre.PrefixSuffixText = null;
            txtRegistroNombre.ReadOnly = false;
            txtRegistroNombre.RightToLeft = RightToLeft.No;
            txtRegistroNombre.SelectedText = "";
            txtRegistroNombre.SelectionLength = 0;
            txtRegistroNombre.SelectionStart = 0;
            txtRegistroNombre.ShortcutsEnabled = true;
            txtRegistroNombre.Size = new Size(285, 48);
            txtRegistroNombre.TabIndex = 37;
            txtRegistroNombre.TabStop = false;
            txtRegistroNombre.TextAlign = HorizontalAlignment.Left;
            txtRegistroNombre.TrailingIcon = null;
            txtRegistroNombre.UseSystemPasswordChar = false;
            txtRegistroNombre.KeyPress += txtRegistroNombre_KeyPress;
            // 
            // cboRegistroLocalidad
            // 
            cboRegistroLocalidad.AutoResize = false;
            cboRegistroLocalidad.BackColor = Color.FromArgb(255, 255, 255);
            cboRegistroLocalidad.DataSource = localidadBindingSource;
            cboRegistroLocalidad.Depth = 0;
            cboRegistroLocalidad.DisplayMember = "nombreLocalidad";
            cboRegistroLocalidad.DrawMode = DrawMode.OwnerDrawVariable;
            cboRegistroLocalidad.DropDownHeight = 174;
            cboRegistroLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRegistroLocalidad.DropDownWidth = 121;
            cboRegistroLocalidad.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboRegistroLocalidad.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboRegistroLocalidad.FormattingEnabled = true;
            cboRegistroLocalidad.IntegralHeight = false;
            cboRegistroLocalidad.ItemHeight = 43;
            cboRegistroLocalidad.Location = new Point(375, 437);
            cboRegistroLocalidad.MaxDropDownItems = 4;
            cboRegistroLocalidad.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            cboRegistroLocalidad.Name = "cboRegistroLocalidad";
            cboRegistroLocalidad.Size = new Size(285, 49);
            cboRegistroLocalidad.StartIndex = 0;
            cboRegistroLocalidad.TabIndex = 33;
            cboRegistroLocalidad.ValueMember = "idLocalidad";
            // 
            // localidadBindingSource
            // 
            localidadBindingSource.DataSource = typeof(Entidades.Localidad);
            // 
            // cboRegistroProvincia
            // 
            cboRegistroProvincia.AutoResize = false;
            cboRegistroProvincia.BackColor = Color.FromArgb(255, 255, 255);
            cboRegistroProvincia.DataSource = provinciaBindingSource;
            cboRegistroProvincia.Depth = 0;
            cboRegistroProvincia.DisplayMember = "nombreProvincia";
            cboRegistroProvincia.DrawMode = DrawMode.OwnerDrawVariable;
            cboRegistroProvincia.DropDownHeight = 174;
            cboRegistroProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRegistroProvincia.DropDownWidth = 121;
            cboRegistroProvincia.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboRegistroProvincia.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboRegistroProvincia.FormattingEnabled = true;
            cboRegistroProvincia.IntegralHeight = false;
            cboRegistroProvincia.ItemHeight = 43;
            cboRegistroProvincia.Location = new Point(34, 437);
            cboRegistroProvincia.MaxDropDownItems = 4;
            cboRegistroProvincia.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            cboRegistroProvincia.Name = "cboRegistroProvincia";
            cboRegistroProvincia.Size = new Size(285, 49);
            cboRegistroProvincia.StartIndex = 0;
            cboRegistroProvincia.TabIndex = 32;
            cboRegistroProvincia.ValueMember = "idProvincia";
            cboRegistroProvincia.SelectedValueChanged += cboRegistroProvincia_SelectedValueChanged;
            // 
            // provinciaBindingSource
            // 
            provinciaBindingSource.DataSource = typeof(Entidades.Provincia);
            // 
            // lblRegistroApellido
            // 
            lblRegistroApellido.Anchor = AnchorStyles.None;
            lblRegistroApellido.AutoSize = true;
            lblRegistroApellido.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistroApellido.ForeColor = Color.FromArgb(64, 64, 64);
            lblRegistroApellido.Location = new Point(376, 36);
            lblRegistroApellido.Name = "lblRegistroApellido";
            lblRegistroApellido.Size = new Size(75, 18);
            lblRegistroApellido.TabIndex = 30;
            lblRegistroApellido.Text = "Apellido:";
            // 
            // gbRegistroDomicilio
            // 
            gbRegistroDomicilio.Controls.Add(txtRegistroNroDomicilio);
            gbRegistroDomicilio.Controls.Add(txtRegistroDomicilio);
            gbRegistroDomicilio.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            gbRegistroDomicilio.Location = new Point(31, 252);
            gbRegistroDomicilio.Name = "gbRegistroDomicilio";
            gbRegistroDomicilio.Size = new Size(629, 118);
            gbRegistroDomicilio.TabIndex = 29;
            gbRegistroDomicilio.TabStop = false;
            gbRegistroDomicilio.Text = "Domicilio";
            // 
            // txtRegistroNroDomicilio
            // 
            txtRegistroNroDomicilio.AnimateReadOnly = false;
            txtRegistroNroDomicilio.AutoCompleteMode = AutoCompleteMode.None;
            txtRegistroNroDomicilio.AutoCompleteSource = AutoCompleteSource.None;
            txtRegistroNroDomicilio.BackgroundImageLayout = ImageLayout.None;
            txtRegistroNroDomicilio.CharacterCasing = CharacterCasing.Normal;
            txtRegistroNroDomicilio.Depth = 0;
            txtRegistroNroDomicilio.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRegistroNroDomicilio.HideSelection = true;
            txtRegistroNroDomicilio.Hint = "Ingrese Nro";
            txtRegistroNroDomicilio.LeadingIcon = null;
            txtRegistroNroDomicilio.Location = new Point(398, 46);
            txtRegistroNroDomicilio.MaxLength = 5;
            txtRegistroNroDomicilio.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtRegistroNroDomicilio.Name = "txtRegistroNroDomicilio";
            txtRegistroNroDomicilio.PasswordChar = '\0';
            txtRegistroNroDomicilio.PrefixSuffixText = null;
            txtRegistroNroDomicilio.ReadOnly = false;
            txtRegistroNroDomicilio.RightToLeft = RightToLeft.No;
            txtRegistroNroDomicilio.SelectedText = "";
            txtRegistroNroDomicilio.SelectionLength = 0;
            txtRegistroNroDomicilio.SelectionStart = 0;
            txtRegistroNroDomicilio.ShortcutsEnabled = true;
            txtRegistroNroDomicilio.Size = new Size(209, 48);
            txtRegistroNroDomicilio.TabIndex = 41;
            txtRegistroNroDomicilio.TabStop = false;
            txtRegistroNroDomicilio.TextAlign = HorizontalAlignment.Left;
            txtRegistroNroDomicilio.TrailingIcon = null;
            txtRegistroNroDomicilio.UseSystemPasswordChar = false;
            txtRegistroNroDomicilio.KeyPress += txtRegistroNroDomicilio_KeyPress;
            // 
            // txtRegistroDomicilio
            // 
            txtRegistroDomicilio.AnimateReadOnly = false;
            txtRegistroDomicilio.AutoCompleteMode = AutoCompleteMode.None;
            txtRegistroDomicilio.AutoCompleteSource = AutoCompleteSource.None;
            txtRegistroDomicilio.BackgroundImageLayout = ImageLayout.None;
            txtRegistroDomicilio.CharacterCasing = CharacterCasing.Normal;
            txtRegistroDomicilio.Depth = 0;
            txtRegistroDomicilio.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRegistroDomicilio.HideSelection = true;
            txtRegistroDomicilio.Hint = "Ingrese su calle";
            txtRegistroDomicilio.LeadingIcon = null;
            txtRegistroDomicilio.Location = new Point(17, 46);
            txtRegistroDomicilio.MaxLength = 200;
            txtRegistroDomicilio.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtRegistroDomicilio.Name = "txtRegistroDomicilio";
            txtRegistroDomicilio.PasswordChar = '\0';
            txtRegistroDomicilio.PrefixSuffixText = null;
            txtRegistroDomicilio.ReadOnly = false;
            txtRegistroDomicilio.RightToLeft = RightToLeft.No;
            txtRegistroDomicilio.SelectedText = "";
            txtRegistroDomicilio.SelectionLength = 0;
            txtRegistroDomicilio.SelectionStart = 0;
            txtRegistroDomicilio.ShortcutsEnabled = true;
            txtRegistroDomicilio.Size = new Size(330, 48);
            txtRegistroDomicilio.TabIndex = 40;
            txtRegistroDomicilio.TabStop = false;
            txtRegistroDomicilio.TextAlign = HorizontalAlignment.Left;
            txtRegistroDomicilio.TrailingIcon = null;
            txtRegistroDomicilio.UseSystemPasswordChar = false;
            // 
            // lblRegistroProvincia
            // 
            lblRegistroProvincia.Anchor = AnchorStyles.None;
            lblRegistroProvincia.AutoSize = true;
            lblRegistroProvincia.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistroProvincia.ForeColor = Color.FromArgb(64, 64, 64);
            lblRegistroProvincia.Location = new Point(37, 400);
            lblRegistroProvincia.Name = "lblRegistroProvincia";
            lblRegistroProvincia.Size = new Size(76, 18);
            lblRegistroProvincia.TabIndex = 27;
            lblRegistroProvincia.Text = "Provincia";
            // 
            // dtRegistroFechaNacimiento
            // 
            dtRegistroFechaNacimiento.CalendarMonthBackground = Color.Silver;
            dtRegistroFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtRegistroFechaNacimiento.Location = new Point(375, 184);
            dtRegistroFechaNacimiento.MaxDate = new DateTime(2023, 10, 9, 9, 24, 8, 0);
            dtRegistroFechaNacimiento.Name = "dtRegistroFechaNacimiento";
            dtRegistroFechaNacimiento.Size = new Size(285, 27);
            dtRegistroFechaNacimiento.TabIndex = 19;
            dtRegistroFechaNacimiento.Value = new DateTime(2023, 10, 8, 9, 36, 42, 0);
            // 
            // lblRegistroLocalidad
            // 
            lblRegistroLocalidad.Anchor = AnchorStyles.None;
            lblRegistroLocalidad.AutoSize = true;
            lblRegistroLocalidad.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistroLocalidad.ForeColor = Color.FromArgb(64, 64, 64);
            lblRegistroLocalidad.Location = new Point(378, 400);
            lblRegistroLocalidad.Name = "lblRegistroLocalidad";
            lblRegistroLocalidad.Size = new Size(83, 18);
            lblRegistroLocalidad.TabIndex = 26;
            lblRegistroLocalidad.Text = "Localidad";
            // 
            // lblRegistroFechaNacimiento
            // 
            lblRegistroFechaNacimiento.Anchor = AnchorStyles.None;
            lblRegistroFechaNacimiento.AutoSize = true;
            lblRegistroFechaNacimiento.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistroFechaNacimiento.ForeColor = Color.FromArgb(64, 64, 64);
            lblRegistroFechaNacimiento.Location = new Point(377, 137);
            lblRegistroFechaNacimiento.Name = "lblRegistroFechaNacimiento";
            lblRegistroFechaNacimiento.Size = new Size(170, 18);
            lblRegistroFechaNacimiento.TabIndex = 18;
            lblRegistroFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblRegistroDni
            // 
            lblRegistroDni.Anchor = AnchorStyles.None;
            lblRegistroDni.AutoSize = true;
            lblRegistroDni.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistroDni.ForeColor = Color.FromArgb(64, 64, 64);
            lblRegistroDni.Location = new Point(35, 137);
            lblRegistroDni.Name = "lblRegistroDni";
            lblRegistroDni.Size = new Size(181, 18);
            lblRegistroDni.TabIndex = 16;
            lblRegistroDni.Text = "Numero de documento";
            // 
            // lblRegistroNombre
            // 
            lblRegistroNombre.Anchor = AnchorStyles.None;
            lblRegistroNombre.AutoSize = true;
            lblRegistroNombre.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistroNombre.ForeColor = Color.FromArgb(64, 64, 64);
            lblRegistroNombre.Location = new Point(33, 36);
            lblRegistroNombre.Name = "lblRegistroNombre";
            lblRegistroNombre.Size = new Size(78, 18);
            lblRegistroNombre.TabIndex = 1;
            lblRegistroNombre.Text = "Nombres:";
            // 
            // gbDatosUsuario
            // 
            gbDatosUsuario.Controls.Add(txtRegistroContraseña);
            gbDatosUsuario.Controls.Add(txtRegistroEmail);
            gbDatosUsuario.Controls.Add(lblRegistroContraseña);
            gbDatosUsuario.Controls.Add(lblRegistroEmail);
            gbDatosUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbDatosUsuario.Location = new Point(754, 12);
            gbDatosUsuario.Name = "gbDatosUsuario";
            gbDatosUsuario.Size = new Size(409, 267);
            gbDatosUsuario.TabIndex = 1;
            gbDatosUsuario.TabStop = false;
            gbDatosUsuario.Text = "Datos de usuario";
            // 
            // txtRegistroContraseña
            // 
            txtRegistroContraseña.AnimateReadOnly = false;
            txtRegistroContraseña.AutoCompleteMode = AutoCompleteMode.None;
            txtRegistroContraseña.AutoCompleteSource = AutoCompleteSource.None;
            txtRegistroContraseña.BackgroundImageLayout = ImageLayout.None;
            txtRegistroContraseña.CharacterCasing = CharacterCasing.Normal;
            txtRegistroContraseña.Depth = 0;
            txtRegistroContraseña.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRegistroContraseña.HideSelection = true;
            txtRegistroContraseña.Hint = "Ingrese su contraseña";
            txtRegistroContraseña.LeadingIcon = null;
            txtRegistroContraseña.Location = new Point(21, 184);
            txtRegistroContraseña.MaxLength = 20;
            txtRegistroContraseña.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtRegistroContraseña.Name = "txtRegistroContraseña";
            txtRegistroContraseña.PasswordChar = '\0';
            txtRegistroContraseña.PrefixSuffixText = null;
            txtRegistroContraseña.ReadOnly = false;
            txtRegistroContraseña.RightToLeft = RightToLeft.No;
            txtRegistroContraseña.SelectedText = "";
            txtRegistroContraseña.SelectionLength = 0;
            txtRegistroContraseña.SelectionStart = 0;
            txtRegistroContraseña.ShortcutsEnabled = true;
            txtRegistroContraseña.Size = new Size(368, 48);
            txtRegistroContraseña.TabIndex = 43;
            txtRegistroContraseña.TabStop = false;
            txtRegistroContraseña.TextAlign = HorizontalAlignment.Left;
            txtRegistroContraseña.TrailingIcon = null;
            txtRegistroContraseña.UseSystemPasswordChar = false;
            txtRegistroContraseña.KeyPress += txtRegistroContraseña_KeyPress;
            // 
            // txtRegistroEmail
            // 
            txtRegistroEmail.AnimateReadOnly = false;
            txtRegistroEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtRegistroEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtRegistroEmail.BackgroundImageLayout = ImageLayout.None;
            txtRegistroEmail.CharacterCasing = CharacterCasing.Normal;
            txtRegistroEmail.Depth = 0;
            txtRegistroEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRegistroEmail.HideSelection = true;
            txtRegistroEmail.Hint = "Ingrese su Email";
            txtRegistroEmail.LeadingIcon = null;
            txtRegistroEmail.Location = new Point(21, 67);
            txtRegistroEmail.MaxLength = 100;
            txtRegistroEmail.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtRegistroEmail.Name = "txtRegistroEmail";
            txtRegistroEmail.PasswordChar = '\0';
            txtRegistroEmail.PrefixSuffixText = null;
            txtRegistroEmail.ReadOnly = false;
            txtRegistroEmail.RightToLeft = RightToLeft.No;
            txtRegistroEmail.SelectedText = "";
            txtRegistroEmail.SelectionLength = 0;
            txtRegistroEmail.SelectionStart = 0;
            txtRegistroEmail.ShortcutsEnabled = true;
            txtRegistroEmail.Size = new Size(368, 48);
            txtRegistroEmail.TabIndex = 42;
            txtRegistroEmail.TabStop = false;
            txtRegistroEmail.TextAlign = HorizontalAlignment.Left;
            txtRegistroEmail.TrailingIcon = null;
            txtRegistroEmail.UseSystemPasswordChar = false;
            // 
            // lblRegistroContraseña
            // 
            lblRegistroContraseña.Anchor = AnchorStyles.None;
            lblRegistroContraseña.AutoSize = true;
            lblRegistroContraseña.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistroContraseña.ForeColor = Color.FromArgb(64, 64, 64);
            lblRegistroContraseña.Location = new Point(24, 137);
            lblRegistroContraseña.Name = "lblRegistroContraseña";
            lblRegistroContraseña.Size = new Size(93, 18);
            lblRegistroContraseña.TabIndex = 20;
            lblRegistroContraseña.Text = "Contraseña";
            // 
            // lblRegistroEmail
            // 
            lblRegistroEmail.Anchor = AnchorStyles.None;
            lblRegistroEmail.AutoSize = true;
            lblRegistroEmail.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistroEmail.ForeColor = Color.FromArgb(64, 64, 64);
            lblRegistroEmail.Location = new Point(24, 36);
            lblRegistroEmail.Name = "lblRegistroEmail";
            lblRegistroEmail.Size = new Size(52, 18);
            lblRegistroEmail.TabIndex = 19;
            lblRegistroEmail.Text = "Email:";
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.ActiveBorderThickness = 1;
            btnRegistrarse.ActiveCornerRadius = 20;
            btnRegistrarse.ActiveFillColor = Color.FromArgb(30, 50, 94);
            btnRegistrarse.ActiveForecolor = Color.White;
            btnRegistrarse.ActiveLineColor = Color.FromArgb(30, 50, 94);
            btnRegistrarse.BackColor = Color.White;
            btnRegistrarse.BackgroundImage = (Image)resources.GetObject("btnRegistrarse.BackgroundImage");
            btnRegistrarse.ButtonText = "Registrarse";
            btnRegistrarse.Cursor = Cursors.Hand;
            btnRegistrarse.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarse.ForeColor = Color.SeaGreen;
            btnRegistrarse.IdleBorderThickness = 1;
            btnRegistrarse.IdleCornerRadius = 40;
            btnRegistrarse.IdleFillColor = Color.FromArgb(30, 50, 94);
            btnRegistrarse.IdleForecolor = Color.White;
            btnRegistrarse.IdleLineColor = Color.FromArgb(30, 50, 94);
            btnRegistrarse.Location = new Point(812, 353);
            btnRegistrarse.Margin = new Padding(5);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(284, 60);
            btnRegistrarse.TabIndex = 3;
            btnRegistrarse.TextAlign = ContentAlignment.MiddleCenter;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.ControlDarkDark;
            btnCancelar.Location = new Point(900, 444);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 31);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // RegistroUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1177, 540);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarse);
            Controls.Add(gbDatosUsuario);
            Controls.Add(gbDatosPersonales);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "RegistroUsuarioForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar usuario";
            Load += RegistroUsuarioForm_Load;
            gbDatosPersonales.ResumeLayout(false);
            gbDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)localidadBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)provinciaBindingSource).EndInit();
            gbRegistroDomicilio.ResumeLayout(false);
            gbDatosUsuario.ResumeLayout(false);
            gbDatosUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private GroupBox gbDatosPersonales;
        private Label lblRegistroNombre;
        private Label lblRegistroDni;
        private Label lblRegistroFechaNacimiento;
        private GroupBox gbDatosUsuario;
        private Label lblRegistroEmail;
        private Label lblRegistroContraseña;
        private DateTimePicker dtRegistroFechaNacimiento;
        private Label lblRegistroLocalidad;
        private GroupBox gbRegistroDomicilio;
        private Label lblRegistroProvincia;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegistrarse;
        private Button btnCancelar;
        private Label lblRegistroApellido;
        private MaterialSkin2DotNet.Controls.MaterialComboBox cboRegistroProvincia;
        private MaterialSkin2DotNet.Controls.MaterialComboBox cboRegistroLocalidad;
        private BindingSource localidadBindingSource;
        private BindingSource provinciaBindingSource;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtRegistroNombre;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtRegistroDni;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtRegistroApellido;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtRegistroNroDomicilio;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtRegistroDomicilio;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtRegistroContraseña;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtRegistroEmail;
    }
}