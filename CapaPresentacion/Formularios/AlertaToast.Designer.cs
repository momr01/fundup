namespace CapaPresentacion.Formularios
{
    partial class AlertaToast
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
            panel5 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            categoriaBindingSource = new BindingSource(components);
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            lblTotal = new Label();
            label5 = new Label();
            label6 = new Label();
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
            pictureBox2.Image = Properties.Resources.fundupn;
            pictureBox2.Location = new Point(16, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 96;
            pictureBox2.TabStop = false;
            // 
            // categoriaBindingSource
            // 
            categoriaBindingSource.DataSource = typeof(Entidades.Categoria);
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(30, 50, 94);
            button1.Location = new Point(774, 12);
            button1.Name = "button1";
            button1.Size = new Size(42, 38);
            button1.TabIndex = 97;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(310, 39);
            label1.Name = "label1";
            label1.Size = new Size(247, 41);
            label1.TabIndex = 98;
            label1.Text = "¡ATENCIÓN!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(321, 136);
            label2.Name = "label2";
            label2.Size = new Size(97, 36);
            label2.TabIndex = 99;
            label2.Text = "Tiene ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(406, 136);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(133, 36);
            lblTotal.TabIndex = 100;
            lblTotal.Text = "5 planes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(290, 187);
            label5.Name = "label5";
            label5.Size = new Size(286, 36);
            label5.TabIndex = 102;
            label5.Text = "aún por completar.";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(61, 325);
            label6.MaximumSize = new Size(780, 0);
            label6.Name = "label6";
            label6.Size = new Size(708, 44);
            label6.TabIndex = 103;
            label6.Text = "Para más detalles, seleccione la opción \"Planes de Inversión\" en la ventana principal.";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AlertaToast
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(826, 382);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblTotal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlertaToast";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_AddWork";
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
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTitle;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTsNo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTsAmount;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPageNo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMBNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbHOA;
        private BindingSource categoriaBindingSource;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label lblTotal;
        private Label label5;
        private Label label6;
        //private DragControlDemo.DragControl dragControl1;
    }
}