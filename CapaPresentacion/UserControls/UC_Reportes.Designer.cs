namespace CapaPresentacion.UserControls
{
    partial class UC_Reportes
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
            dpFechaInicio = new Krypton.Toolkit.KryptonDateTimePicker();
            label5 = new Label();
            btnReporte = new Button();
            panel8 = new Panel();
            label2 = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            btnBuscar = new Button();
            panel4 = new Panel();
            panel1 = new Panel();
            dpFechaFin = new Krypton.Toolkit.KryptonDateTimePicker();
            label1 = new Label();
            panel3 = new Panel();
            tableDinero = new DataGridView();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableDinero).BeginInit();
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
            // dpFechaInicio
            // 
            dpFechaInicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dpFechaInicio.CornerRoundingRadius = -1F;
            dpFechaInicio.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dpFechaInicio.Location = new Point(504, 26);
            dpFechaInicio.Name = "dpFechaInicio";
            dpFechaInicio.Size = new Size(163, 21);
            dpFechaInicio.TabIndex = 72;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(399, 29);
            label5.Name = "label5";
            label5.Size = new Size(103, 18);
            label5.TabIndex = 20;
            label5.Text = "Fecha inicio:";
            // 
            // btnReporte
            // 
            btnReporte.Cursor = Cursors.Hand;
            btnReporte.Dock = DockStyle.Left;
            btnReporte.FlatAppearance.BorderSize = 0;
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReporte.ForeColor = Color.White;
            btnReporte.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporte.Location = new Point(199, 7);
            btnReporte.Margin = new Padding(2);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(173, 57);
            btnReporte.TabIndex = 18;
            btnReporte.Text = "Generar Reporte";
            btnReporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporte.UseVisualStyleBackColor = true;
            btnReporte.Visible = false;
            btnReporte.Click += btnReporte_Click2;
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
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Dock = DockStyle.Left;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(10, 7);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(189, 57);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar Registros";
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
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
            panel1.Controls.Add(dpFechaFin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(dpFechaInicio);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnReporte);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(977, 64);
            panel1.TabIndex = 82;
            // 
            // dpFechaFin
            // 
            dpFechaFin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dpFechaFin.CornerRoundingRadius = -1F;
            dpFechaFin.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dpFechaFin.Location = new Point(775, 26);
            dpFechaFin.Name = "dpFechaFin";
            dpFechaFin.Size = new Size(165, 21);
            dpFechaFin.TabIndex = 76;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(694, 29);
            label1.Name = "label1";
            label1.Size = new Size(79, 18);
            label1.TabIndex = 75;
            label1.Text = "Fecha fin:";
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
            // tableDinero
            // 
            tableDinero.AllowUserToAddRows = false;
            tableDinero.AllowUserToDeleteRows = false;
            tableDinero.AllowUserToResizeColumns = false;
            tableDinero.AllowUserToResizeRows = false;
            tableDinero.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableDinero.BackgroundColor = Color.FromArgb(224, 224, 224);
            tableDinero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableDinero.Dock = DockStyle.Fill;
            tableDinero.Location = new Point(10, 64);
            tableDinero.MultiSelect = false;
            tableDinero.Name = "tableDinero";
            tableDinero.ReadOnly = true;
            tableDinero.RowHeadersVisible = false;
            tableDinero.RowTemplate.Height = 33;
            tableDinero.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableDinero.Size = new Size(957, 472);
            tableDinero.TabIndex = 87;
            // 
            // UC_Reportes
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(tableDinero);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "UC_Reportes";
            Size = new Size(977, 571);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableDinero).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        // private System.Windows.Forms.ComboBox cmbSearchType;
        private Krypton.Toolkit.KryptonDateTimePicker dpFechaInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tableDinero;
        //private ComboBox dpFechaFin;
        private Krypton.Toolkit.KryptonDateTimePicker dpFechaFin;
        private Label label1;
    }
}
