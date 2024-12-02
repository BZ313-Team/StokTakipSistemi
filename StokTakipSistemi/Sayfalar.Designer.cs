namespace StokTakipSistemi
{
    partial class Sayfalar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tLayoutPButtonSayfa = new TableLayoutPanel();
            panelButtons = new Panel();
            tLayoutPButtons = new TableLayoutPanel();
            btnIstatistik = new Button();
            btnGecmis = new Button();
            btnStok = new Button();
            btnSatis = new Button();
            btnUrun = new Button();
            tabControl1 = new TabControl();
            tabPageSatis = new TabPage();
            tLayoutPSatisSayfa = new TableLayoutPanel();
            tLayoutPSatisEkrani = new TableLayoutPanel();
            tLayoutPToplamTutar = new TableLayoutPanel();
            txtBoxToplamTutar = new TextBox();
            lblToplamTutar = new Label();
            tLayoutPIndirimYuzde = new TableLayoutPanel();
            txtBoxIndirimYuzde = new TextBox();
            lblIndirimYuzde = new Label();
            tLayoutPIndirimTL = new TableLayoutPanel();
            txtBoxIndirimTL = new TextBox();
            lblIndirimTL = new Label();
            tLayoutPBileme = new TableLayoutPanel();
            lblBileme = new Label();
            txtBoxBileme = new TextBox();
            dataGViewSatisEkrani = new DataGridView();
            tLayoutPTutar = new TableLayoutPanel();
            lblTutar = new Label();
            txtBoxTutar = new TextBox();
            btnSatisYap = new Button();
            tLayoutPSatisSayfaSol = new TableLayoutPanel();
            tLayoutPHesapMakinesi = new TableLayoutPanel();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnBolme = new Button();
            btnAC = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnCarpma = new Button();
            btnDEL = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            button20 = new Button();
            btnNokta = new Button();
            btnEsittir = new Button();
            btnCikarma = new Button();
            btnToplama = new Button();
            tabPageUrun = new TabPage();
            tabPageStok = new TabPage();
            tabPageGecmis = new TabPage();
            tabPageIstatistik = new TabPage();
            tLayoutPIstPasta = new TableLayoutPanel();
            tLayoutPIstUst = new TableLayoutPanel();
            lblUrunBazindaYuzdeliSatis = new Label();
            cmbBoxIstFiltre = new ComboBox();
            tLayoutPChartButton = new TableLayoutPanel();
            chartSatis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            pnlIeri = new Panel();
            btnIleri = new Button();
            tLayoutPButtonSayfa.SuspendLayout();
            panelButtons.SuspendLayout();
            tLayoutPButtons.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageSatis.SuspendLayout();
            tLayoutPSatisSayfa.SuspendLayout();
            tLayoutPSatisEkrani.SuspendLayout();
            tLayoutPToplamTutar.SuspendLayout();
            tLayoutPIndirimYuzde.SuspendLayout();
            tLayoutPIndirimTL.SuspendLayout();
            tLayoutPBileme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGViewSatisEkrani).BeginInit();
            tLayoutPTutar.SuspendLayout();
            tLayoutPSatisSayfaSol.SuspendLayout();
            tLayoutPHesapMakinesi.SuspendLayout();
            tabPageIstatistik.SuspendLayout();
            tLayoutPIstPasta.SuspendLayout();
            tLayoutPIstUst.SuspendLayout();
            tLayoutPChartButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartSatis).BeginInit();
            pnlIeri.SuspendLayout();
            SuspendLayout();
            // 
            // tLayoutPButtonSayfa
            // 
            tLayoutPButtonSayfa.ColumnCount = 2;
            tLayoutPButtonSayfa.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 192F));
            tLayoutPButtonSayfa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tLayoutPButtonSayfa.Controls.Add(panelButtons, 0, 0);
            tLayoutPButtonSayfa.Controls.Add(tabControl1, 1, 0);
            tLayoutPButtonSayfa.Dock = DockStyle.Fill;
            tLayoutPButtonSayfa.Location = new Point(0, 0);
            tLayoutPButtonSayfa.Name = "tLayoutPButtonSayfa";
            tLayoutPButtonSayfa.RowCount = 1;
            tLayoutPButtonSayfa.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tLayoutPButtonSayfa.Size = new Size(1115, 546);
            tLayoutPButtonSayfa.TabIndex = 0;
            tLayoutPButtonSayfa.Paint += tLayoutPButtonSayfa_Paint;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = SystemColors.Control;
            panelButtons.Controls.Add(tLayoutPButtons);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 3);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(186, 540);
            panelButtons.TabIndex = 0;
            panelButtons.Paint += panelButtons_Paint;
            // 
            // tLayoutPButtons
            // 
            tLayoutPButtons.ColumnCount = 1;
            tLayoutPButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tLayoutPButtons.Controls.Add(btnIstatistik, 0, 4);
            tLayoutPButtons.Controls.Add(btnGecmis, 0, 3);
            tLayoutPButtons.Controls.Add(btnStok, 0, 2);
            tLayoutPButtons.Controls.Add(btnSatis, 0, 0);
            tLayoutPButtons.Controls.Add(btnUrun, 0, 1);
            tLayoutPButtons.Dock = DockStyle.Top;
            tLayoutPButtons.Location = new Point(0, 0);
            tLayoutPButtons.Name = "tLayoutPButtons";
            tLayoutPButtons.RowCount = 5;
            tLayoutPButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tLayoutPButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tLayoutPButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tLayoutPButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tLayoutPButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tLayoutPButtons.Size = new Size(186, 293);
            tLayoutPButtons.TabIndex = 0;
            // 
            // btnIstatistik
            // 
            btnIstatistik.Dock = DockStyle.Fill;
            btnIstatistik.FlatAppearance.BorderSize = 0;
            btnIstatistik.FlatStyle = FlatStyle.Flat;
            btnIstatistik.Location = new Point(3, 235);
            btnIstatistik.Name = "btnIstatistik";
            btnIstatistik.Size = new Size(180, 55);
            btnIstatistik.TabIndex = 4;
            btnIstatistik.Text = "İstatistik";
            btnIstatistik.UseVisualStyleBackColor = true;
            btnIstatistik.Click += btnIstatistik_Click;
            // 
            // btnGecmis
            // 
            btnGecmis.Dock = DockStyle.Fill;
            btnGecmis.FlatAppearance.BorderSize = 0;
            btnGecmis.FlatStyle = FlatStyle.Flat;
            btnGecmis.Location = new Point(3, 177);
            btnGecmis.Name = "btnGecmis";
            btnGecmis.Size = new Size(180, 52);
            btnGecmis.TabIndex = 3;
            btnGecmis.Text = "Gecmis";
            btnGecmis.UseVisualStyleBackColor = true;
            btnGecmis.Click += btnGecmis_Click;
            // 
            // btnStok
            // 
            btnStok.Dock = DockStyle.Fill;
            btnStok.FlatAppearance.BorderSize = 0;
            btnStok.FlatStyle = FlatStyle.Flat;
            btnStok.Location = new Point(3, 119);
            btnStok.Name = "btnStok";
            btnStok.Size = new Size(180, 52);
            btnStok.TabIndex = 2;
            btnStok.Text = "Stok";
            btnStok.UseVisualStyleBackColor = true;
            btnStok.Click += btnStok_Click;
            // 
            // btnSatis
            // 
            btnSatis.Dock = DockStyle.Fill;
            btnSatis.FlatAppearance.BorderSize = 0;
            btnSatis.FlatStyle = FlatStyle.Flat;
            btnSatis.Location = new Point(3, 3);
            btnSatis.Name = "btnSatis";
            btnSatis.Size = new Size(180, 52);
            btnSatis.TabIndex = 0;
            btnSatis.Text = "Satış";
            btnSatis.UseVisualStyleBackColor = true;
            btnSatis.Click += btnSatis_Click;
            // 
            // btnUrun
            // 
            btnUrun.Dock = DockStyle.Fill;
            btnUrun.FlatAppearance.BorderSize = 0;
            btnUrun.FlatStyle = FlatStyle.Flat;
            btnUrun.Location = new Point(3, 61);
            btnUrun.Name = "btnUrun";
            btnUrun.Size = new Size(180, 52);
            btnUrun.TabIndex = 1;
            btnUrun.Text = "Urun";
            btnUrun.UseVisualStyleBackColor = true;
            btnUrun.Click += btnUrun_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageSatis);
            tabControl1.Controls.Add(tabPageUrun);
            tabControl1.Controls.Add(tabPageStok);
            tabControl1.Controls.Add(tabPageGecmis);
            tabControl1.Controls.Add(tabPageIstatistik);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(195, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(917, 540);
            tabControl1.TabIndex = 1;
            // 
            // tabPageSatis
            // 
            tabPageSatis.Controls.Add(tLayoutPSatisSayfa);
            tabPageSatis.Location = new Point(4, 29);
            tabPageSatis.Name = "tabPageSatis";
            tabPageSatis.Padding = new Padding(3);
            tabPageSatis.Size = new Size(909, 507);
            tabPageSatis.TabIndex = 0;
            tabPageSatis.Text = "Satış";
            tabPageSatis.UseVisualStyleBackColor = true;
            // 
            // tLayoutPSatisSayfa
            // 
            tLayoutPSatisSayfa.ColumnCount = 2;
            tLayoutPSatisSayfa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.26009F));
            tLayoutPSatisSayfa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.7399139F));
            tLayoutPSatisSayfa.Controls.Add(tLayoutPSatisEkrani, 1, 0);
            tLayoutPSatisSayfa.Controls.Add(tLayoutPSatisSayfaSol, 0, 0);
            tLayoutPSatisSayfa.Dock = DockStyle.Fill;
            tLayoutPSatisSayfa.Location = new Point(3, 3);
            tLayoutPSatisSayfa.Name = "tLayoutPSatisSayfa";
            tLayoutPSatisSayfa.RowCount = 1;
            tLayoutPSatisSayfa.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tLayoutPSatisSayfa.Size = new Size(903, 501);
            tLayoutPSatisSayfa.TabIndex = 2;
            // 
            // tLayoutPSatisEkrani
            // 
            tLayoutPSatisEkrani.ColumnCount = 1;
            tLayoutPSatisEkrani.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tLayoutPSatisEkrani.Controls.Add(tLayoutPToplamTutar, 0, 5);
            tLayoutPSatisEkrani.Controls.Add(tLayoutPIndirimYuzde, 0, 4);
            tLayoutPSatisEkrani.Controls.Add(tLayoutPIndirimTL, 0, 3);
            tLayoutPSatisEkrani.Controls.Add(tLayoutPBileme, 0, 2);
            tLayoutPSatisEkrani.Controls.Add(dataGViewSatisEkrani, 0, 0);
            tLayoutPSatisEkrani.Controls.Add(tLayoutPTutar, 0, 1);
            tLayoutPSatisEkrani.Controls.Add(btnSatisYap, 0, 6);
            tLayoutPSatisEkrani.Dock = DockStyle.Fill;
            tLayoutPSatisEkrani.Location = new Point(267, 3);
            tLayoutPSatisEkrani.Name = "tLayoutPSatisEkrani";
            tLayoutPSatisEkrani.RowCount = 7;
            tLayoutPSatisEkrani.RowStyles.Add(new RowStyle(SizeType.Percent, 58F));
            tLayoutPSatisEkrani.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tLayoutPSatisEkrani.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tLayoutPSatisEkrani.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tLayoutPSatisEkrani.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tLayoutPSatisEkrani.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tLayoutPSatisEkrani.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tLayoutPSatisEkrani.Size = new Size(633, 495);
            tLayoutPSatisEkrani.TabIndex = 0;
            tLayoutPSatisEkrani.Paint += tLayoutPSatisEkrani_Paint;
            // 
            // tLayoutPToplamTutar
            // 
            tLayoutPToplamTutar.ColumnCount = 3;
            tLayoutPToplamTutar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tLayoutPToplamTutar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tLayoutPToplamTutar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tLayoutPToplamTutar.Controls.Add(txtBoxToplamTutar, 1, 0);
            tLayoutPToplamTutar.Controls.Add(lblToplamTutar, 0, 0);
            tLayoutPToplamTutar.Dock = DockStyle.Fill;
            tLayoutPToplamTutar.Location = new Point(3, 406);
            tLayoutPToplamTutar.Name = "tLayoutPToplamTutar";
            tLayoutPToplamTutar.RowCount = 1;
            tLayoutPToplamTutar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tLayoutPToplamTutar.Size = new Size(627, 23);
            tLayoutPToplamTutar.TabIndex = 5;
            // 
            // txtBoxToplamTutar
            // 
            txtBoxToplamTutar.Anchor = AnchorStyles.None;
            txtBoxToplamTutar.Location = new Point(348, 3);
            txtBoxToplamTutar.Name = "txtBoxToplamTutar";
            txtBoxToplamTutar.Size = new Size(116, 27);
            txtBoxToplamTutar.TabIndex = 2;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.Anchor = AnchorStyles.Right;
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Location = new Point(150, 1);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(97, 20);
            lblToplamTutar.TabIndex = 1;
            lblToplamTutar.Text = "Toplam Tutar";
            // 
            // tLayoutPIndirimYuzde
            // 
            tLayoutPIndirimYuzde.ColumnCount = 3;
            tLayoutPIndirimYuzde.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tLayoutPIndirimYuzde.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tLayoutPIndirimYuzde.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tLayoutPIndirimYuzde.Controls.Add(txtBoxIndirimYuzde, 1, 0);
            tLayoutPIndirimYuzde.Controls.Add(lblIndirimYuzde, 0, 0);
            tLayoutPIndirimYuzde.Dock = DockStyle.Fill;
            tLayoutPIndirimYuzde.Location = new Point(3, 377);
            tLayoutPIndirimYuzde.Name = "tLayoutPIndirimYuzde";
            tLayoutPIndirimYuzde.RowCount = 1;
            tLayoutPIndirimYuzde.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tLayoutPIndirimYuzde.Size = new Size(627, 23);
            tLayoutPIndirimYuzde.TabIndex = 4;
            // 
            // txtBoxIndirimYuzde
            // 
            txtBoxIndirimYuzde.Anchor = AnchorStyles.None;
            txtBoxIndirimYuzde.Location = new Point(348, 3);
            txtBoxIndirimYuzde.Name = "txtBoxIndirimYuzde";
            txtBoxIndirimYuzde.Size = new Size(116, 27);
            txtBoxIndirimYuzde.TabIndex = 2;
            // 
            // lblIndirimYuzde
            // 
            lblIndirimYuzde.Anchor = AnchorStyles.Right;
            lblIndirimYuzde.AutoSize = true;
            lblIndirimYuzde.Location = new Point(169, 1);
            lblIndirimYuzde.Name = "lblIndirimYuzde";
            lblIndirimYuzde.Size = new Size(78, 20);
            lblIndirimYuzde.TabIndex = 1;
            lblIndirimYuzde.Text = "İndirim(%)";
            // 
            // tLayoutPIndirimTL
            // 
            tLayoutPIndirimTL.ColumnCount = 3;
            tLayoutPIndirimTL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tLayoutPIndirimTL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tLayoutPIndirimTL.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tLayoutPIndirimTL.Controls.Add(txtBoxIndirimTL, 1, 0);
            tLayoutPIndirimTL.Controls.Add(lblIndirimTL, 0, 0);
            tLayoutPIndirimTL.Dock = DockStyle.Fill;
            tLayoutPIndirimTL.Location = new Point(3, 348);
            tLayoutPIndirimTL.Name = "tLayoutPIndirimTL";
            tLayoutPIndirimTL.RowCount = 1;
            tLayoutPIndirimTL.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tLayoutPIndirimTL.Size = new Size(627, 23);
            tLayoutPIndirimTL.TabIndex = 3;
            // 
            // txtBoxIndirimTL
            // 
            txtBoxIndirimTL.Anchor = AnchorStyles.None;
            txtBoxIndirimTL.Location = new Point(348, 3);
            txtBoxIndirimTL.Name = "txtBoxIndirimTL";
            txtBoxIndirimTL.Size = new Size(116, 27);
            txtBoxIndirimTL.TabIndex = 2;
            // 
            // lblIndirimTL
            // 
            lblIndirimTL.Anchor = AnchorStyles.Right;
            lblIndirimTL.AutoSize = true;
            lblIndirimTL.Location = new Point(173, 1);
            lblIndirimTL.Name = "lblIndirimTL";
            lblIndirimTL.Size = new Size(74, 20);
            lblIndirimTL.TabIndex = 1;
            lblIndirimTL.Text = "İndirim(₺)";
            // 
            // tLayoutPBileme
            // 
            tLayoutPBileme.ColumnCount = 3;
            tLayoutPBileme.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tLayoutPBileme.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tLayoutPBileme.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tLayoutPBileme.Controls.Add(lblBileme, 0, 0);
            tLayoutPBileme.Controls.Add(txtBoxBileme, 1, 0);
            tLayoutPBileme.Dock = DockStyle.Fill;
            tLayoutPBileme.Location = new Point(3, 319);
            tLayoutPBileme.Name = "tLayoutPBileme";
            tLayoutPBileme.RowCount = 1;
            tLayoutPBileme.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tLayoutPBileme.Size = new Size(627, 23);
            tLayoutPBileme.TabIndex = 2;
            // 
            // lblBileme
            // 
            lblBileme.Anchor = AnchorStyles.Right;
            lblBileme.AutoSize = true;
            lblBileme.Location = new Point(192, 1);
            lblBileme.Name = "lblBileme";
            lblBileme.Size = new Size(55, 20);
            lblBileme.TabIndex = 0;
            lblBileme.Text = "Bileme";
            // 
            // txtBoxBileme
            // 
            txtBoxBileme.Anchor = AnchorStyles.None;
            txtBoxBileme.Location = new Point(348, 3);
            txtBoxBileme.Name = "txtBoxBileme";
            txtBoxBileme.Size = new Size(116, 27);
            txtBoxBileme.TabIndex = 2;
            // 
            // dataGViewSatisEkrani
            // 
            dataGViewSatisEkrani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGViewSatisEkrani.Dock = DockStyle.Fill;
            dataGViewSatisEkrani.Location = new Point(3, 3);
            dataGViewSatisEkrani.Name = "dataGViewSatisEkrani";
            dataGViewSatisEkrani.RowHeadersWidth = 51;
            dataGViewSatisEkrani.Size = new Size(627, 281);
            dataGViewSatisEkrani.TabIndex = 0;
            // 
            // tLayoutPTutar
            // 
            tLayoutPTutar.ColumnCount = 3;
            tLayoutPTutar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tLayoutPTutar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tLayoutPTutar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tLayoutPTutar.Controls.Add(lblTutar, 0, 0);
            tLayoutPTutar.Controls.Add(txtBoxTutar, 1, 0);
            tLayoutPTutar.Dock = DockStyle.Fill;
            tLayoutPTutar.Location = new Point(3, 290);
            tLayoutPTutar.Name = "tLayoutPTutar";
            tLayoutPTutar.RowCount = 1;
            tLayoutPTutar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tLayoutPTutar.Size = new Size(627, 23);
            tLayoutPTutar.TabIndex = 1;
            // 
            // lblTutar
            // 
            lblTutar.Anchor = AnchorStyles.Right;
            lblTutar.AutoSize = true;
            lblTutar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTutar.Location = new Point(207, 1);
            lblTutar.Margin = new Padding(0);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(43, 20);
            lblTutar.TabIndex = 2;
            lblTutar.Text = "Tutar";
            // 
            // txtBoxTutar
            // 
            txtBoxTutar.Anchor = AnchorStyles.None;
            txtBoxTutar.Location = new Point(348, 3);
            txtBoxTutar.Name = "txtBoxTutar";
            txtBoxTutar.Size = new Size(116, 27);
            txtBoxTutar.TabIndex = 1;
            // 
            // btnSatisYap
            // 
            btnSatisYap.Anchor = AnchorStyles.None;
            btnSatisYap.Location = new Point(254, 440);
            btnSatisYap.Name = "btnSatisYap";
            btnSatisYap.Size = new Size(124, 46);
            btnSatisYap.TabIndex = 6;
            btnSatisYap.Text = "Satış Yap";
            btnSatisYap.UseVisualStyleBackColor = true;
            // 
            // tLayoutPSatisSayfaSol
            // 
            tLayoutPSatisSayfaSol.ColumnCount = 1;
            tLayoutPSatisSayfaSol.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tLayoutPSatisSayfaSol.Controls.Add(tLayoutPHesapMakinesi, 0, 0);
            tLayoutPSatisSayfaSol.Dock = DockStyle.Fill;
            tLayoutPSatisSayfaSol.Location = new Point(3, 3);
            tLayoutPSatisSayfaSol.Name = "tLayoutPSatisSayfaSol";
            tLayoutPSatisSayfaSol.RowCount = 2;
            tLayoutPSatisSayfaSol.RowStyles.Add(new RowStyle(SizeType.Percent, 58F));
            tLayoutPSatisSayfaSol.RowStyles.Add(new RowStyle(SizeType.Percent, 42F));
            tLayoutPSatisSayfaSol.Size = new Size(258, 495);
            tLayoutPSatisSayfaSol.TabIndex = 1;
            tLayoutPSatisSayfaSol.Paint += tLayoutPSatisSayfaSol_Paint;
            // 
            // tLayoutPHesapMakinesi
            // 
            tLayoutPHesapMakinesi.ColumnCount = 5;
            tLayoutPHesapMakinesi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tLayoutPHesapMakinesi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tLayoutPHesapMakinesi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tLayoutPHesapMakinesi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tLayoutPHesapMakinesi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tLayoutPHesapMakinesi.Controls.Add(btn7, 0, 0);
            tLayoutPHesapMakinesi.Controls.Add(btn8, 1, 0);
            tLayoutPHesapMakinesi.Controls.Add(btn9, 2, 0);
            tLayoutPHesapMakinesi.Controls.Add(btnBolme, 3, 0);
            tLayoutPHesapMakinesi.Controls.Add(btnAC, 4, 0);
            tLayoutPHesapMakinesi.Controls.Add(btn4, 0, 1);
            tLayoutPHesapMakinesi.Controls.Add(btn5, 1, 1);
            tLayoutPHesapMakinesi.Controls.Add(btn6, 2, 1);
            tLayoutPHesapMakinesi.Controls.Add(btnCarpma, 3, 1);
            tLayoutPHesapMakinesi.Controls.Add(btnDEL, 4, 1);
            tLayoutPHesapMakinesi.Controls.Add(btn1, 0, 2);
            tLayoutPHesapMakinesi.Controls.Add(btn2, 1, 2);
            tLayoutPHesapMakinesi.Controls.Add(btn3, 2, 2);
            tLayoutPHesapMakinesi.Controls.Add(btn0, 0, 3);
            tLayoutPHesapMakinesi.Controls.Add(button20, 1, 3);
            tLayoutPHesapMakinesi.Controls.Add(btnNokta, 2, 3);
            tLayoutPHesapMakinesi.Controls.Add(btnEsittir, 4, 3);
            tLayoutPHesapMakinesi.Controls.Add(btnCikarma, 4, 2);
            tLayoutPHesapMakinesi.Controls.Add(btnToplama, 3, 2);
            tLayoutPHesapMakinesi.Dock = DockStyle.Fill;
            tLayoutPHesapMakinesi.Location = new Point(3, 3);
            tLayoutPHesapMakinesi.Name = "tLayoutPHesapMakinesi";
            tLayoutPHesapMakinesi.RowCount = 4;
            tLayoutPHesapMakinesi.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tLayoutPHesapMakinesi.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tLayoutPHesapMakinesi.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tLayoutPHesapMakinesi.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tLayoutPHesapMakinesi.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tLayoutPHesapMakinesi.Size = new Size(252, 281);
            tLayoutPHesapMakinesi.TabIndex = 1;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.Location = new Point(3, 3);
            btn7.Name = "btn7";
            btn7.Size = new Size(44, 64);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.Location = new Point(53, 3);
            btn8.Name = "btn8";
            btn8.Size = new Size(44, 64);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.Location = new Point(103, 3);
            btn9.Name = "btn9";
            btn9.Size = new Size(44, 64);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btnBolme
            // 
            btnBolme.Dock = DockStyle.Fill;
            btnBolme.Location = new Point(153, 3);
            btnBolme.Name = "btnBolme";
            btnBolme.Size = new Size(44, 64);
            btnBolme.TabIndex = 3;
            btnBolme.Text = "%";
            btnBolme.UseVisualStyleBackColor = true;
            // 
            // btnAC
            // 
            btnAC.Dock = DockStyle.Fill;
            btnAC.Location = new Point(203, 3);
            btnAC.Name = "btnAC";
            btnAC.Size = new Size(46, 64);
            btnAC.TabIndex = 16;
            btnAC.Text = "AC";
            btnAC.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.Location = new Point(3, 73);
            btn4.Name = "btn4";
            btn4.Size = new Size(44, 64);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.Location = new Point(53, 73);
            btn5.Name = "btn5";
            btn5.Size = new Size(44, 64);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.Location = new Point(103, 73);
            btn6.Name = "btn6";
            btn6.Size = new Size(44, 64);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btnCarpma
            // 
            btnCarpma.Dock = DockStyle.Fill;
            btnCarpma.Location = new Point(153, 73);
            btnCarpma.Name = "btnCarpma";
            btnCarpma.Size = new Size(44, 64);
            btnCarpma.TabIndex = 7;
            btnCarpma.Text = "X";
            btnCarpma.UseVisualStyleBackColor = true;
            // 
            // btnDEL
            // 
            btnDEL.Dock = DockStyle.Fill;
            btnDEL.Location = new Point(203, 73);
            btnDEL.Name = "btnDEL";
            btnDEL.Size = new Size(46, 64);
            btnDEL.TabIndex = 17;
            btnDEL.Text = "DEL";
            btnDEL.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.Location = new Point(3, 143);
            btn1.Name = "btn1";
            btn1.Size = new Size(44, 64);
            btn1.TabIndex = 8;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.Location = new Point(53, 143);
            btn2.Name = "btn2";
            btn2.Size = new Size(44, 64);
            btn2.TabIndex = 9;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.Location = new Point(103, 143);
            btn3.Name = "btn3";
            btn3.Size = new Size(44, 64);
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Dock = DockStyle.Fill;
            btn0.Location = new Point(3, 213);
            btn0.Name = "btn0";
            btn0.Size = new Size(44, 65);
            btn0.TabIndex = 11;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Dock = DockStyle.Fill;
            button20.Location = new Point(53, 213);
            button20.Name = "button20";
            button20.Size = new Size(44, 65);
            button20.TabIndex = 16;
            button20.Text = "00";
            button20.UseVisualStyleBackColor = true;
            // 
            // btnNokta
            // 
            btnNokta.Dock = DockStyle.Fill;
            btnNokta.Location = new Point(103, 213);
            btnNokta.Name = "btnNokta";
            btnNokta.Size = new Size(44, 65);
            btnNokta.TabIndex = 12;
            btnNokta.Text = ".";
            btnNokta.UseVisualStyleBackColor = true;
            // 
            // btnEsittir
            // 
            btnEsittir.Dock = DockStyle.Fill;
            btnEsittir.Location = new Point(203, 213);
            btnEsittir.Name = "btnEsittir";
            btnEsittir.Size = new Size(46, 65);
            btnEsittir.TabIndex = 13;
            btnEsittir.Text = "=";
            btnEsittir.UseVisualStyleBackColor = true;
            // 
            // btnCikarma
            // 
            btnCikarma.Dock = DockStyle.Fill;
            btnCikarma.Location = new Point(203, 143);
            btnCikarma.Name = "btnCikarma";
            btnCikarma.Size = new Size(46, 64);
            btnCikarma.TabIndex = 15;
            btnCikarma.Text = "-";
            btnCikarma.UseVisualStyleBackColor = true;
            // 
            // btnToplama
            // 
            btnToplama.Dock = DockStyle.Fill;
            btnToplama.Location = new Point(153, 143);
            btnToplama.Name = "btnToplama";
            tLayoutPHesapMakinesi.SetRowSpan(btnToplama, 2);
            btnToplama.Size = new Size(44, 135);
            btnToplama.TabIndex = 14;
            btnToplama.Text = "+";
            btnToplama.UseVisualStyleBackColor = true;
            // 
            // tabPageUrun
            // 
            tabPageUrun.Location = new Point(4, 29);
            tabPageUrun.Name = "tabPageUrun";
            tabPageUrun.Padding = new Padding(3);
            tabPageUrun.Size = new Size(909, 507);
            tabPageUrun.TabIndex = 1;
            tabPageUrun.Text = "Ürün";
            tabPageUrun.UseVisualStyleBackColor = true;
            // 
            // tabPageStok
            // 
            tabPageStok.Location = new Point(4, 29);
            tabPageStok.Name = "tabPageStok";
            tabPageStok.Padding = new Padding(3);
            tabPageStok.Size = new Size(909, 507);
            tabPageStok.TabIndex = 2;
            tabPageStok.Text = "Stok";
            tabPageStok.UseVisualStyleBackColor = true;
            // 
            // tabPageGecmis
            // 
            tabPageGecmis.Location = new Point(4, 29);
            tabPageGecmis.Name = "tabPageGecmis";
            tabPageGecmis.Padding = new Padding(3);
            tabPageGecmis.Size = new Size(909, 507);
            tabPageGecmis.TabIndex = 3;
            tabPageGecmis.Text = "Gecmiş";
            tabPageGecmis.UseVisualStyleBackColor = true;
            // 
            // tabPageIstatistik
            // 
            tabPageIstatistik.Controls.Add(tLayoutPIstPasta);
            tabPageIstatistik.Location = new Point(4, 29);
            tabPageIstatistik.Name = "tabPageIstatistik";
            tabPageIstatistik.Padding = new Padding(3);
            tabPageIstatistik.Size = new Size(909, 507);
            tabPageIstatistik.TabIndex = 4;
            tabPageIstatistik.Text = "İstatistik";
            tabPageIstatistik.UseVisualStyleBackColor = true;
            // 
            // tLayoutPIstPasta
            // 
            tLayoutPIstPasta.ColumnCount = 1;
            tLayoutPIstPasta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tLayoutPIstPasta.Controls.Add(tLayoutPIstUst, 0, 0);
            tLayoutPIstPasta.Controls.Add(tLayoutPChartButton, 0, 1);
            tLayoutPIstPasta.Dock = DockStyle.Fill;
            tLayoutPIstPasta.Location = new Point(3, 3);
            tLayoutPIstPasta.Name = "tLayoutPIstPasta";
            tLayoutPIstPasta.RowCount = 2;
            tLayoutPIstPasta.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tLayoutPIstPasta.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tLayoutPIstPasta.Size = new Size(903, 501);
            tLayoutPIstPasta.TabIndex = 0;
            // 
            // tLayoutPIstUst
            // 
            tLayoutPIstUst.ColumnCount = 2;
            tLayoutPIstUst.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tLayoutPIstUst.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tLayoutPIstUst.Controls.Add(lblUrunBazindaYuzdeliSatis, 0, 0);
            tLayoutPIstUst.Controls.Add(cmbBoxIstFiltre, 1, 0);
            tLayoutPIstUst.Dock = DockStyle.Fill;
            tLayoutPIstUst.Location = new Point(3, 3);
            tLayoutPIstUst.Name = "tLayoutPIstUst";
            tLayoutPIstUst.RowCount = 1;
            tLayoutPIstUst.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tLayoutPIstUst.Size = new Size(897, 44);
            tLayoutPIstUst.TabIndex = 0;
            // 
            // lblUrunBazindaYuzdeliSatis
            // 
            lblUrunBazindaYuzdeliSatis.AutoSize = true;
            lblUrunBazindaYuzdeliSatis.Dock = DockStyle.Left;
            lblUrunBazindaYuzdeliSatis.Location = new Point(3, 0);
            lblUrunBazindaYuzdeliSatis.Name = "lblUrunBazindaYuzdeliSatis";
            lblUrunBazindaYuzdeliSatis.Size = new Size(231, 44);
            lblUrunBazindaYuzdeliSatis.TabIndex = 0;
            lblUrunBazindaYuzdeliSatis.Text = "Ürün Bazında Yüzdelik Satış Oranı";
            // 
            // cmbBoxIstFiltre
            // 
            cmbBoxIstFiltre.Anchor = AnchorStyles.None;
            cmbBoxIstFiltre.FormattingEnabled = true;
            cmbBoxIstFiltre.Items.AddRange(new object[] { "Günlük", "Haftalık", "Aylık" });
            cmbBoxIstFiltre.Location = new Point(686, 8);
            cmbBoxIstFiltre.Name = "cmbBoxIstFiltre";
            cmbBoxIstFiltre.Size = new Size(151, 28);
            cmbBoxIstFiltre.TabIndex = 1;
            // 
            // tLayoutPChartButton
            // 
            tLayoutPChartButton.ColumnCount = 2;
            tLayoutPChartButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tLayoutPChartButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tLayoutPChartButton.Controls.Add(chartSatis, 0, 0);
            tLayoutPChartButton.Controls.Add(pnlIeri, 1, 0);
            tLayoutPChartButton.Dock = DockStyle.Fill;
            tLayoutPChartButton.Location = new Point(3, 53);
            tLayoutPChartButton.Name = "tLayoutPChartButton";
            tLayoutPChartButton.RowCount = 1;
            tLayoutPChartButton.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tLayoutPChartButton.Size = new Size(897, 445);
            tLayoutPChartButton.TabIndex = 1;
            // 
            // chartSatis
            // 
            chartArea1.Name = "ChartArea1";
            chartSatis.ChartAreas.Add(chartArea1);
            chartSatis.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartSatis.Legends.Add(legend1);
            chartSatis.Location = new Point(3, 3);
            chartSatis.Name = "chartSatis";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartSatis.Series.Add(series1);
            chartSatis.Size = new Size(801, 439);
            chartSatis.TabIndex = 0;
            chartSatis.Text = "chart1";
            // 
            // pnlIeri
            // 
            pnlIeri.Anchor = AnchorStyles.Top;
            pnlIeri.Controls.Add(btnIleri);
            pnlIeri.Location = new Point(810, 3);
            pnlIeri.Name = "pnlIeri";
            pnlIeri.Size = new Size(84, 352);
            pnlIeri.TabIndex = 1;
            // 
            // btnIleri
            // 
            btnIleri.Dock = DockStyle.Bottom;
            btnIleri.Location = new Point(0, 312);
            btnIleri.Name = "btnIleri";
            btnIleri.Size = new Size(84, 40);
            btnIleri.TabIndex = 1;
            btnIleri.Text = "İleri";
            btnIleri.UseVisualStyleBackColor = true;
            btnIleri.Click += btnIleri_Click;
            // 
            // Sayfalar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 546);
            Controls.Add(tLayoutPButtonSayfa);
            MinimumSize = new Size(1122, 584);
            Name = "Sayfalar";
            Text = "Sayfalar";
            tLayoutPButtonSayfa.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            tLayoutPButtons.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageSatis.ResumeLayout(false);
            tLayoutPSatisSayfa.ResumeLayout(false);
            tLayoutPSatisEkrani.ResumeLayout(false);
            tLayoutPToplamTutar.ResumeLayout(false);
            tLayoutPToplamTutar.PerformLayout();
            tLayoutPIndirimYuzde.ResumeLayout(false);
            tLayoutPIndirimYuzde.PerformLayout();
            tLayoutPIndirimTL.ResumeLayout(false);
            tLayoutPIndirimTL.PerformLayout();
            tLayoutPBileme.ResumeLayout(false);
            tLayoutPBileme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGViewSatisEkrani).EndInit();
            tLayoutPTutar.ResumeLayout(false);
            tLayoutPTutar.PerformLayout();
            tLayoutPSatisSayfaSol.ResumeLayout(false);
            tLayoutPHesapMakinesi.ResumeLayout(false);
            tabPageIstatistik.ResumeLayout(false);
            tLayoutPIstPasta.ResumeLayout(false);
            tLayoutPIstUst.ResumeLayout(false);
            tLayoutPIstUst.PerformLayout();
            tLayoutPChartButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartSatis).EndInit();
            pnlIeri.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tLayoutPButtonSayfa;
        private Panel panelButtons;
        private TableLayoutPanel tLayoutPButtons;
        private Button btnIstatistik;
        private Button btnGecmis;
        private Button btnStok;
        private Button btnSatis;
        private Button btnUrun;
        private TabControl tabControl1;
        private TabPage tabPageSatis;
        private TabPage tabPageUrun;
        private TabPage tabPageStok;
        private TabPage tabPageGecmis;
        private TabPage tabPageIstatistik;
        private TableLayoutPanel tLayoutPSatisSayfa;
        private TableLayoutPanel tLayoutPSatisEkrani;
        private DataGridView dataGViewSatisEkrani;
        private TableLayoutPanel tLayoutPToplamTutar;
        private TextBox txtBoxToplamTutar;
        private TableLayoutPanel tLayoutPIndirimYuzde;
        private TextBox txtBoxIndirimYuzde;
        private Label lblToplamTutar;
        private TableLayoutPanel tLayoutPIndirimTL;
        private TextBox txtBoxIndirimTL;
        private Label lblIndirimYuzde;
        private TableLayoutPanel tLayoutPBileme;
        private TextBox txtBoxBileme;
        private Label lblIndirimTL;
        private TableLayoutPanel tLayoutPTutar;
        private Label lblBileme;
        private TextBox txtBoxTutar;
        private Label lblTutar;
        private Button btnSatisYap;
        private TableLayoutPanel tLayoutPSatisSayfaSol;
        private TableLayoutPanel tLayoutPHesapMakinesi;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnBolme;
        private Button btnAC;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnCarpma;
        private Button btnDEL;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button button20;
        private Button btnNokta;
        private Button btnEsittir;
        private Button btnCikarma;
        private Button btnToplama;
        private TableLayoutPanel tLayoutPIstPasta;
        private TableLayoutPanel tLayoutPIstUst;
        private Label lblUrunBazindaYuzdeliSatis;
        private ComboBox cmbBoxIstFiltre;
        private TableLayoutPanel tLayoutPChartButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSatis;
        private Button btnIleri;
        private Panel pnlIeri;
    }
}
