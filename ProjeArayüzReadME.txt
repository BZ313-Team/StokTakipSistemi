uygulama arka plan beyaz: FFFFFF
arayüz renk paleti
-------------------
açık gri arkaplan: F8F8FA

açık gri ve beyaz kısımları ayırmak için kenar çizgisi: EAEAEA

seçilmeyen yazıların rengi: 80818B

seçilen yazıların rengi : 1D212E

mavi buton rengi: 005EFC

köşe yuvarlama: 5-5

form boyutu: 350;500

panel boyutu: 250;40

buton boyutu: 125;40

-----------------------------------------------
***** Giris isimlendirme *****

pBoxLoginAna
pBoxKadi
pBoxSifre                         
pnlKAdi
pnlSifre
txtBoxKAdi
txtBoxSifre
btnSifremiUnuttum
btnLogin
arkaPlanAcikGri 
------------------------------------------------------------------------------------------------------------------------------------------

tabePage Sayfalar ------>   tabPageSatis
                  ------>   tabPageUrun
                  ------>   tabPageStok
                  ------>   tabPageGecmis
                  ------>   tabPageIstatistik
------------------------------------------------------------------------------------------------------------------------------------------

***** Sol taraftaki buton isimlendirmesi *****

btnSatis
btnUrun
btnStok
btnGecmis
btnIstatistik
------------------------------------------------------------------------------------------------------------------------------------------

***** panellerin isimlendirilmesi *****

panelButtons            --------->giriş ekranındaki sol buttonları içine attığımız panel buttonlar layout ile bağlı (genel çerçevesi)
tLayoutPButtonSayfa     --------->ana ekranın ikiye bölen solda butonları olup sağda sayfaları olan çerçeve (genel çerçevesi)
tLayoutPSatisEkrani     --------->dataGViewSatisEkrani ve altındaki bilgilerin (genel çerçevesi)
tLayoutPButtons         --------->panelin içine koyduğumuz layoutPanel buttonları tutuyor(5 adet butonu)
tLayoutPSatisSayfa      --------->satış sayfasının içine koyduğumuz layout (genel çerçevesi)
tLayoutPSatisSayfaSol   --------->yukarsında hesap makinesi ve altında boş alan bulunduran layout (genel çerçevesi)
tLayoutPTutar           --------->label textbox label şeklinde bilgi bulunduran layout (genel çerçevesi)
tLayoutPBileme          --------->label textbox label şeklinde bilgi bulunduran layout (genel çerçevesi)
tLayoutPIndirimTL       --------->label textbox label şeklinde bilgi bulunduran layout (genel çerçevesi)
tLayoutPTIndirimYuzde   --------->label textbox label şeklinde bilgi bulunduran layout (genel çerçevesi)
tLayoutPToplamTutar     --------->label textbox label şeklinde bilgi bulunduran layout (genel çerçevesi)
tLayoutPHesapMakinesi   --------->yukarsında hesap makinesi bulunduran layout (genel çerçevesi)
tLayoutPIstPasta        --------->istatistik ekranında üst tarafta label alt tarafında chart olarak ikiye bölen çerçeve
tLayoutPIstUst          --------->istatistik ekranında üst kısmı filtreleme ve başlık yazıyor 
tLayoutPChartButto      --------->istatistik ekranında alt taraftaki chart ve buttonun ayrıldığı (çerçeve)
tLayoutKarZarar         --------->ikinci istatistik ekranı çerçevesi Panelin (P) si yok
tLayoutKarZararGraf     --------->ikinci istatistik ekranı chartının olduğu ve sağ taraftaki yazılar ile ayrılan kısmın çerçevesi
tLayoutKarZararUst      --------->ikinci istatistik ekranın üst kısmı filtreleme ve başlık yazıyor
tLayoutPUrunSayfa       --------->ürünler sayfasını 2 ye bölen en dış çerçeve
tLayoutPUrunlerUst      --------->ürünler sayfasının üstteki buttonlarla yazıları ayıran yer
tLayoutPUrunBilgi       --------->ürünlerin bilgisini girdiği yerin çerçevesi
tLayoutP5Button         --------->ürün sayfasındaki 5 butonun olduğu çerçeve
taLayoutPUrunlerAlt     --------->veritabanı ve arama(filtreleme yeri) diye 2 ye ayıran yer
pnlUrunArama            --------->ürün arama yazan label için panel yazıyı istediğimiz yere getirmek için
tLayoutPUrunSArama      --------->ürünler sayfasında arama yapılacak yeri ikiye bölüp sağ tarafına combobox konulmuş kısım
tLayoutPStok            --------->stok ekranı arama yeri ve veritabanı ayıran yer
tLayoutPStokUst         --------->stok sayfasında arama yapılacak yeri ikiye bölüp sağ tarafına combobox konulmuş kısım
tLayoutPGecmis          --------->geçmiş sayfasını 2 ye bölen en dış çerçeve
tLayoutPGecmisUst       --------->geçmiş sayfasında arama yapılacak yeri ikiye bölüp sağ tarafına combobox konulmuş kısım



