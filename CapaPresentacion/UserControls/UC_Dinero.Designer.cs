namespace CapaPresentacion.UserControls
{
    partial class UC_Dinero
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblQty = new Label();
            label6 = new Label();
            btnEdit = new Button();
            panel5 = new Panel();
            txtSearch = new TextBox();
            cmbSearchType = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            panel8 = new Panel();
            label2 = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            btnUsers = new Button();
            panel4 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblQty
            // 
            lblQty.Anchor = AnchorStyles.None;
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblQty.ForeColor = Color.FromArgb(30, 50, 94);
            lblQty.Location = new Point(765, 9);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(24, 18);
            lblQty.TabIndex = 24;
            lblQty.Text = "00";
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
            label6.Text = "Copyrights © 2023. All rights Reserved.";
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Dock = DockStyle.Left;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(372, 7);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(129, 57);
            btnEdit.TabIndex = 75;
            btnEdit.Text = "     Eliminar";
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = true;
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
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(771, 23);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(179, 27);
            txtSearch.TabIndex = 73;
            // 
            // cmbSearchType
            // 
            cmbSearchType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbSearchType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchType.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSearchType.FormattingEnabled = true;
            cmbSearchType.Items.AddRange(new object[] { "Work Id", "Work Tilte", "Contractor Name", "CA Cost", "Work Done", "Amount Paid", "Now To be Paid", "Work to be Done" });
            cmbSearchType.Location = new Point(640, 25);
            cmbSearchType.Name = "cmbSearchType";
            cmbSearchType.Size = new Size(125, 25);
            cmbSearchType.TabIndex = 72;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(548, 28);
            label5.Name = "label5";
            label5.Size = new Size(90, 18);
            label5.TabIndex = 20;
            label5.Text = "Buscar por:";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(199, 7);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(173, 57);
            button1.TabIndex = 18;
            button1.Text = "     Modificar";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(lblQty);
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
            label2.Size = new Size(143, 18);
            label2.TabIndex = 24;
            label2.Text = "Total Movimientos:";
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
            // btnUsers
            // 
            btnUsers.Cursor = Cursors.Hand;
            btnUsers.Dock = DockStyle.Left;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsers.ForeColor = Color.White;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(10, 7);
            btnUsers.Margin = new Padding(2);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(189, 57);
            btnUsers.TabIndex = 17;
            btnUsers.Text = "    Agregar Movimiento";
            btnUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
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
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(cmbSearchType);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnUsers);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(977, 64);
            panel1.TabIndex = 82;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(10, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(957, 472);
            dataGridView1.TabIndex = 87;
            // 
            // UC_Dinero
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(dataGridView1);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "UC_Dinero";
            Size = new Size(977, 571);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
