using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipSistemi
{
    public partial class Giris : Form
    {

        // Yuvarlatılmış dikdörtgen için gerekli WinAPI fonksiyonu
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public Giris()
        {
            InitializeComponent();

            string arkaPlanBeyaz = "#FFFFFF";
            string arkaPlanAcikGri = "#F8F8FA";
            string kenarCizgisiRengi = "#EAEAEA";
            string secilmemisYaziRengi = "#80818B";
            string secilmisYaziRengi = "#1D212E";
            string btnMavi = "#005EFC";

            txtBoxKAdi.Text = "Kullanıcı Adı";
            txtBoxSifre.Text = "Şifre";
            txtBoxKAdi.ForeColor = ColorTranslator.FromHtml(secilmemisYaziRengi);
            txtBoxSifre.ForeColor = ColorTranslator.FromHtml(secilmemisYaziRengi);


            //textboxkAdi focus olayı
            txtBoxKAdi.GotFocus += (s, e) =>
            {
                if (txtBoxKAdi.Text == "Kullanıcı Adı")
                {
                    txtBoxKAdi.Text = "";
                    txtBoxKAdi.ForeColor = ColorTranslator.FromHtml(secilmisYaziRengi);
                }
            };

            // TextBoxSifre Focus Olayı
            txtBoxSifre.GotFocus += (s, e) =>
            {
                if (txtBoxSifre.Text == "Şifre")
                {
                    txtBoxSifre.Text = "";
                    txtBoxSifre.ForeColor = ColorTranslator.FromHtml(secilmisYaziRengi);
                    txtBoxSifre.UseSystemPasswordChar = true; // Şifreyi gizle
                    txtBoxSifre.PasswordChar = '*';
                }
            };

            // TextBoxkAdi Leave (Kaybetme) Olayı
            txtBoxKAdi.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBoxKAdi.Text))
                {
                    txtBoxKAdi.Text = "Kullanıcı Adı";
                    txtBoxKAdi.ForeColor = ColorTranslator.FromHtml(secilmemisYaziRengi);

                }
            };

            // TextBoxSifre Leave (Kaybetme) Olayı
            txtBoxSifre.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBoxSifre.Text))
                {
                    txtBoxSifre.Text = "Şifre";
                    txtBoxSifre.ForeColor = ColorTranslator.FromHtml(secilmemisYaziRengi);
                    txtBoxSifre.UseSystemPasswordChar = false; // Gizlemeyi kaldır
                }
            };


            /*this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(350, 500);
            this.FormBorderStyle = FormBorderStyle.None;*/

            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(
              0,
              0,
              btnLogin.Width,
              btnLogin.Height,
              5,
              5));

            btnSifremiUnuttum.Region = Region.FromHrgn(CreateRoundRectRgn(
                0,
                0,
                btnSifremiUnuttum.Width,
                btnSifremiUnuttum.Height,
                5,
                5));


            this.BackColor = ColorTranslator.FromHtml(arkaPlanAcikGri);
            btnLogin.BackColor = ColorTranslator.FromHtml(btnMavi);

            CustomPanel pnlkAdi = new CustomPanel
            {
                Size = new Size(250, 40),
                Location = new Point(45, 160),
                BorderColorHtml = "#80818B", // HTML renk kodu
                BorderWidth = 2, // Çerçeve genişliği
                BackColor = Color.White
            };

            //panelin boyutu değişince çerçeve ile birlikte hareket etsin
            pnlkAdi.SizeChanged += (s, e) => pnlkAdi.Invalidate(); //panel yeniden çizilir*/
        }
        // Form'a paneli ekle
        //this.Controls.Add(pnlkAdi);



        private void LoginNew_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            PrivateFontCollection pfc = new PrivateFontCollection();

            // Programın çalıştığı dizine göre yol ayarlama
            string fontFilePath = Path.Combine(Application.StartupPath, @"Resources\Inter-VariableFont_opsz,wght.ttf");

            if (File.Exists(fontFilePath))
            {
                pfc.AddFontFile(fontFilePath);

                btnLogin.Font = new Font(pfc.Families[0], 9, FontStyle.Regular);
                btnSifremiUnuttum.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);

                txtBoxKAdi.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);
                txtBoxSifre.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);

                /* foreach (Control c in this.Controls)
                 {
                     c.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
                 }*/
            }
            else
            {
                MessageBox.Show("Font dosyası bulunamadı. Lütfen font dosyasının doğru yerde olduğundan emin olun.");
            }
        }

        private void LoginNew_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBoxKAdi.Text == "bz313" && txtBoxSifre.Text == "123q")
            {
                Sayfalar sayfalar = new Sayfalar();
                sayfalar.Show();
                this.Hide();
            }
        }

      
    }

}