pnlSatisBtn            --------->table layoutların içine panel koyup sol tarafına resim konuldu
pnlUrunlerBtn          --------->table layoutların içine panel koyup sol tarafına resim konuldu
pnlStokBtn             --------->table layoutların içine panel koyup sol tarafına resim konuldu
pnlGecmisBtn           --------->table layoutların içine panel koyup sol tarafına resim konuldu
pnlIstatistikBtn       --------->table layoutların içine panel koyup sol tarafına resim konuldu

------------------------------------------------------------------------------------------------------------------------------------------

***** satış sayfası isimlendirme *****


***** satış sayfası sağ taraf *****

dataGViewSatisEkrani

lblTutar
lblBileme
lblIndirimTL
lblIndirimYuzde
lblToplamTutar

txtBoxTutar
txtBoxBileme
txtBoxIndirimTL
txtBoxIndirimYuzde
txtBoxToplamTutar

lblTutarTL           tutarın sağındaki tl yazısı
lblBilemeTL          tutarın sağındaki tl yazısı    
lblIndırımTLL        tutarın sağındaki tl yazısı    
lblToplamTutarTL     tutarın sağındaki tl yazısı    
    

btnSatisYap

***** satış sayfası sol taraf *****

button00
btn0
btn1
btn2
btn3
btn4
btn5
btn6
btn7
btn8
btn9
btnCikarma
btnToplama
btnBolme
btnCarpma
btnEsittir
btnNokta
btnAC
btnDEL
------------------------------------------------------------------------------------------------------------------------------------------

***** istatistik ekranı isimlendirme *****

lblUrunBazindaYuzdeliSatis
cmbBoxIstSFiltre
chartSatis
btnIleri

***** istatistik 2. ekran *****

lblUrunBazindaKarZarar
chartKarZarar
cmbBoxIstSFiltre
lblCiro
txtBoxCiro
lblKar
txtBoxKar
pnlIstatistikSag
btnGeri


------------------------------------------------------------------------------------------------------------------------------------------

***** ürünler ekranı isimlendirme *****

lblUrunBarkodu
lblUrunAdi
lblGenelK
lblUrunK
lblFirmaAdi
lblUrunTipi
lblUrunModel
lblBoyut
lblMensei
lblAlisF
lblSatisF
lblStok
lblMarka
lblGelisT

txtBoxUBarkodu
txtBoxUAdi
cmbBoxGenelK
cmbBoxUrunK
cmbBoxFirmaAdi
cmbBoxUrunTipi
cmbBoxUrunModeli
cmbBoxBoyut
cmbBoxMensei
cmbBoxAlisFiyati
cmbBoxSatisFiyatitxtBoxStok
txtBoxMarka
mtxtBoxGTarihi

btnUrunEkle
btnUrunGuncelle
btnZamEkle
btnTemizle
btnUrunSil

dataGViewUrunEkrani

lblUrunAra
cmbBoxUrunSFiltre
------------------------------------------------------------------------------------------------------------------------------------------

***** stok sayfası isimlendirme *****

lblStokAra
cmbBoxStokSFiltre


------------------------------------------------------------------------------------------------------------------------------------------

***** stok sayfası isimlendirme *****

lblStokAra
cmbBoxStokSFiltre

dataGViewStok
------------------------------------------------------------------------------------------------------------------------------------------

***** geçmiş sayfası isimlendirme *****

lblGecmisAra
cmbBoxGecmisSFiltre

dataGViewGecmis
------------------------------------------------------------------------------------------------------------------------------------------

***** zam ekranı isimlendirme *****

lblGenelKategori 
lblUrunKategori 
lblFirmaAdi 
lblUrunTipi 
lblUrunModeli 
lblUrunBoyutu
lblUrunMarkasi
lblZamYap
lblEskiFiyat
lblZam
lblYeniFiyat
btnEkle

------------------------------------------------------------------------------------------------------------------------------------------


                                            
 
                     