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

            txtboxkAdi.Text = "Kullanıcı Adı";
            txtboxSifre.Text = "Şifre";
            txtboxkAdi.ForeColor = ColorTranslator.FromHtml(secilmemisYaziRengi);
            txtboxSifre.ForeColor = ColorTranslator.FromHtml(secilmemisYaziRengi);

            //textboxkAdi focus olayı
            txtboxkAdi.GotFocus += (s, e) =>
            {
                if (txtboxkAdi.Text == "Kullanıcı Adı")
                {
                    txtboxkAdi.Text = "";
                    txtboxkAdi.ForeColor = ColorTranslator.FromHtml(secilmisYaziRengi);
                }
            };

            // TextBoxSifre Focus Olayı
            txtboxSifre.GotFocus += (s, e) =>
            {
                if (txtboxSifre.Text == "Şifre")
                {
                    txtboxSifre.Text = "";
                    txtboxSifre.ForeColor = ColorTranslator.FromHtml(secilmisYaziRengi);
                    txtboxSifre.UseSystemPasswordChar = true; // Şifreyi gizle
                }
            };

            // TextBoxkAdi Leave (Kaybetme) Olayı
            txtboxkAdi.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtboxkAdi.Text))
                {
                    txtboxkAdi.Text = "Kullanıcı Adı";
                    txtboxkAdi.ForeColor = ColorTranslator.FromHtml(secilmemisYaziRengi);

                }
            };

            // TextBoxSifre Leave (Kaybetme) Olayı
            txtboxSifre.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtboxSifre.Text))
                {
                    txtboxSifre.Text = "Şifre";
                    txtboxSifre.ForeColor = ColorTranslator.FromHtml(secilmemisYaziRengi);
                    txtboxSifre.UseSystemPasswordChar = false; // Gizlemeyi kaldır
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
                btnSifremiUnuttum.Font = new Font(pfc.Families[0],8,FontStyle.Regular);

                txtboxkAdi.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);
                txtboxSifre.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);

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
    }

}