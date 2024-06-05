namespace CapaPresentacion.UserControls
{
    partial class UC_Finanzas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblTotal = new Label();
            label6 = new Label();
            panel5 = new Panel();
            btnMasInfo = new Button();
            panel8 = new Panel();
            label2 = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            btnGet = new Button();
            panel4 = new Panel();
            panel1 = new Panel();
            txtBuscar = new TextBox();
            cbBuscar = new ComboBox();
            label5 = new Label();
            panel3 = new Panel();
            tableFinanzas = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            Descripción = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Pais = new DataGridViewTextBoxColumn();
            Rentabilidad = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Perfil = new DataGridViewTextBoxColumn();
            Riesgo = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableFinanzas).BeginInit();
            SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.None;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.FromArgb(30, 50, 94);
            lblTotal.Location = new Point(765, 9);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(24, 18);
            lblTotal.TabIndex = 24;
            lblTotal.Text = "00";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(30, 50, 94);
            label6.Location = new Point(6, 8);
            label6.Name = "label6";
            label6.Size = new Size(250, 17);
            label6.TabIndex = 2;
            label6.Text = "Copyrights © 2024. All rights Reserved.";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(967, 7);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 57);
            panel5.TabIndex = 74;
            // 
            // btnMasInfo
            // 
            btnMasInfo.Cursor = Cursors.Hand;
            btnMasInfo.Dock = DockStyle.Left;
            btnMasInfo.FlatAppearance.BorderSize = 0;
            btnMasInfo.FlatStyle = FlatStyle.Flat;
            btnMasInfo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasInfo.ForeColor = Color.White;
            btnMasInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnMasInfo.Location = new Point(199, 7);
            btnMasInfo.Margin = new Padding(2);
            btnMasInfo.Name = "btnMasInfo";
            btnMasInfo.Size = new Size(173, 57);
            btnMasInfo.TabIndex = 18;
            btnMasInfo.Text = "Más información";
            btnMasInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMasInfo.UseVisualStyleBackColor = true;
            btnMasInfo.Visible = false;
            btnMasInfo.Click += btnMasInfo_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(lblTotal);
            panel8.Controls.Add(label2);
            panel8.Controls.Add(label6);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(10, 536);
            panel8.Name = "panel8";
            panel8.Size = new Size(957, 35);
            panel8.TabIndex = 85;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(30, 50, 94);
            label2.Location = new Point(607, 8);
            label2.Name = "label2";
            label2.Size = new Size(134, 18);
            label2.TabIndex = 24;
            label2.Text = "Total de registros:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(967, 64);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 507);
            panel7.TabIndex = 84;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 64);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 507);
            panel6.TabIndex = 83;
            // 
            // btnGet
            // 
            btnGet.Cursor = Cursors.Hand;
            btnGet.Dock = DockStyle.Left;
            btnGet.FlatAppearance.BorderSize = 0;
            btnGet.FlatStyle = FlatStyle.Flat;
            btnGet.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGet.ForeColor = Color.White;
            btnGet.ImageAlign = ContentAlignment.MiddleLeft;
            btnGet.Location = new Point(10, 7);
            btnGet.Margin = new Padding(2);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(189, 57);
            btnGet.TabIndex = 17;
            btnGet.Text = "Buscar Opciones";
            btnGet.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 7);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 57);
            panel4.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 50, 94);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(cbBuscar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(btnMasInfo);
            panel1.Controls.Add(btnGet);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(977, 64);
            panel1.TabIndex = 82;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtBuscar.Enabled = false;
            txtBuscar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(820, 22);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(141, 27);
            txtBuscar.TabIndex = 94;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // cbBuscar
            // 
            cbBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cbBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBuscar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Items.AddRange(new object[] { "NOMBRE", "PERFIL", "RIESGO", "RENTABILIDAD" });
            cbBuscar.Location = new Point(689, 23);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(125, 25);
            cbBuscar.TabIndex = 93;
            cbBuscar.SelectedValueChanged += cbBuscar_SelectedValueChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(597, 26);
            label5.Name = "label5";
            label5.Size = new Size(90, 18);
            label5.TabIndex = 95;
            label5.Text = "Buscar por:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(977, 7);
            panel3.TabIndex = 0;
            // 
            // tableFinanzas
            // 
            tableFinanzas.AllowUserToAddRows = false;
            tableFinanzas.AllowUserToDeleteRows = false;
            tableFinanzas.AllowUserToResizeColumns = false;
            tableFinanzas.AllowUserToResizeRows = false;
            tableFinanzas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableFinanzas.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tableFinanzas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tableFinanzas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableFinanzas.Columns.AddRange(new DataGridViewColumn[] { ID, dataGridViewTextBoxColumn11, Descripción, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14 });
            tableFinanzas.Dock = DockStyle.Fill;
            tableFinanzas.Location = new Point(10, 64);
            tableFinanzas.MultiSelect = false;
            tableFinanzas.Name = "tableFinanzas";
            tableFinanzas.ReadOnly = true;
            tableFinanzas.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tableFinanzas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            tableFinanzas.RowTemplate.Height = 40;
            tableFinanzas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableFinanzas.Size = new Size(957, 472);
            tableFinanzas.TabIndex = 87;
            tableFinanzas.SelectionChanged += tableFinanzas_SelectionChanged;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Nombre";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // Descripción
            // 
            Descripción.HeaderText = "Descripción";
            Descripción.Name = "Descripción";
            Descripción.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Perfil";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Riesgo";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.HeaderText = "Rentabilidad";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // Nombre
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 318;
            // 
            // Descripcion
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Descripcion.DefaultCellStyle = dataGridViewCellStyle4;
            Descripcion.HeaderText = "Perfil";
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 318;
            // 
            // Pais
            // 
            dataGridViewCellStyle5.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Pais.DefaultCellStyle = dataGridViewCellStyle5;
            Pais.HeaderText = "Riesgo";
            Pais.Name = "Pais";
            Pais.Width = 318;
            // 
            // Rentabilidad
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Rentabilidad.DefaultCellStyle = dataGridViewCellStyle6;
            Rentabilidad.HeaderText = "Rentabilidad";
            Rentabilidad.Name = "Rentabilidad";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Perfil
            // 
            Perfil.HeaderText = "Perfil";
            Perfil.Name = "Perfil";
            // 
            // Riesgo
            // 
            Riesgo.HeaderText = "Riesgo";
            Riesgo.Name = "Riesgo";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Rentabilidad";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 477;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Perfil";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 477;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Riesgo";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Rentabilidad";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Nombre";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 239;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Perfil";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 239;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Riesgo";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Width = 238;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Rentabilidad";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 238;
            // 
            // UC_Finanzas
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(tableFinanzas);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "UC_Finanzas";
            Size = new Size(977, 571);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableFinanzas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnMasInfo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tableFinanzas;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Pais;
        private DataGridViewTextBoxColumn Rentabilidad;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Perfil;
        private DataGridViewTextBoxColumn Riesgo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn Descripción;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private TextBox txtBuscar;
        private ComboBox cbBuscar;
        private Label label5;
    }
}
