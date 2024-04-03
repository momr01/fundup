namespace CapaPresentacion.UserControls
{
    partial class UC_Movimientos
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
            lblTotal = new Label();
            label6 = new Label();
            panel5 = new Panel();
            txtBuscar = new TextBox();
            cbBuscar = new ComboBox();
            label5 = new Label();
            panel8 = new Panel();
            label2 = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            btnListarMovimientos = new Button();
            panel4 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            tableMovimientos = new DataGridView();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableMovimientos).BeginInit();
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
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscar.Enabled = false;
            txtBuscar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(771, 23);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(179, 27);
            txtBuscar.TabIndex = 73;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // cbBuscar
            // 
            cbBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBuscar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Items.AddRange(new object[] { "DESCRIPCION" });
            cbBuscar.Location = new Point(640, 25);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(125, 25);
            cbBuscar.TabIndex = 72;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(548, 28);
            label5.Name = "label5";
            label5.Size = new Size(80, 18);
            label5.TabIndex = 20;
            label5.Text = "Filtrar por:";
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
            // btnListarMovimientos
            // 
            btnListarMovimientos.Cursor = Cursors.Hand;
            btnListarMovimientos.Dock = DockStyle.Left;
            btnListarMovimientos.FlatAppearance.BorderSize = 0;
            btnListarMovimientos.FlatStyle = FlatStyle.Flat;
            btnListarMovimientos.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnListarMovimientos.ForeColor = Color.White;
            btnListarMovimientos.ImageAlign = ContentAlignment.MiddleLeft;
            btnListarMovimientos.Location = new Point(10, 7);
            btnListarMovimientos.Margin = new Padding(2);
            btnListarMovimientos.Name = "btnListarMovimientos";
            btnListarMovimientos.Size = new Size(189, 57);
            btnListarMovimientos.TabIndex = 17;
            btnListarMovimientos.Text = "    Listar Movimientos";
            btnListarMovimientos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListarMovimientos.UseVisualStyleBackColor = true;
            btnListarMovimientos.Click += btnListarMovimientos_Click;
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
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(cbBuscar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnListarMovimientos);
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
            // tableMovimientos
            // 
            tableMovimientos.AllowUserToAddRows = false;
            tableMovimientos.AllowUserToDeleteRows = false;
            tableMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableMovimientos.BackgroundColor = Color.FromArgb(224, 224, 224);
            tableMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableMovimientos.Dock = DockStyle.Fill;
            tableMovimientos.Location = new Point(10, 64);
            tableMovimientos.Name = "tableMovimientos";
            tableMovimientos.ReadOnly = true;
            tableMovimientos.RowHeadersVisible = false;
            tableMovimientos.RowTemplate.Height = 33;
            tableMovimientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableMovimientos.Size = new Size(957, 472);
            tableMovimientos.TabIndex = 87;
            // 
            // UC_Movimientos
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(tableMovimientos);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "UC_Movimientos";
            Size = new Size(977, 571);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableMovimientos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnListarMovimientos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tableMovimientos;
    }
}
