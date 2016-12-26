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

namespace KatKontrolSistemi.BesinciKat
{
    public partial class frmBesinciKat : DevExpress.XtraEditors.XtraForm
    {
        BesinciKat.BesinciKatDb BesinciKDb = new BesinciKatDb();
        public string KatId = "5";
        public string Panel1 = "1";
        public string Panel2 = "2";
        public string Panel3 = "3";
        public string Panel4 = "4";
        public string Panel5 = "5";
        public string Panel6 = "6";
        public frmBesinciKat()
        {
            InitializeComponent();
        }

        private void frmBesinciKat_Load(object sender, EventArgs e)
        {
            Panel5Oda1Listesi();
            Panel6Oda1Listesi();
            Panel6Oda2Listesi();
            Panel6Oda3Listesi();
            PanelIslemleri();
        }
        void PanelIslemleri()
        {
            lblPanel1SinifAdi.Text = BesinciKDb.Panel1SinifAdi(KatId, Panel1);
            lblPanel1KisiSayisi.Text = BesinciKDb.Panel1KisiSayisi(KatId, Panel1) + " Oturak";
            lblPanel2SinifAdi.Text = BesinciKDb.Panel2SinifAdi(KatId, Panel2);
            lblPanel2KisiSayisi.Text = BesinciKDb.Panel2KisiSayisi(KatId, Panel2) + " Oturak";
            lblPanel3SinifAdi.Text = BesinciKDb.Panel3SinifAdi(KatId, Panel3);
            lblPanel3KisiSayisi.Text = BesinciKDb.Panel3KisiSayisi(KatId, Panel3) + " Oturak";
            lblPanel4SinifAdi.Text = BesinciKDb.Panel4SinifAdi(KatId, Panel4);
            lblPanel4KisiSayisi.Text = BesinciKDb.Panel4KisiSayisi(KatId, Panel4) + " Oturak";
        }
        void Panel5Oda1Listesi()
        {
            Panel5Oda1GridListesi.DataSource = BesinciKDb.Panel5Oda1KisiListesi();
        }
        void Panel6Oda1Listesi()
        {
            Panel6Oda1GridListesi.DataSource = BesinciKDb.Panel6Oda1KisiListesi();
        }
        void Panel6Oda2Listesi()
        {
            Panel6Oda2GridListesi.DataSource = BesinciKDb.Panel6Oda2KisiListesi();
        }
        void Panel6Oda3Listesi()
        {
            Panel6Oda3GridListesi.DataSource = BesinciKDb.Panel6Oda3KisiListesi();
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
                frm.GelenKatId = "5";
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
                frm.GelenKatId = "5";
                frm.GelenPanelId = "6";
                frm.GelenOdaId = "1";
                frm.ShowDialog();
                Panel6Oda1Listesi();
            }
            catch (Exception)
            {

            }
        }

        private void Panel6Oda2GridListesi_DoubleClick(object sender, EventArgs e)
        {
            Ekstralar.frmPersonelKarti frm = new Ekstralar.frmPersonelKarti();
            try
            {
                frm.GelenKatId = "5";
                frm.GelenPanelId = "6";
                frm.GelenOdaId = "2";
                frm.ShowDialog();
                Panel6Oda2Listesi();
            }
            catch (Exception)
            {

            }
        }

        private void Panel6Oda3GridListesi_DoubleClick(object sender, EventArgs e)
        {
            Ekstralar.frmPersonelKarti frm = new Ekstralar.frmPersonelKarti();
            try
            {
                frm.GelenKatId = "5";
                frm.GelenPanelId = "6";
                frm.GelenOdaId = "3";
                frm.ShowDialog();
                Panel6Oda3Listesi();
            }
            catch (Exception)
            {

            }
        }
    }
}