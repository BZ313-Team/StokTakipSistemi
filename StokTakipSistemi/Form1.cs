using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing.Text;

namespace StokTakipSistemi
{
    public partial class Form1 : Form
    {
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



        public Form1()
        {
            InitializeComponent();
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(
               0,
               0,
               button1.Width,
               button1.Height,
               20,
               20));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();

            // Proje dizinindeki font dosyas�n�n yolunu al�n
            string fontPath = Path.Combine(Application.StartupPath, "Resources", "Inter-VariableFont_opsz,wght.ttf");

            if (File.Exists(fontPath))
            {
                pfc.AddFontFile(fontPath);

                // Fontu t�m kontrollerde uygula
                foreach (Control c in this.Controls)
                {
                    c.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                }
            }
            else
            {
                MessageBox.Show("Font dosyas� bulunamad�!");
            }
        }

    }
}
