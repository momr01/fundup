namespace CapaPresentacion.UserControls
{
    partial class UC_Graficos
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
            label2 = new Label();
            panel1 = new Panel();
            cbFiltro1 = new MaterialSkin.Controls.MaterialComboBox();
            bunifuDataViz1 = new Bunifu.DataViz.BunifuDataViz();
            button1 = new Button();
            panel3 = new Panel();
            cbFiltro2 = new MaterialSkin.Controls.MaterialComboBox();
            panel4 = new Panel();
            dpFecha2 = new Krypton.Toolkit.KryptonDateTimePicker();
            dpFecha1 = new Krypton.Toolkit.KryptonDateTimePicker();
            lblTituloGrafico = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(466, 26);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 0;
            label2.Text = "Gráficos";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(cbFiltro1);
            panel1.Location = new Point(103, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 55);
            panel1.TabIndex = 1;
            // 
            // cbFiltro1
            // 
            cbFiltro1.AutoResize = false;
            cbFiltro1.BackColor = Color.FromArgb(255, 255, 255);
            cbFiltro1.Depth = 0;
            cbFiltro1.DrawMode = DrawMode.OwnerDrawVariable;
            cbFiltro1.DropDownHeight = 174;
            cbFiltro1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltro1.DropDownWidth = 121;
            cbFiltro1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbFiltro1.ForeColor = Color.White;
            cbFiltro1.FormattingEnabled = true;
            cbFiltro1.Hint = "Seleccionar";
            cbFiltro1.IntegralHeight = false;
            cbFiltro1.ItemHeight = 43;
            cbFiltro1.Items.AddRange(new object[] { "Ingresos", "Gastos" });
            cbFiltro1.Location = new Point(3, 3);
            cbFiltro1.MaxDropDownItems = 4;
            cbFiltro1.MouseState = MaterialSkin.MouseState.OUT;
            cbFiltro1.Name = "cbFiltro1";
            cbFiltro1.Size = new Size(188, 49);
            cbFiltro1.StartIndex = 0;
            cbFiltro1.TabIndex = 5;
            // 
            // bunifuDataViz1
            // 
            bunifuDataViz1.Anchor = AnchorStyles.None;
            bunifuDataViz1.animationEnabled = false;
            bunifuDataViz1.AxisLineColor = Color.LightGray;
            bunifuDataViz1.AxisXFontColor = Color.Gray;
            bunifuDataViz1.AxisXGridColor = Color.Gray;
            bunifuDataViz1.AxisXGridThickness = new decimal(new int[] { 1, 0, 0, 0 });
            bunifuDataViz1.AxisYFontColor = Color.Gray;
            bunifuDataViz1.AxisYGridColor = Color.Gray;
            bunifuDataViz1.AxisYGridThickness = new decimal(new int[] { 1, 0, 0, 0 });
            bunifuDataViz1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuDataViz1.Location = new Point(16, 200);
            bunifuDataViz1.Margin = new Padding(5);
            bunifuDataViz1.Name = "bunifuDataViz1";
            bunifuDataViz1.Size = new Size(1013, 467);
            bunifuDataViz1.TabIndex = 2;
            bunifuDataViz1.Theme = Bunifu.DataViz.BunifuDataViz._theme.theme1;
            bunifuDataViz1.Title = "";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.MidnightBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(817, 85);
            button1.Name = "button1";
            button1.Size = new Size(159, 55);
            button1.TabIndex = 3;
            button1.Text = "Generar Gráfico";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(cbFiltro2);
            panel3.Location = new Point(332, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(193, 55);
            panel3.TabIndex = 8;
            // 
            // cbFiltro2
            // 
            cbFiltro2.AutoResize = false;
            cbFiltro2.BackColor = Color.FromArgb(255, 255, 255);
            cbFiltro2.Depth = 0;
            cbFiltro2.DrawMode = DrawMode.OwnerDrawVariable;
            cbFiltro2.DropDownHeight = 174;
            cbFiltro2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltro2.DropDownWidth = 121;
            cbFiltro2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbFiltro2.ForeColor = Color.White;
            cbFiltro2.FormattingEnabled = true;
            cbFiltro2.Hint = "Seleccionar";
            cbFiltro2.IntegralHeight = false;
            cbFiltro2.ItemHeight = 43;
            cbFiltro2.Items.AddRange(new object[] { "Por Categorías", "Por Fechas" });
            cbFiltro2.Location = new Point(3, 3);
            cbFiltro2.MaxDropDownItems = 4;
            cbFiltro2.MouseState = MaterialSkin.MouseState.OUT;
            cbFiltro2.Name = "cbFiltro2";
            cbFiltro2.Size = new Size(188, 49);
            cbFiltro2.StartIndex = 0;
            cbFiltro2.TabIndex = 5;
            cbFiltro2.SelectedIndexChanged += cbFiltro2_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.White;
            panel4.Controls.Add(dpFecha2);
            panel4.Controls.Add(dpFecha1);
            panel4.Location = new Point(559, 85);
            panel4.Name = "panel4";
            panel4.Size = new Size(193, 55);
            panel4.TabIndex = 9;
            // 
            // dpFecha2
            // 
            dpFecha2.CornerRoundingRadius = -1F;
            dpFecha2.Location = new Point(0, 34);
            dpFecha2.Name = "dpFecha2";
            dpFecha2.Size = new Size(193, 21);
            dpFecha2.TabIndex = 11;
            dpFecha2.Visible = false;
            // 
            // dpFecha1
            // 
            dpFecha1.CornerRoundingRadius = -1F;
            dpFecha1.Location = new Point(0, 0);
            dpFecha1.Name = "dpFecha1";
            dpFecha1.Size = new Size(193, 21);
            dpFecha1.TabIndex = 10;
            dpFecha1.Visible = false;
            // 
            // lblTituloGrafico
            // 
            lblTituloGrafico.Anchor = AnchorStyles.None;
            lblTituloGrafico.AutoSize = true;
            lblTituloGrafico.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloGrafico.ForeColor = Color.FromArgb(192, 64, 0);
            lblTituloGrafico.Location = new Point(299, 170);
            lblTituloGrafico.Name = "lblTituloGrafico";
            lblTituloGrafico.Size = new Size(0, 25);
            lblTituloGrafico.TabIndex = 10;
            // 
            // UC_Graficos
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(lblTituloGrafico);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(bunifuDataViz1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "UC_Graficos";
            Size = new Size(1048, 681);
            Load += UC_Graficos_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Bunifu.DataViz.BunifuDataViz bunifuDataViz1;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialComboBox cbFiltro1;
        private Panel panel3;
        private MaterialSkin.Controls.MaterialComboBox cbFiltro2;
        private Panel panel4;
        private Krypton.Toolkit.KryptonDateTimePicker dpFecha1;
        private Krypton.Toolkit.KryptonDateTimePicker dpFecha2;
        private Label lblTituloGrafico;
    }
}
