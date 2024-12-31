using Microsoft.Identity.Client;
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
    public partial class SatisTamamla : Form
    {
        UrunIslemleri urunIslemleri = new UrunIslemleri();
        SQLIslemleri sqlIslemleri = new SQLIslemleri();
        ListView satisEkraniListView;
        TextBox satisEkraniTutar, satisEkraniToplamTutar, textBoxBarkodGorunmez;
        float toplamTutar = 0;
        public SatisTamamla()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        public void verileriYukle(string toplamTutar, ListView listViewSatisEkrani, TextBox SatisEkraniTutar, TextBox SatisEkraniToplamTutar,
            TextBox TextBoxBarkodGorunmez)
        {
            SatisTamamlaIndirimliTutarTextBox.Text = (float.Parse(SatisEkraniToplamTutar.Text) - int.Parse(SatisTamamlaIndirimTextBox.Text)).ToString();
            satisEkraniListView = listViewSatisEkrani;
            satisEkraniTutar = SatisEkraniTutar;
            satisEkraniToplamTutar = SatisEkraniToplamTutar;
            textBoxBarkodGorunmez = TextBoxBarkodGorunmez;
            urunIslemleri.tutarVeToplamTutariSatisTamamlayaAktar(toplamTutar, SatisTamamlaToplamTutarTextBox);
        }

        public void satisEkraniVerileriniVeritabaninaAktar()
        {
            string baglanti = sqlIslemleri.GetBaglanti();
            string indirimTur = "İndirim Türü";
            toplamTutar = float.Parse(SatisTamamlaIndirimliTutarTextBox.Text);
            urunIslemleri.satisTamamlaVerileriAktar(satisEkraniListView, indirimTur, baglanti, toplamTutar);


        }

        private void SatisTamamlaIndirimTextBox_TextChanged(object sender, EventArgs e)
        {
            float toplamTutar = float.Parse(SatisTamamlaToplamTutarTextBox.Text);
            float indirimTutar = 0;
            if (!string.IsNullOrEmpty(SatisTamamlaIndirimTextBox.Text))
                indirimTutar = float.Parse(SatisTamamlaIndirimTextBox.Text);


            SatisTamamlaIndirimliTutarTextBox.Text = (toplamTutar - indirimTutar).ToString();
        }

        private void SatisEkraniVeriTemizle()
        {
            urunIslemleri.satisEkraniVeriTemizle(satisEkraniTutar, satisEkraniToplamTutar, textBoxBarkodGorunmez, satisEkraniListView);
        }

        private void SatisTamamlaSatisiTamamlaButon_Click(object sender, EventArgs e)
        {

            satisEkraniVerileriniVeritabaninaAktar();
            SatisEkraniVeriTemizle();
            toplamTutar = 0;
            this.Close();
        }

        private void SatisTamamlaSatisiIptalEtButon_Click(object sender, EventArgs e)
        {
            SatisEkraniVeriTemizle();
            toplamTutar = 0;

        }
    }
}
