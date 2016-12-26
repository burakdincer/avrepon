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

namespace KatKontrolSistemi.IkinciKat
{
    public partial class frmIkinciKat : DevExpress.XtraEditors.XtraForm
    {
        IkinciKat.IkinciKatDb IkinciKDb = new IkinciKatDb();
        public string KatId = "2";
        public string Panel1 = "1";
        public string Panel2 = "2";
        public string Panel3 = "3";
        public string Panel4 = "4";
        public string Panel5 = "5";
        public string Panel6 = "6";
        public string Panel7 = "7";
        public frmIkinciKat()
        {
            InitializeComponent();
        }

        private void frmIkinciKat_Load(object sender, EventArgs e)
        {
            Panel5Oda1Listesi();
            Panel6Oda1Listesi();
            Panel7Oda1Listesi();
            Panel7Oda2Listesi();
            Panel7Oda3Listesi();
            PanelIslemleri();
        }
        void PanelIslemleri()
        {
            lblPanel1SinifAdi.Text =IkinciKDb.Panel1SinifAdi(KatId, Panel1);
            lblPanel1KisiSayisi.Text =IkinciKDb.Panel1KisiSayisi(KatId, Panel1) + " Oturak";
            lblPanel2SinifAdi.Text =IkinciKDb.Panel2SinifAdi(KatId, Panel2);
            lblPanel2KisiSayisi.Text =IkinciKDb.Panel2KisiSayisi(KatId, Panel2) + " Oturak";
            lblPanel3SinifAdi.Text =IkinciKDb.Panel3SinifAdi(KatId, Panel3);
            lblPanel3KisiSayisi.Text =IkinciKDb.Panel3KisiSayisi(KatId, Panel3) + " Oturak";
            lblPanel4SinifAdi.Text =IkinciKDb.Panel4SinifAdi(KatId, Panel4);
            lblPanel4KisiSayisi.Text =IkinciKDb.Panel4KisiSayisi(KatId, Panel4) + " Oturak";
        }
        void Panel5Oda1Listesi()
        {
            Panel5Oda1GridListesi.DataSource =IkinciKDb.Panel5Oda1Listesi();
        }
        void Panel6Oda1Listesi()
        {
            Panel6Oda1GridListesi.DataSource = IkinciKDb.Panel6Oda1Listesi();
        }
        void Panel7Oda1Listesi()
        {
            Panel7Oda1GridListesi.DataSource =IkinciKDb.Panel7Oda1Listesi();
        }
        void Panel7Oda2Listesi()
        {
            Panel7Oda2GridListesi.DataSource =IkinciKDb.Panel7Oda2Listesi();
        }
        void Panel7Oda3Listesi()
        {
            Panel7Oda3GridListesi.DataSource =IkinciKDb.Panel7Oda3Listesi();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Ekstralar.frmSinifGuncelleme frm = new Ekstralar.frmSinifGuncelleme();
            try
            {
                frm.txtSinifAdi.Text = lblPanel1SinifAdi.Text;
                frm.ShowDialog();
                PanelIslemleri();
            }
            catch (Exception)
            {
                frm.txtSinifAdi.Text = "-1";
            } 
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            Ekstralar.frmSinifGuncelleme frm = new Ekstralar.frmSinifGuncelleme();
            try
            {
                frm.txtSinifAdi.Text = lblPanel2SinifAdi.Text;
                frm.ShowDialog();
                PanelIslemleri();
            }
            catch (Exception)
            {
                frm.txtSinifAdi.Text = "-1";
            } 
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            Ekstralar.frmSinifGuncelleme frm = new Ekstralar.frmSinifGuncelleme();
            try
            {
                frm.txtSinifAdi.Text = lblPanel3SinifAdi.Text;
                frm.ShowDialog();
                PanelIslemleri();
            }
            catch (Exception)
            {
                frm.txtSinifAdi.Text = "-1";
            } 
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            Ekstralar.frmSinifGuncelleme frm = new Ekstralar.frmSinifGuncelleme();
            try
            {
                frm.txtSinifAdi.Text = lblPanel4SinifAdi.Text;
                frm.ShowDialog();
                PanelIslemleri();
            }
            catch (Exception)
            {
                frm.txtSinifAdi.Text = "-1";
            } 
        }

        private void Panel5Oda1GridListesi_DoubleClick(object sender, EventArgs e)
        {
            Ekstralar.frmPersonelKarti frm = new Ekstralar.frmPersonelKarti();
            try
            {
                frm.GelenKatId = "2";
                frm.GelenPanelId = "5";
                frm.GelenOdaId = "1";
                frm.ShowDialog();
                Panel5Oda1Listesi();
            }
            catch (Exception)
            {

            }   
        }

        private void Panel6Oda1GridListesi_DoubleClick(object sender, EventArgs e)
        {
            Ekstralar.frmPersonelKarti frm = new Ekstralar.frmPersonelKarti();
            try
            {
                frm.GelenKatId = "2";
                frm.GelenPanelId = "6";
                frm.GelenOdaId = "1";
                frm.ShowDialog();
                Panel6Oda1Listesi();
            }
            catch (Exception)
            {

            }
        }

        private void Panel7Oda1GridListesi_DoubleClick(object sender, EventArgs e)
        {
            Ekstralar.frmPersonelKarti frm = new Ekstralar.frmPersonelKarti();
            try
            {
                frm.GelenKatId = "2";
                frm.GelenPanelId = "7";
                frm.GelenOdaId = "1";
                frm.ShowDialog();
                Panel7Oda1Listesi();
            }
            catch (Exception)
            {

            }
        }
        private void Panel7Oda2GridListesi_DoubleClick(object sender, EventArgs e)
        {
            Ekstralar.frmPersonelKarti frm = new Ekstralar.frmPersonelKarti();
            try
            {
                frm.GelenKatId = "2";
                frm.GelenPanelId = "7";
                frm.GelenOdaId = "2";
                frm.ShowDialog();
                Panel7Oda2Listesi();
            }
            catch (Exception)
            {

            }
        }

        private void Panel7Oda3GridListesi_DoubleClick(object sender, EventArgs e)
        {
            Ekstralar.frmPersonelKarti frm = new Ekstralar.frmPersonelKarti();
            try
            {
                frm.GelenKatId = "2";
                frm.GelenPanelId = "7";
                frm.GelenOdaId = "3";
                frm.ShowDialog();
                Panel7Oda3Listesi();
            }
            catch (Exception)
            {

            }  
        }
    }
}