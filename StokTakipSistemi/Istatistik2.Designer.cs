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
            pnlIstatistikSag = new Panel();
            btnGeri = new Button();
            lblKar = new Label();
            lblCiro = new Label();
            txtBoxKar = new TextBox();
            txtBoxCiro = new TextBox();
            tLayoutKarZararUst = new TableLayoutPanel();
            lblUrunBazindaKarZarar = new Label();
            cmbBoxIstSFiltre = new ComboBox();
            tLayoutKarZarar.SuspendLayout();
            tLayoutKarZararGraf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartKarZarar).BeginInit();
            pnlIstatistikSag.SuspendLayout();
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
            tLayoutKarZarar.Margin = new Padding(3, 2, 3, 2);
            tLayoutKarZarar.Name = "tLayoutKarZarar";
            tLayoutKarZarar.RowCount = 2;
            tLayoutKarZarar.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tLayoutKarZarar.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tLayoutKarZarar.Size = new Size(976, 410);
            tLayoutKarZarar.TabIndex = 0;
            // 
            // tLayoutKarZararGraf
            // 
            tLayoutKarZararGraf.ColumnCount = 2;
            tLayoutKarZararGraf.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tLayoutKarZararGraf.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tLayoutKarZararGraf.Controls.Add(chartKarZarar, 0, 0);
            tLayoutKarZararGraf.Controls.Add(pnlIstatistikSag, 1, 0);
            tLayoutKarZararGraf.Dock = DockStyle.Fill;
            tLayoutKarZararGraf.Location = new Point(3, 43);
            tLayoutKarZararGraf.Margin = new Padding(3, 2, 3, 2);
            tLayoutKarZararGraf.Name = "tLayoutKarZararGraf";
            tLayoutKarZararGraf.RowCount = 1;
            tLayoutKarZararGraf.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tLayoutKarZararGraf.RowStyles.Add(new RowStyle(SizeType.Absolute, 364F));
            tLayoutKarZararGraf.Size = new Size(970, 365);
            tLayoutKarZararGraf.TabIndex = 0;
            // 
            // chartKarZarar
            // 
            chartArea1.Name = "ChartArea1";
            chartKarZarar.ChartAreas.Add(chartArea1);
            chartKarZarar.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartKarZarar.Legends.Add(legend1);
            chartKarZarar.Location = new Point(3, 2);
            chartKarZarar.Margin = new Padding(3, 2, 3, 2);
            chartKarZarar.Name = "chartKarZarar";
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "PointWidth=0.3";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartKarZarar.Series.Add(series1);
            chartKarZarar.Size = new Size(721, 361);
            chartKarZarar.TabIndex = 1;
            chartKarZarar.Text = "chart1";
            // 
            // pnlIstatistikSag
            // 
            pnlIstatistikSag.Controls.Add(btnGeri);
            pnlIstatistikSag.Controls.Add(lblKar);
            pnlIstatistikSag.Controls.Add(lblCiro);
            pnlIstatistikSag.Controls.Add(txtBoxKar);
            pnlIstatistikSag.Controls.Add(txtBoxCiro);
            pnlIstatistikSag.Dock = DockStyle.Fill;
            pnlIstatistikSag.Location = new Point(730, 2);
            pnlIstatistikSag.Margin = new Padding(3, 2, 3, 2);
            pnlIstatistikSag.Name = "pnlIstatistikSag";
            pnlIstatistikSag.Size = new Size(237, 361);
            pnlIstatistikSag.TabIndex = 2;
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(82, 284);
            btnGeri.Margin = new Padding(3, 2, 3, 2);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(74, 30);
            btnGeri.TabIndex = 4;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // lblKar
            // 
            lblKar.AutoSize = true;
            lblKar.Location = new Point(25, 108);
            lblKar.Name = "lblKar";
            lblKar.Size = new Size(30, 15);
            lblKar.TabIndex = 3;
            lblKar.Text = "Kar :";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.Location = new Point(25, 70);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(35, 15);
            lblCiro.TabIndex = 2;
            lblCiro.Text = "Ciro :";
            // 
            // txtBoxKar
            // 
            txtBoxKar.Location = new Point(111, 106);
            txtBoxKar.Margin = new Padding(3, 2, 3, 2);
            txtBoxKar.Name = "txtBoxKar";
            txtBoxKar.Size = new Size(87, 23);
            txtBoxKar.TabIndex = 1;
            // 
            // txtBoxCiro
            // 
            txtBoxCiro.Location = new Point(111, 64);
            txtBoxCiro.Margin = new Padding(3, 2, 3, 2);
            txtBoxCiro.Name = "txtBoxCiro";
            txtBoxCiro.Size = new Size(87, 23);
            txtBoxCiro.TabIndex = 0;
            // 
            // tLayoutKarZararUst
            // 
            tLayoutKarZararUst.ColumnCount = 2;
            tLayoutKarZararUst.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tLayoutKarZararUst.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tLayoutKarZararUst.Controls.Add(lblUrunBazindaKarZarar, 0, 0);
            tLayoutKarZararUst.Controls.Add(cmbBoxIstSFiltre, 1, 0);
            tLayoutKarZararUst.Dock = DockStyle.Fill;
            tLayoutKarZararUst.Location = new Point(3, 2);
            tLayoutKarZararUst.Margin = new Padding(3, 2, 3, 2);
            tLayoutKarZararUst.Name = "tLayoutKarZararUst";
            tLayoutKarZararUst.RowCount = 1;
            tLayoutKarZararUst.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tLayoutKarZararUst.Size = new Size(970, 37);
            tLayoutKarZararUst.TabIndex = 1;
            // 
            // lblUrunBazindaKarZarar
            // 
            lblUrunBazindaKarZarar.Anchor = AnchorStyles.None;
            lblUrunBazindaKarZarar.AutoSize = true;
            lblUrunBazindaKarZarar.Location = new Point(297, 11);
            lblUrunBazindaKarZarar.Name = "lblUrunBazindaKarZarar";
            lblUrunBazindaKarZarar.Size = new Size(132, 15);
            lblUrunBazindaKarZarar.TabIndex = 0;
            lblUrunBazindaKarZarar.Text = "Ürün Bazında Kar Oranı ";
            lblUrunBazindaKarZarar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbBoxIstSFiltre
            // 
            cmbBoxIstSFiltre.Anchor = AnchorStyles.None;
            cmbBoxIstSFiltre.FormattingEnabled = true;
            cmbBoxIstSFiltre.Items.AddRange(new object[] { "Günlük", "Haftalık", "Aylık" });
            cmbBoxIstSFiltre.Location = new Point(782, 7);
            cmbBoxIstSFiltre.Margin = new Padding(3, 2, 3, 2);
            cmbBoxIstSFiltre.Name = "cmbBoxIstSFiltre";
            cmbBoxIstSFiltre.Size = new Size(133, 23);
            cmbBoxIstSFiltre.TabIndex = 1;
            // 
            // Istatistik2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 410);
            Controls.Add(tLayoutKarZarar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Istatistik2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Istatistik2";
            Load += Istatistik2_Load;
            tLayoutKarZarar.ResumeLayout(false);
            tLayoutKarZararGraf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartKarZarar).EndInit();
            pnlIstatistikSag.ResumeLayout(false);
            pnlIstatistikSag.PerformLayout();
            tLayoutKarZararUst.ResumeLayout(false);
            tLayoutKarZararUst.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tLayoutKarZarar;
        private TableLayoutPanel tLayoutKarZararGraf;
        private TableLayoutPanel tLayoutKarZararUst;
        private Label lblUrunBazindaKarZarar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKarZarar;
        private Panel pnlIstatistikSag;
        private Label lblKar;
        private Label lblCiro;
        private TextBox txtBoxKar;
        private TextBox txtBoxCiro;
        private Button btnGeri;
        private ComboBox cmbBoxIstSFiltre;
    }
}