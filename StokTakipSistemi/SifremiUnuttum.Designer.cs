namespace StokTakipSistemi
{
    partial class SifremiUnuttum
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
            lblSifreniz = new Label();
            lblSfrGoster = new Label();
            SuspendLayout();
            // 
            // lblSifreniz
            // 
            lblSifreniz.Anchor = AnchorStyles.None;
            lblSifreniz.AutoSize = true;
            lblSifreniz.Location = new Point(93, 27);
            lblSifreniz.Name = "lblSifreniz";
            lblSifreniz.Size = new Size(61, 20);
            lblSifreniz.TabIndex = 0;
            lblSifreniz.Text = "Şifreniz:";
            // 
            // lblSfrGoster
            // 
            lblSfrGoster.Anchor = AnchorStyles.None;
            lblSfrGoster.AutoSize = true;
            lblSfrGoster.Location = new Point(168, 27);
            lblSfrGoster.Name = "lblSfrGoster";
            lblSfrGoster.Size = new Size(42, 20);
            lblSfrGoster.TabIndex = 1;
            lblSfrGoster.Text = "123q";
            // 
            // SifremiUnuttum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 86);
            Controls.Add(lblSfrGoster);
            Controls.Add(lblSifreniz);
            Location = new Point(600, 700);
            MaximumSize = new Size(336, 133);
            MinimumSize = new Size(336, 133);
            Name = "SifremiUnuttum";
            Text = "SifremiUnuttum";
            Load += SifremiUnuttum_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSifreniz;
        private Label lblSfrGoster;
    }
}