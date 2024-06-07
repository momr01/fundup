namespace CapaPresentacion.Formularios
{
    partial class EditarGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarGasto));
            panel5 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCancelar = new Button();
            txtDescripcion = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            txtImporte = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            dpFecha = new Krypton.Toolkit.KryptonDateTimePicker();
            cbCategoria = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            categoriaBindingSource = new BindingSource(components);
            btnEditar = new Button();
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
            panel5.Size = new Size(10, 382);
            panel5.TabIndex = 92;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 50, 94);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(816, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 382);
            panel1.TabIndex = 93;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 50, 94);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(806, 10);
            panel2.TabIndex = 94;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 50, 94);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(10, 372);
            panel3.Name = "panel3";
            panel3.Size = new Size(806, 10);
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
            label1.Location = new Point(340, 38);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 97;
            label1.Text = "Editar Gasto";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(50, 117);
            label4.Name = "label4";
            label4.Size = new Size(112, 18);
            label4.TabIndex = 99;
            label4.Text = "Descripción: *";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(435, 117);
            label2.Name = "label2";
            label2.Size = new Size(80, 18);
            label2.TabIndex = 101;
            label2.Text = "Importe: *";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(64, 209);
            label5.Name = "label5";
            label5.Size = new Size(98, 18);
            label5.TabIndex = 101;
            label5.Text = "Categoría: *";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(446, 210);
            label6.Name = "label6";
            label6.Size = new Size(69, 18);
            label6.TabIndex = 101;
            label6.Text = "Fecha: *";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.DimGray;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(624, 300);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 41);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.AnimateReadOnly = false;
            txtDescripcion.AutoCompleteMode = AutoCompleteMode.None;
            txtDescripcion.AutoCompleteSource = AutoCompleteSource.None;
            txtDescripcion.BackgroundImageLayout = ImageLayout.None;
            txtDescripcion.CharacterCasing = CharacterCasing.Normal;
            txtDescripcion.Depth = 0;
            txtDescripcion.ErrorMessage = "La descripción es requerida";
            txtDescripcion.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescripcion.HideSelection = true;
            txtDescripcion.Hint = "Ingrese una descripción";
            txtDescripcion.LeadingIcon = null;
            txtDescripcion.Location = new Point(163, 102);
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
            txtDescripcion.Size = new Size(250, 48);
            txtDescripcion.TabIndex = 106;
            txtDescripcion.TabStop = false;
            txtDescripcion.TextAlign = HorizontalAlignment.Left;
            txtDescripcion.TrailingIcon = null;
            txtDescripcion.UseSystemPasswordChar = false;
            // 
            // txtImporte
            // 
            txtImporte.AnimateReadOnly = false;
            txtImporte.AutoCompleteMode = AutoCompleteMode.None;
            txtImporte.AutoCompleteSource = AutoCompleteSource.None;
            txtImporte.BackgroundImageLayout = ImageLayout.None;
            txtImporte.CharacterCasing = CharacterCasing.Normal;
            txtImporte.Depth = 0;
            txtImporte.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtImporte.HideSelection = true;
            txtImporte.Hint = "Valor numérico";
            txtImporte.LeadingIcon = null;
            txtImporte.Location = new Point(516, 102);
            txtImporte.MaxLength = 32767;
            txtImporte.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtImporte.Name = "txtImporte";
            txtImporte.PasswordChar = '\0';
            txtImporte.PrefixSuffixText = null;
            txtImporte.ReadOnly = false;
            txtImporte.RightToLeft = RightToLeft.No;
            txtImporte.SelectedText = "";
            txtImporte.SelectionLength = 0;
            txtImporte.SelectionStart = 0;
            txtImporte.ShortcutsEnabled = true;
            txtImporte.Size = new Size(250, 48);
            txtImporte.TabIndex = 107;
            txtImporte.TabStop = false;
            txtImporte.TextAlign = HorizontalAlignment.Left;
            txtImporte.TrailingIcon = null;
            txtImporte.UseSystemPasswordChar = false;
            // 
            // dpFecha
            // 
            dpFecha.CornerRoundingRadius = -1F;
            dpFecha.Location = new Point(516, 207);
            dpFecha.Name = "dpFecha";
            dpFecha.Size = new Size(250, 21);
            dpFecha.TabIndex = 110;
            // 
            // cbCategoria
            // 
            cbCategoria.AutoResize = false;
            cbCategoria.BackColor = Color.FromArgb(255, 255, 255);
            cbCategoria.DataSource = categoriaBindingSource;
            cbCategoria.Depth = 0;
            cbCategoria.DisplayMember = "NombreCategoria";
            cbCategoria.DrawMode = DrawMode.OwnerDrawVariable;
            cbCategoria.DropDownHeight = 174;
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.DropDownWidth = 121;
            cbCategoria.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbCategoria.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Hint = "Seleccionar";
            cbCategoria.IntegralHeight = false;
            cbCategoria.ItemHeight = 43;
            cbCategoria.Location = new Point(163, 194);
            cbCategoria.MaxDropDownItems = 4;
            cbCategoria.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(250, 49);
            cbCategoria.StartIndex = 0;
            cbCategoria.TabIndex = 111;
            cbCategoria.ValueMember = "IdCategoria";
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
            btnEditar.Location = new Point(445, 300);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(142, 41);
            btnEditar.TabIndex = 112;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(16, 353);
            label8.Name = "label8";
            label8.Size = new Size(153, 16);
            label8.TabIndex = 120;
            label8.Text = "* Campos obligatorios";
            // 
            // EditarGasto
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(826, 382);
            Controls.Add(label8);
            Controls.Add(btnEditar);
            Controls.Add(cbCategoria);
            Controls.Add(dpFecha);
            Controls.Add(txtImporte);
            Controls.Add(txtDescripcion);
            Controls.Add(btnCancelar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditarGasto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_AddWork";
            Load += EditarGasto_Load;
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
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtDescripcion;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtImporte;
        private Krypton.Toolkit.KryptonDateTimePicker dpFecha;
        private MaterialSkin2DotNet.Controls.MaterialComboBox cbCategoria;
        private BindingSource categoriaBindingSource;
        private Button btnEditar;
        private Label label8;
        //private DragControlDemo.DragControl dragControl1;
    }
}