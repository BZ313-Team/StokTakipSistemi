namespace StokTakipSistemi
{
    partial class Istatistik2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tLayoutKarZarar = new TableLayoutPanel();
            tLayoutKarZararGraf = new TableLayoutPanel();
            chartKarZarar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            lblKar = new Label();
            lblCiro = new Label();
            txtBoxKar = new TextBox();
            txtBoxCiro = new TextBox();
            tLayoutKarZararUst = new TableLayoutPanel();
            lblUrunBazindaKarZarar = new Label();
            cmbBoxKarZararFiltre = new ComboBox();
            tLayoutKarZarar.SuspendLayout();
            tLayoutKarZararGraf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartKarZarar).BeginInit();
            panel1.SuspendLayout();
            tLayoutKarZararUst.SuspendLayout();
            SuspendLayout();
            // 
            // tLayoutKarZarar
            // 
            tLayoutKarZarar.ColumnCount = 1;
            tLayoutKarZarar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tLayoutKarZarar.Controls.Add(tLayoutKarZararGraf, 0, 1);
            tLayoutKarZarar.Controls.Add(tLayoutKarZararUst, 0, 0);
            tLayoutKarZarar.Dock = DockStyle.Fill;
            tLayoutKarZarar.Location = new Point(0, 0);
            tLayoutKarZarar.Name = "tLayoutKarZarar";
            tLayoutKarZarar.RowCount = 2;
            tLayoutKarZarar.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tLayoutKarZarar.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tLayoutKarZarar.Size = new Size(1115, 546);
            tLayoutKarZarar.TabIndex = 0;
            // 
            // tLayoutKarZararGraf
            // 
            tLayoutKarZararGraf.ColumnCount = 2;
            tLayoutKarZararGraf.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tLayoutKarZararGraf.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tLayoutKarZararGraf.Controls.Add(chartKarZarar, 0, 0);
            tLayoutKarZararGraf.Controls.Add(panel1, 1, 0);
            tLayoutKarZararGraf.Dock = DockStyle.Fill;
            tLayoutKarZararGraf.Location = new Point(3, 57);
            tLayoutKarZararGraf.Name = "tLayoutKarZararGraf";
            tLayoutKarZararGraf.RowCount = 1;
            tLayoutKarZararGraf.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tLayoutKarZararGraf.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tLayoutKarZararGraf.Size = new Size(1109, 486);
            tLayoutKarZararGraf.TabIndex = 0;
            // 
            // chartKarZarar
            // 
            chartArea1.Name = "ChartArea1";
            chartKarZarar.ChartAreas.Add(chartArea1);
            chartKarZarar.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartKarZarar.Legends.Add(legend1);
            chartKarZarar.Location = new Point(3, 3);
            chartKarZarar.Name = "chartKarZarar";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartKarZarar.Series.Add(series1);
            chartKarZarar.Size = new Size(825, 480);
            chartKarZarar.TabIndex = 1;
            chartKarZarar.Text = "chart1";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblKar);
            panel1.Controls.Add(lblCiro);
            panel1.Controls.Add(txtBoxKar);
            panel1.Controls.Add(txtBoxCiro);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(834, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 480);
            panel1.TabIndex = 2;
            // 
            // lblKar
            // 
            lblKar.AutoSize = true;
            lblKar.Location = new Point(29, 144);
            lblKar.Name = "lblKar";
            lblKar.Size = new Size(38, 20);
            lblKar.TabIndex = 3;
            lblKar.Text = "Kar :";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.Location = new Point(29, 93);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(43, 20);
            lblCiro.TabIndex = 2;
            lblCiro.Text = "Ciro :";
            // 
            // txtBoxKar
            // 
            txtBoxKar.Location = new Point(127, 141);
            txtBoxKar.Name = "txtBoxKar";
            txtBoxKar.Size = new Size(99, 27);
            txtBoxKar.TabIndex = 1;
            // 
            // txtBoxCiro
            // 
            txtBoxCiro.Location = new Point(127, 86);
            txtBoxCiro.Name = "txtBoxCiro";
            txtBoxCiro.Size = new Size(99, 27);
            txtBoxCiro.TabIndex = 0;
            // 
            // tLayoutKarZararUst
            // 
            tLayoutKarZararUst.ColumnCount = 2;
            tLayoutKarZararUst.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tLayoutKarZararUst.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tLayoutKarZararUst.Controls.Add(lblUrunBazindaKarZarar, 0, 0);
            tLayoutKarZararUst.Controls.Add(cmbBoxKarZararFiltre, 1, 0);
            tLayoutKarZararUst.Dock = DockStyle.Fill;
            tLayoutKarZararUst.Location = new Point(3, 3);
            tLayoutKarZararUst.Name = "tLayoutKarZararUst";
            tLayoutKarZararUst.RowCount = 1;
            tLayoutKarZararUst.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tLayoutKarZararUst.Size = new Size(1109, 48);
            tLayoutKarZararUst.TabIndex = 1;
            // 
            // lblUrunBazindaKarZarar
            // 
            lblUrunBazindaKarZarar.AutoSize = true;
            lblUrunBazindaKarZarar.Dock = DockStyle.Left;
            lblUrunBazindaKarZarar.Location = new Point(3, 0);
            lblUrunBazindaKarZarar.Name = "lblUrunBazindaKarZarar";
            lblUrunBazindaKarZarar.Size = new Size(167, 48);
            lblUrunBazindaKarZarar.TabIndex = 0;
            lblUrunBazindaKarZarar.Text = "Ürün Bazında Kar Oranı ";
            // 
            // cmbBoxKarZararFiltre
            // 
            cmbBoxKarZararFiltre.Anchor = AnchorStyles.None;
            cmbBoxKarZararFiltre.FormattingEnabled = true;
            cmbBoxKarZararFiltre.Items.AddRange(new object[] { "Günluk ", "Haftalık", "Aylık " });
            cmbBoxKarZararFiltre.Location = new Point(894, 10);
            cmbBoxKarZararFiltre.Name = "cmbBoxKarZararFiltre";
            cmbBoxKarZararFiltre.Size = new Size(151, 28);
            cmbBoxKarZararFiltre.TabIndex = 1;
            // 
            // Istatistik2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 546);
            Controls.Add(tLayoutKarZarar);
            Name = "Istatistik2";
            Text = "Istatistik2";
            Load += Istatistik2_Load;
            tLayoutKarZarar.ResumeLayout(false);
            tLayoutKarZararGraf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartKarZarar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tLayoutKarZararUst.ResumeLayout(false);
            tLayoutKarZararUst.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tLayoutKarZarar;
        private TableLayoutPanel tLayoutKarZararGraf;
        private TableLayoutPanel tLayoutKarZararUst;
        private Label lblUrunBazindaKarZarar;
        private ComboBox cmbBoxKarZararFiltre;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKarZarar;
        private Panel panel1;
        private Label lblKar;
        private Label lblCiro;
        private TextBox txtBoxKar;
        private TextBox txtBoxCiro;
    }
}