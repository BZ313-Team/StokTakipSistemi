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
            pnlkAdi = new CustomPanel();
            txtboxkAdi = new TextBox();
            pboxkAdi = new PictureBox();
            pnlSifre = new CustomPanel();
            txtboxSifre = new TextBox();
            pboxSifre = new PictureBox();
            btnLogin = new Button();
            pboxLoginAna = new PictureBox();
            btnSifremiUnuttum = new Button();
            pnlkAdi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxkAdi).BeginInit();
            pnlSifre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxSifre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxLoginAna).BeginInit();
            SuspendLayout();
            // 
            // pnlkAdi
            // 
            pnlkAdi.Anchor = AnchorStyles.None;
            pnlkAdi.BackColor = Color.White;
            pnlkAdi.BorderColorHtml = "#80818B";
            pnlkAdi.BorderWidth = 1;
            pnlkAdi.Controls.Add(txtboxkAdi);
            pnlkAdi.Controls.Add(pboxkAdi);
            pnlkAdi.Location = new Point(45, 227);
            pnlkAdi.Name = "pnlkAdi";
            pnlkAdi.Size = new Size(250, 40);
            pnlkAdi.TabIndex = 0;
            // 
            // txtboxkAdi
            // 
            txtboxkAdi.Anchor = AnchorStyles.None;
            txtboxkAdi.BorderStyle = BorderStyle.None;
            txtboxkAdi.Location = new Point(70, 10);
            txtboxkAdi.Name = "txtboxkAdi";
            txtboxkAdi.Size = new Size(162, 16);
            txtboxkAdi.TabIndex = 0;
            // 
            // pboxkAdi
            // 
            pboxkAdi.Anchor = AnchorStyles.None;
            pboxkAdi.Image = (Image)resources.GetObject("pboxkAdi.Image");
            pboxkAdi.Location = new Point(11, 4);
            pboxkAdi.Name = "pboxkAdi";
            pboxkAdi.Size = new Size(30, 30);
            pboxkAdi.SizeMode = PictureBoxSizeMode.Zoom;
            pboxkAdi.TabIndex = 0;
            pboxkAdi.TabStop = false;
            // 
            // pnlSifre
            // 
            pnlSifre.Anchor = AnchorStyles.None;
            pnlSifre.BackColor = Color.White;
            pnlSifre.BorderColorHtml = "#80818B";
            pnlSifre.BorderWidth = 1;
            pnlSifre.Controls.Add(txtboxSifre);
            pnlSifre.Controls.Add(pboxSifre);
            pnlSifre.Location = new Point(45, 287);
            pnlSifre.Name = "pnlSifre";
            pnlSifre.Size = new Size(250, 40);
            pnlSifre.TabIndex = 1;
            // 
            // txtboxSifre
            // 
            txtboxSifre.Anchor = AnchorStyles.None;
            txtboxSifre.BorderStyle = BorderStyle.None;
            txtboxSifre.Location = new Point(70, 10);
            txtboxSifre.Name = "txtboxSifre";
            txtboxSifre.Size = new Size(162, 16);
            txtboxSifre.TabIndex = 0;
            // 
            // pboxSifre
            // 
            pboxSifre.Anchor = AnchorStyles.None;
            pboxSifre.Image = (Image)resources.GetObject("pboxSifre.Image");
            pboxSifre.Location = new Point(12, 4);
            pboxSifre.Name = "pboxSifre";
            pboxSifre.Size = new Size(30, 30);
            pboxSifre.SizeMode = PictureBoxSizeMode.Zoom;
            pboxSifre.TabIndex = 2;
            pboxSifre.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = SystemColors.ActiveBorder;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(45, 353);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // pboxLoginAna
            // 
            pboxLoginAna.Anchor = AnchorStyles.None;
            pboxLoginAna.Image = (Image)resources.GetObject("pboxLoginAna.Image");
            pboxLoginAna.Location = new Point(95, 79);
            pboxLoginAna.Name = "pboxLoginAna";
            pboxLoginAna.Size = new Size(125, 102);
            pboxLoginAna.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxLoginAna.TabIndex = 4;
            pboxLoginAna.TabStop = false;
            // 
            // btnSifremiUnuttum
            // 
            btnSifremiUnuttum.Anchor = AnchorStyles.None;
            btnSifremiUnuttum.BackColor = SystemColors.ActiveBorder;
            btnSifremiUnuttum.FlatAppearance.BorderSize = 0;
            btnSifremiUnuttum.FlatStyle = FlatStyle.Flat;
            btnSifremiUnuttum.ForeColor = Color.White;
            btnSifremiUnuttum.Location = new Point(195, 353);
            btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            btnSifremiUnuttum.Size = new Size(100, 40);
            btnSifremiUnuttum.TabIndex = 6;
            btnSifremiUnuttum.Text = "Şifremi Unuttum";
            btnSifremiUnuttum.UseVisualStyleBackColor = false;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 461);
            Controls.Add(btnSifremiUnuttum);
            Controls.Add(pboxLoginAna);
            Controls.Add(btnLogin);
            Controls.Add(pnlSifre);
            Controls.Add(pnlkAdi);
            Name = "Giris";
            Text = "Giris";
            Load += LoginNew_Load;
            Shown += LoginNew_Shown;
            pnlkAdi.ResumeLayout(false);
            pnlkAdi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxkAdi).EndInit();
            pnlSifre.ResumeLayout(false);
            pnlSifre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxSifre).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxLoginAna).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CustomPanel pnlkAdi;
        private CustomPanel pnlSifre;
        private PictureBox pboxkAdi;
        private PictureBox pboxSifre;
        private Button btnLogin;
        private TextBox txtboxkAdi;
        private TextBox txtboxSifre;
        private PictureBox pboxLoginAna;
        private Button btnSifremiUnuttum;
    }
}