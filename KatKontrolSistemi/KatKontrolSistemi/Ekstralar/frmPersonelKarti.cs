using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace KatKontrolSistemi.Ekstralar
{
    public partial class frmPersonelKarti : DevExpress.XtraEditors.XtraForm
    {
        string Durum;
        public string GelenKatId;
        public string GelenPanelId;
        public string GelenOdaId;
        public string GelenBolumId;
        string SecilenPersonelId;
        public string SecilenDurum;
        Ekstralar.EkstralarDb EIslemler = new EkstralarDb();
        BolumIslemleri.BolumDb BIslemler = new BolumIslemleri.BolumDb();
        Dosyalar.Ekranlar Ekranlar = new Dosyalar.Ekranlar();
        Dosyalar.Mesajlar Mesajlar = new Dosyalar.Mesajlar();
        public frmPersonelKarti()
        {
            InitializeComponent();
        }
        private void frmPersonelKarti_Load(object sender, EventArgs e)
        {
            PersonelListesi();
        }
        void PersonelListesi()
        {
            liste.DataSource = EIslemler.PersonelListesi(GelenKatId,GelenPanelId, GelenOdaId);
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbDurum.SelectedItem=="Personel")
            {
                Durum = "0";
            }
            if (cmbDurum.SelectedItem=="Asistan")
            {
                Durum = "1";
            }
            EIslemler.PersonelEkle(GelenKatId,GelenPanelId, GelenOdaId, txtAdi.Text, txtSoyadi.Text, Durum,frmAnaMenu.GelenBolumId);
            Mesajlar.EkleMesajı();
            PersonelListesi();
            Temizle();
        }
        void Sec()
        {
            try
            {
                SecilenPersonelId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SiraNumarasi").ToString();
                txtAdi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Adi").ToString();
                txtSoyadi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Soyadi").ToString();
                btnBolumSec.Text =gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BolumId").ToString();
                btnBolumSec.Text=BIslemler.BolumAdiAl(btnBolumSec.Text);
                SecilenDurum = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Durum").ToString();
                if (SecilenDurum == "0")
                {
                    cmbDurum.Text = "Personel";
                }
                if (SecilenDurum == "1")
                {
                    cmbDurum.Text = "Asistan";
                }
            }
            catch (Exception)
            {
                Mesajlar.HataMesajı();
            } 
        }
        void Temizle()
        {
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            btnBolumSec.Text = "";
            cmbDurum.Text = "";
        }
        private void liste_MouseClick(object sender, MouseEventArgs e)
        {
            Sec();
        }
        private void btnBolumSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                btnBolumSec.Text = BIslemler.BolumAdiAl(Ekranlar.frmBolumListesiAc());
            }
            catch (Exception)
            {

            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDurum.SelectedItem == "Personel")
                {
                    Durum = "0";
                }
                if (cmbDurum.SelectedItem == "Asistan")
                {
                    Durum = "1";
                }
                GelenBolumId = BIslemler.BolumIdAl(btnBolumSec.Text);
                EIslemler.PersonelGuncelle(SecilenPersonelId, GelenKatId, GelenPanelId, GelenOdaId, txtAdi.Text, txtSoyadi.Text, Durum, GelenBolumId);
                Mesajlar.GuncelleMesaji();
                PersonelListesi();
                Temizle();
            }
            catch (Exception)
            {
                Mesajlar.HataMesajı();
            }
        }
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void liste_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                SecilenPersonelId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SiraNumarasi").ToString();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (Mesajlar.Sor("Seçilen Kaydı Silmek İstediğinizden Emin Misiniz?") == true)
                {
                    Sec();
                    EIslemler.PersonelSil(SecilenPersonelId);
                    PersonelListesi();
                    Temizle();
                }
            }
            catch (Exception)
            {
                Mesajlar.HataMesajı();
            }
        }
    }
}