using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipSistemi
{
    public partial class Istatistik2 : Form
    {
        public Istatistik2()
        {
            InitializeComponent();
        }

        private void Istatistik2_Load(object sender, EventArgs e)
        {
            int xPosition = 425; // Yatay (X) pozisyonu
            int yPosition = 50;  // Dikey (Y) pozisyonu

            // Formun başlangıç pozisyonunu elle ayarlayın
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(xPosition, yPosition);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
               
            this.Hide();
        }
    }
}
