namespace CapaPresentacion.UserControls
{
    partial class UC_Ingresos
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
            lblTotalIngresos = new Label();
            label6 = new Label();
            panel8 = new Panel();
            btnEditarIngreso = new Button();
            btnEliminarIngreso = new Button();
            label2 = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            tableIngresos = new DataGridView();
            lblTime = new Label();
            txtDescripcion = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            label4 = new Label();
            label1 = new Label();
            btnAgregarIngreso = new Button();
            txtBuscar = new TextBox();
            cbBuscar = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label7 = new Label();
            cbCategoria = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            categoriaBindingSource = new BindingSource(components);
            txtImporte = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            dpFecha = new Krypton.Toolkit.KryptonDateTimePicker();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableIngresos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblTotalIngresos
            // 
            lblTotalIngresos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalIngresos.AutoSize = true;
            lblTotalIngresos.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalIngresos.ForeColor = Color.FromArgb(30, 50, 94);
            lblTotalIngresos.Location = new Point(190, 209);
            lblTotalIngresos.Name = "lblTotalIngresos";
            lblTotalIngresos.Size = new Size(0, 18);
            lblTotalIngresos.TabIndex = 24;
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
            panel8.Controls.Add(btnEditarIngreso);
            panel8.Controls.Add(btnEliminarIngreso);
            panel8.Controls.Add(label6);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(33, 518);
            panel8.Name = "panel8";
            panel8.Size = new Size(892, 53);
            panel8.TabIndex = 85;
            panel8.Paint += Panel8_Paint;
            // 
            // btnEditarIngreso
            // 
            btnEditarIngreso.Anchor = AnchorStyles.Right;
            btnEditarIngreso.Cursor = Cursors.Hand;
            btnEditarIngreso.Enabled = false;
            btnEditarIngreso.FlatStyle = FlatStyle.Flat;
            btnEditarIngreso.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarIngreso.ForeColor = Color.SeaGreen;
            btnEditarIngreso.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarIngreso.Location = new Point(566, 6);
            btnEditarIngreso.Name = "btnEditarIngreso";
            btnEditarIngreso.Size = new Size(173, 41);
            btnEditarIngreso.TabIndex = 5;
            btnEditarIngreso.Text = "Editar";
            btnEditarIngreso.UseVisualStyleBackColor = true;
            btnEditarIngreso.Click += Button1_Click;
            // 
            // btnEliminarIngreso
            // 
            btnEliminarIngreso.Anchor = AnchorStyles.Right;
            btnEliminarIngreso.Enabled = false;
            btnEliminarIngreso.FlatStyle = FlatStyle.Flat;
            btnEliminarIngreso.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarIngreso.ForeColor = Color.Red;
            btnEliminarIngreso.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarIngreso.Location = new Point(745, 6);
            btnEliminarIngreso.Name = "btnEliminarIngreso";
            btnEliminarIngreso.Size = new Size(141, 40);
            btnEliminarIngreso.TabIndex = 6;
            btnEliminarIngreso.Text = "Eliminar";
            btnEliminarIngreso.UseVisualStyleBackColor = true;
            btnEliminarIngreso.Click += btnEliminarIngreso_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(30, 50, 94);
            label2.Location = new Point(43, 209);
            label2.Name = "label2";
            label2.Size = new Size(159, 18);
            label2.TabIndex = 24;
            label2.Text = "No Total de Ingresos:";
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
            // tableIngresos
            // 
            tableIngresos.AllowUserToAddRows = false;
            tableIngresos.AllowUserToDeleteRows = false;
            tableIngresos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableIngresos.BackgroundColor = Color.FromArgb(224, 224, 224);
            tableIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableIngresos.Dock = DockStyle.Bottom;
            tableIngresos.Location = new Point(33, 239);
            tableIngresos.MultiSelect = false;
            tableIngresos.Name = "tableIngresos";
            tableIngresos.ReadOnly = true;
            tableIngresos.RowTemplate.Height = 33;
            tableIngresos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableIngresos.Size = new Size(892, 279);
            tableIngresos.TabIndex = 87;
            tableIngresos.CellClick += tableIngresos_CellClick;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.None;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.ForeColor = Color.FromArgb(30, 50, 94);
            lblTime.Location = new Point(400, 12);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(189, 19);
            lblTime.TabIndex = 88;
            lblTime.Text = "Agregar Nuevo Ingreso";
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
            txtDescripcion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.HideSelection = true;
            txtDescripcion.Hint = "Ingrese una descripción";
            txtDescripcion.LeadingIcon = null;
            txtDescripcion.Location = new Point(170, 53);
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
            txtDescripcion.Size = new Size(269, 48);
            txtDescripcion.TabIndex = 0;
            txtDescripcion.TabStop = false;
            txtDescripcion.TextAlign = HorizontalAlignment.Left;
            txtDescripcion.TrailingIcon = null;
            txtDescripcion.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(68, 74);
            label4.Name = "label4";
            label4.Size = new Size(101, 18);
            label4.TabIndex = 90;
            label4.Text = "Descripción:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(83, 140);
            label1.Name = "label1";
            label1.Size = new Size(87, 18);
            label1.TabIndex = 90;
            label1.Text = "Categoría:";
            // 
            // btnAgregarIngreso
            // 
            btnAgregarIngreso.Anchor = AnchorStyles.None;
            btnAgregarIngreso.Cursor = Cursors.Hand;
            btnAgregarIngreso.FlatStyle = FlatStyle.Flat;
            btnAgregarIngreso.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarIngreso.ForeColor = Color.SeaGreen;
            btnAgregarIngreso.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarIngreso.Location = new Point(425, 186);
            btnAgregarIngreso.Name = "btnAgregarIngreso";
            btnAgregarIngreso.Size = new Size(119, 41);
            btnAgregarIngreso.TabIndex = 4;
            btnAgregarIngreso.Text = "Agregar";
            btnAgregarIngreso.UseVisualStyleBackColor = true;
            btnAgregarIngreso.Click += btnAgregarIngreso_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtBuscar.Enabled = false;
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
            cbBuscar.Items.AddRange(new object[] { "CATEGORIA", "DESCRIPCION" });
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
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(527, 140);
            label3.Name = "label3";
            label3.Size = new Size(58, 18);
            label3.TabIndex = 95;
            label3.Text = "Fecha:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(516, 74);
            label7.Name = "label7";
            label7.Size = new Size(69, 18);
            label7.TabIndex = 96;
            label7.Text = "Importe:";
            // 
            // cbCategoria
            // 
            cbCategoria.Anchor = AnchorStyles.None;
            cbCategoria.AutoResize = false;
            cbCategoria.BackColor = Color.FromArgb(255, 255, 255);
            cbCategoria.Cursor = Cursors.IBeam;
            cbCategoria.DataSource = categoriaBindingSource;
            cbCategoria.Depth = 0;
            cbCategoria.DisplayMember = "NombreCategoria";
            cbCategoria.DrawMode = DrawMode.OwnerDrawVariable;
            cbCategoria.DropDownHeight = 174;
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.DropDownWidth = 121;
            cbCategoria.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategoria.ForeColor = Color.FromArgb(64, 64, 64);
            cbCategoria.Hint = "Seleccionar";
            cbCategoria.IntegralHeight = false;
            cbCategoria.ItemHeight = 43;
            cbCategoria.Location = new Point(170, 119);
            cbCategoria.Margin = new Padding(4);
            cbCategoria.MaxDropDownItems = 4;
            cbCategoria.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(269, 49);
            cbCategoria.StartIndex = 0;
            cbCategoria.TabIndex = 2;
            cbCategoria.ValueMember = "IdCategoria";
            // 
            // categoriaBindingSource
            // 
            categoriaBindingSource.DataSource = typeof(Entidades.Categoria);
            // 
            // txtImporte
            // 
            txtImporte.Anchor = AnchorStyles.None;
            txtImporte.AnimateReadOnly = false;
            txtImporte.AutoCompleteMode = AutoCompleteMode.None;
            txtImporte.AutoCompleteSource = AutoCompleteSource.None;
            txtImporte.BackgroundImageLayout = ImageLayout.None;
            txtImporte.CharacterCasing = CharacterCasing.Normal;
            txtImporte.Cursor = Cursors.IBeam;
            txtImporte.Depth = 0;
            txtImporte.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtImporte.HideSelection = true;
            txtImporte.Hint = "Valor numérico";
            txtImporte.LeadingIcon = null;
            txtImporte.Location = new Point(586, 53);
            txtImporte.Margin = new Padding(4);
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
            txtImporte.Size = new Size(269, 48);
            txtImporte.TabIndex = 1;
            txtImporte.TabStop = false;
            txtImporte.TextAlign = HorizontalAlignment.Left;
            txtImporte.TrailingIcon = null;
            txtImporte.UseSystemPasswordChar = false;
            // 
            // dpFecha
            // 
            dpFecha.Anchor = AnchorStyles.None;
            dpFecha.CornerRoundingRadius = -1F;
            dpFecha.Cursor = Cursors.IBeam;
            dpFecha.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpFecha.ForeColor = Color.FromArgb(64, 64, 64);
            dpFecha.Location = new Point(586, 137);
            dpFecha.Margin = new Padding(4);
            dpFecha.Name = "dpFecha";
            dpFecha.Size = new Size(269, 21);
            dpFecha.TabIndex = 3;
            dpFecha.ValueNullable = new DateTime(0L);
            // 
            // UC_Ingresos
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(dpFecha);
            Controls.Add(txtImporte);
            Controls.Add(cbCategoria);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(txtBuscar);
            Controls.Add(cbBuscar);
            Controls.Add(label5);
            Controls.Add(lblTotalIngresos);
            Controls.Add(btnAgregarIngreso);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            Controls.Add(label4);
            Controls.Add(lblTime);
            Controls.Add(tableIngresos);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "UC_Ingresos";
            Size = new Size(977, 571);
            Load += UC_Ingresos_Load;
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableIngresos).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTotalIngresos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView tableIngresos;
        private System.Windows.Forms.Label lblTime;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarIngreso;
        private System.Windows.Forms.Button btnAgregarIngreso;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEditarIngreso;
        private Label label3;
        private Label label7;
        private MaterialSkin2DotNet.Controls.MaterialComboBox cbCategoria;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtImporte;
        private Krypton.Toolkit.KryptonDateTimePicker dpFecha;
        private BindingSource categoriaBindingSource;
    }
}
