namespace StokTakipSistemi
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            pnlKAdi = new CustomPanel();
            txtBoxKAdi = new TextBox();
            pBoxKAdi = new PictureBox();
            pnlSifre = new CustomPanel();
            txtBoxSifre = new TextBox();
            pBoxSifre = new PictureBox();
            btnLogin = new Button();
            pBoxLoginAna = new PictureBox();
            btnSifremiUnuttum = new Button();
            pnlKAdi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxKAdi).BeginInit();
            pnlSifre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxSifre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxLoginAna).BeginInit();
            SuspendLayout();
            // 
            // pnlKAdi
            // 
            pnlKAdi.Anchor = AnchorStyles.None;
            pnlKAdi.BackColor = Color.White;
            pnlKAdi.BorderColorHtml = "#80818B";
            pnlKAdi.BorderWidth = 1;
            pnlKAdi.Controls.Add(txtBoxKAdi);
            pnlKAdi.Controls.Add(pBoxKAdi);
            pnlKAdi.Location = new Point(41, 190);
            pnlKAdi.Name = "pnlKAdi";
            pnlKAdi.Size = new Size(250, 40);
            pnlKAdi.TabIndex = 0;
            // 
            // txtBoxKAdi
            // 
            txtBoxKAdi.Anchor = AnchorStyles.None;
            txtBoxKAdi.BorderStyle = BorderStyle.None;
            txtBoxKAdi.Location = new Point(70, 10);
            txtBoxKAdi.Name = "txtBoxKAdi";
            txtBoxKAdi.Size = new Size(162, 16);
            txtBoxKAdi.TabIndex = 0;
            // 
            // pBoxKAdi
            // 
            pBoxKAdi.Anchor = AnchorStyles.None;
            pBoxKAdi.Image = (Image)resources.GetObject("pBoxKAdi.Image");
            pBoxKAdi.Location = new Point(11, 4);
            pBoxKAdi.Name = "pBoxKAdi";
            pBoxKAdi.Size = new Size(30, 30);
            pBoxKAdi.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxKAdi.TabIndex = 0;
            pBoxKAdi.TabStop = false;
            // 
            // pnlSifre
            // 
            pnlSifre.Anchor = AnchorStyles.None;
            pnlSifre.BackColor = Color.White;
            pnlSifre.BorderColorHtml = "#80818B";
            pnlSifre.BorderWidth = 1;
            pnlSifre.Controls.Add(txtBoxSifre);
            pnlSifre.Controls.Add(pBoxSifre);
            pnlSifre.Location = new Point(41, 250);
            pnlSifre.Name = "pnlSifre";
            pnlSifre.Size = new Size(250, 40);
            pnlSifre.TabIndex = 1;
            // 
            // txtBoxSifre
            // 
            txtBoxSifre.Anchor = AnchorStyles.None;
            txtBoxSifre.BorderStyle = BorderStyle.None;
            txtBoxSifre.Location = new Point(70, 10);
            txtBoxSifre.Name = "txtBoxSifre";
            txtBoxSifre.Size = new Size(162, 16);
            txtBoxSifre.TabIndex = 0;
            // 
            // pBoxSifre
            // 
            pBoxSifre.Anchor = AnchorStyles.None;
            pBoxSifre.Image = (Image)resources.GetObject("pBoxSifre.Image");
            pBoxSifre.Location = new Point(12, 4);
            pBoxSifre.Name = "pBoxSifre";
            pBoxSifre.Size = new Size(30, 30);
            pBoxSifre.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxSifre.TabIndex = 2;
            pBoxSifre.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = SystemColors.ActiveBorder;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(41, 316);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pBoxLoginAna
            // 
            pBoxLoginAna.Anchor = AnchorStyles.None;
            pBoxLoginAna.Image = (Image)resources.GetObject("pBoxLoginAna.Image");
            pBoxLoginAna.Location = new Point(92, 42);
            pBoxLoginAna.Name = "pBoxLoginAna";
            pBoxLoginAna.Size = new Size(125, 102);
            pBoxLoginAna.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxLoginAna.TabIndex = 4;
            pBoxLoginAna.TabStop = false;
            // 
            // btnSifremiUnuttum
            // 
            btnSifremiUnuttum.Anchor = AnchorStyles.None;
            btnSifremiUnuttum.BackColor = SystemColors.ActiveBorder;
            btnSifremiUnuttum.FlatAppearance.BorderSize = 0;
            btnSifremiUnuttum.FlatStyle = FlatStyle.Flat;
            btnSifremiUnuttum.ForeColor = Color.White;
            btnSifremiUnuttum.Location = new Point(192, 316);
            btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            btnSifremiUnuttum.Size = new Size(100, 40);
            btnSifremiUnuttum.TabIndex = 6;
            btnSifremiUnuttum.Text = "Şifremi Unuttum";
            btnSifremiUnuttum.UseVisualStyleBackColor = false;
            btnSifremiUnuttum.Click += btnSifremiUnuttum_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 387);
            Controls.Add(btnSifremiUnuttum);
            Controls.Add(pBoxLoginAna);
            Controls.Add(btnLogin);
            Controls.Add(pnlSifre);
            Controls.Add(pnlKAdi);
            Name = "Giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giris";
            Load += LoginNew_Load;
            Shown += LoginNew_Shown;
            pnlKAdi.ResumeLayout(false);
            pnlKAdi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxKAdi).EndInit();
            pnlSifre.ResumeLayout(false);
            pnlSifre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxSifre).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxLoginAna).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomPanel pnlKAdi;
        private CustomPanel pnlSifre;
        private PictureBox pBoxKAdi;
        private PictureBox pBoxSifre;
        private Button btnLogin;
        private TextBox txtBoxKAdi;
        private TextBox txtBoxSifre;
        private PictureBox pBoxLoginAna;
        private Button btnSifremiUnuttum;
    }
}