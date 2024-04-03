namespace CapaPresentacion.UserControls
{
    partial class UC_Categorias
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
            components = new System.ComponentModel.Container();
            lblTotalCategorias = new Label();
            label6 = new Label();
            panel8 = new Panel();
            btnEditarCategoria = new Button();
            btnEliminarCategoria = new Button();
            label2 = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            tableCategorias = new DataGridView();
            lblTime = new Label();
            txtNombre = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            label4 = new Label();
            label1 = new Label();
            btnAgregarCategoria = new Button();
            txtBuscar = new TextBox();
            cbBuscar = new ComboBox();
            label5 = new Label();
            txtDescripcion = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            categoriaBindingSource = new BindingSource(components);
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblTotalCategorias
            // 
            lblTotalCategorias.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalCategorias.AutoSize = true;
            lblTotalCategorias.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalCategorias.ForeColor = Color.FromArgb(30, 50, 94);
            lblTotalCategorias.Location = new Point(230, 209);
            lblTotalCategorias.Name = "lblTotalCategorias";
            lblTotalCategorias.Size = new Size(0, 18);
            lblTotalCategorias.TabIndex = 24;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(30, 50, 94);
            label6.Location = new Point(6, 26);
            label6.Name = "label6";
            label6.Size = new Size(250, 17);
            label6.TabIndex = 2;
            label6.Text = "Copyrights © 2024. All rights Reserved.";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(btnEditarCategoria);
            panel8.Controls.Add(btnEliminarCategoria);
            panel8.Controls.Add(label6);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(33, 518);
            panel8.Name = "panel8";
            panel8.Size = new Size(892, 53);
            panel8.TabIndex = 85;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.Anchor = AnchorStyles.Right;
            btnEditarCategoria.Cursor = Cursors.Hand;
            btnEditarCategoria.Enabled = false;
            btnEditarCategoria.FlatStyle = FlatStyle.Flat;
            btnEditarCategoria.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarCategoria.ForeColor = Color.SeaGreen;
            btnEditarCategoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarCategoria.Location = new Point(566, 6);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.Size = new Size(173, 41);
            btnEditarCategoria.TabIndex = 5;
            btnEditarCategoria.Text = "Editar";
            btnEditarCategoria.UseVisualStyleBackColor = true;
            btnEditarCategoria.Click += btnEditarCategoria_Click;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.Anchor = AnchorStyles.Right;
            btnEliminarCategoria.Enabled = false;
            btnEliminarCategoria.FlatStyle = FlatStyle.Flat;
            btnEliminarCategoria.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarCategoria.ForeColor = Color.Red;
            btnEliminarCategoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarCategoria.Location = new Point(745, 6);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(141, 40);
            btnEliminarCategoria.TabIndex = 6;
            btnEliminarCategoria.Text = "Eliminar";
            btnEliminarCategoria.UseVisualStyleBackColor = true;
            btnEliminarCategoria.Click += btnEliminarCategoria_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(30, 50, 94);
            label2.Location = new Point(43, 209);
            label2.Name = "label2";
            label2.Size = new Size(180, 18);
            label2.TabIndex = 24;
            label2.Text = "No Total de Categorías:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(925, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(52, 571);
            panel7.TabIndex = 84;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(33, 571);
            panel6.TabIndex = 83;
            // 
            // tableCategorias
            // 
            tableCategorias.AllowUserToAddRows = false;
            tableCategorias.AllowUserToDeleteRows = false;
            tableCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableCategorias.BackgroundColor = Color.FromArgb(224, 224, 224);
            tableCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableCategorias.Dock = DockStyle.Bottom;
            tableCategorias.Location = new Point(33, 239);
            tableCategorias.MultiSelect = false;
            tableCategorias.Name = "tableCategorias";
            tableCategorias.ReadOnly = true;
            tableCategorias.RowTemplate.Height = 33;
            tableCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableCategorias.Size = new Size(892, 279);
            tableCategorias.TabIndex = 87;
            tableCategorias.CellClick += tableCategoria_CellClick;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.None;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.ForeColor = Color.FromArgb(30, 50, 94);
            lblTime.Location = new Point(400, 12);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(212, 19);
            lblTime.TabIndex = 88;
            lblTime.Text = "Agregar Nueva Categoría";
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
            txtNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.HideSelection = true;
            txtNombre.Hint = "Ingrese un nombre";
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(170, 53);
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
            txtNombre.Size = new Size(748, 48);
            txtNombre.TabIndex = 0;
            txtNombre.TabStop = false;
            txtNombre.TextAlign = HorizontalAlignment.Left;
            txtNombre.TrailingIcon = null;
            txtNombre.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(68, 74);
            label4.Name = "label4";
            label4.Size = new Size(72, 18);
            label4.TabIndex = 90;
            label4.Text = "Nombre:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(65, 140);
            label1.Name = "label1";
            label1.Size = new Size(101, 18);
            label1.TabIndex = 90;
            label1.Text = "Descripción:";
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.Anchor = AnchorStyles.None;
            btnAgregarCategoria.Cursor = Cursors.Hand;
            btnAgregarCategoria.FlatStyle = FlatStyle.Flat;
            btnAgregarCategoria.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarCategoria.ForeColor = Color.SeaGreen;
            btnAgregarCategoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarCategoria.Location = new Point(425, 186);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(119, 41);
            btnAgregarCategoria.TabIndex = 2;
            btnAgregarCategoria.Text = "Agregar";
            btnAgregarCategoria.UseVisualStyleBackColor = true;
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtBuscar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(778, 204);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(141, 27);
            txtBuscar.TabIndex = 4;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // cbBuscar
            // 
            cbBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cbBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBuscar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Items.AddRange(new object[] { "NOMBRE", "DESCRIPCION" });
            cbBuscar.Location = new Point(647, 205);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(125, 25);
            cbBuscar.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(555, 208);
            label5.Name = "label5";
            label5.Size = new Size(90, 18);
            label5.TabIndex = 92;
            label5.Text = "Buscar por:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.None;
            txtDescripcion.AnimateReadOnly = false;
            txtDescripcion.AutoCompleteMode = AutoCompleteMode.None;
            txtDescripcion.AutoCompleteSource = AutoCompleteSource.None;
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.BackgroundImageLayout = ImageLayout.None;
            txtDescripcion.CharacterCasing = CharacterCasing.Normal;
            txtDescripcion.Cursor = Cursors.IBeam;
            txtDescripcion.Depth = 0;
            txtDescripcion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.HideSelection = true;
            txtDescripcion.Hint = "Ingrese una descripción";
            txtDescripcion.LeadingIcon = null;
            txtDescripcion.Location = new Point(170, 119);
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
            txtDescripcion.Size = new Size(748, 48);
            txtDescripcion.TabIndex = 97;
            txtDescripcion.TabStop = false;
            txtDescripcion.TextAlign = HorizontalAlignment.Left;
            txtDescripcion.TrailingIcon = null;
            txtDescripcion.UseSystemPasswordChar = false;
            // 
            // categoriaBindingSource
            // 
            categoriaBindingSource.DataSource = typeof(Entidades.Categoria);
            // 
            // UC_Categorias
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(txtDescripcion);
            Controls.Add(txtBuscar);
            Controls.Add(cbBuscar);
            Controls.Add(label5);
            Controls.Add(lblTotalCategorias);
            Controls.Add(btnAgregarCategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(lblTime);
            Controls.Add(tableCategorias);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "UC_Categorias";
            Size = new Size(977, 571);
            Load += UC_Categorias_Load;
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTotalCategorias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView tableCategorias;
        private System.Windows.Forms.Label lblTime;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEditarCategoria;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtDescripcion;
        private BindingSource categoriaBindingSource;
    }
}
