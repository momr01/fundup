namespace CapaPresentacion
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblCopyright = new Label();
            button1 = new Button();
            pictureLogo = new PictureBox();
            gbLogin = new GroupBox();
            lblRegistrate = new Label();
            txtPassword = new MaterialSkin.Controls.MaterialTextBox2();
            txtEmail = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            lblRegister = new Label();
            lblPassword = new Label();
            lblEmail = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            gbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lblCopyright
            // 
            lblCopyright.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCopyright.AutoSize = true;
            lblCopyright.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCopyright.ForeColor = Color.FromArgb(64, 64, 64);
            lblCopyright.Location = new Point(12, 693);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(250, 17);
            lblCopyright.TabIndex = 5;
            lblCopyright.Text = "Copyrights © 2023. All Rights Reserved";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(30, 50, 94);
            button1.Location = new Point(1100, 2);
            button1.Name = "button1";
            button1.Size = new Size(98, 64);
            button1.TabIndex = 11;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureLogo
            // 
            pictureLogo.Anchor = AnchorStyles.None;
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(12, 95);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(588, 532);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 12;
            pictureLogo.TabStop = false;
            // 
            // gbLogin
            // 
            gbLogin.Anchor = AnchorStyles.None;
            gbLogin.Controls.Add(lblRegistrate);
            gbLogin.Controls.Add(txtPassword);
            gbLogin.Controls.Add(txtEmail);
            gbLogin.Controls.Add(btnLogin);
            gbLogin.Controls.Add(lblRegister);
            gbLogin.Controls.Add(lblPassword);
            gbLogin.Controls.Add(lblEmail);
            gbLogin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbLogin.Location = new Point(618, 265);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(367, 324);
            gbLogin.TabIndex = 13;
            gbLogin.TabStop = false;
            gbLogin.Text = "Iniciar Sesión";
            // 
            // lblRegistrate
            // 
            lblRegistrate.Anchor = AnchorStyles.None;
            lblRegistrate.AutoSize = true;
            lblRegistrate.Cursor = Cursors.Hand;
            lblRegistrate.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblRegistrate.ForeColor = Color.DarkBlue;
            lblRegistrate.Location = new Point(212, 289);
            lblRegistrate.Name = "lblRegistrate";
            lblRegistrate.Size = new Size(90, 18);
            lblRegistrate.TabIndex = 16;
            lblRegistrate.Text = "REGISTRATE";
            lblRegistrate.Click += lblRegistrate_Click;
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.BackgroundImageLayout = ImageLayout.None;
            txtPassword.CharacterCasing = CharacterCasing.Normal;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.HideSelection = true;
            txtPassword.Hint = "Ingrese su contraseña";
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(29, 151);
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PrefixSuffixText = null;
            txtPassword.ReadOnly = false;
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(316, 48);
            txtPassword.TabIndex = 15;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "Ingrese su email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(29, 61);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(316, 48);
            txtEmail.TabIndex = 14;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // btnLogin
            // 
            btnLogin.ActiveBorderThickness = 1;
            btnLogin.ActiveCornerRadius = 20;
            btnLogin.ActiveFillColor = Color.FromArgb(30, 50, 94);
            btnLogin.ActiveForecolor = Color.White;
            btnLogin.ActiveLineColor = Color.FromArgb(30, 50, 94);
            btnLogin.BackColor = Color.White;
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.ButtonText = "Iniciar Sesión";
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.SeaGreen;
            btnLogin.IdleBorderThickness = 1;
            btnLogin.IdleCornerRadius = 40;
            btnLogin.IdleFillColor = Color.FromArgb(30, 50, 94);
            btnLogin.IdleForecolor = Color.White;
            btnLogin.IdleLineColor = Color.FromArgb(30, 50, 94);
            btnLogin.Location = new Point(26, 224);
            btnLogin.Margin = new Padding(5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(319, 60);
            btnLogin.TabIndex = 2;
            btnLogin.TextAlign = ContentAlignment.MiddleCenter;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblRegister
            // 
            lblRegister.Anchor = AnchorStyles.None;
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblRegister.ForeColor = Color.FromArgb(64, 64, 64);
            lblRegister.Location = new Point(26, 289);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(180, 18);
            lblRegister.TabIndex = 0;
            lblRegister.Text = "No tienes una cuenta? ";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.FromArgb(64, 64, 64);
            lblPassword.Location = new Point(26, 130);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(97, 18);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Contraseña:";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.FromArgb(64, 64, 64);
            lblEmail.Location = new Point(26, 40);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(52, 18);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(gbLogin);
            Controls.Add(pictureLogo);
            Controls.Add(button1);
            Controls.Add(lblCopyright);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "Form_Login";
            WindowState = FormWindowState.Maximized;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCopyright;
        private Button button1;
        private PictureBox pictureLogo;
        private GroupBox gbLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Label lblRegister;
        private Label lblPassword;
        private Label lblEmail;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialTextBox2 txtPassword;
        private Label lblRegistrate;
    }
}