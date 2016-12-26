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

namespace KatKontrolSistemi.BirinciKat
{
    public partial class frmBirinciKat : DevExpress.XtraEditors.XtraForm
    {
        public string KatId = "1";
        public string Panel1 = "1";
        public string Panel2 = "2";
        public string Panel3 = "3";
        public string Panel4 = "4";
        public string Panel5 = "5";
        public string Panel6 = "6";
        BirinciKat.BirinciKatDb BirinciKDb = new BirinciKatDb();
        public frmBirinciKat()
        {
            InitializeComponent();
        }
        private void frmBirinciKat_Load(object sender, EventArgs e)
        {
            Panel7Oda1Listesi();
            Panel8Oda1Listesi();
            Panel8Oda2Listesi();
            Panel8Oda3Listesi();
            PanelIslemleri();
        }
        void PanelIslemleri()
        {
            lblPanel1SinifAdi.Text = BirinciKDb.Panel1SinifAdi(KatId, Panel1);
            lblPanel1KisiSayisi.Text = BirinciKDb.Panel1KisiSayisi(KatId, Panel1)+" Oturak";
            lblPanel2SinifAdi.Text = BirinciKDb.Panel2SinifAdi(KatId, Panel2);
            lblPanel2KisiSayisi.Text = BirinciKDb.Panel2KisiSayisi(KatId, Panel2)+" Oturak";
            lblPanel3SinifAdi.Text = BirinciKDb.Panel3SinifAdi(KatId, Panel3);
            lblPanel3KisiSayisi.Text = BirinciKDb.Panel3KisiSayisi(KatId, Panel3)+" Oturak";
            lblPanel4SinifAdi.Text = BirinciKDb.Panel4SinifAdi(KatId, Panel4);
            lblPanel4KisiSayisi.Text = BirinciKDb.Panel4KisiSayisi(KatId, Panel4)+" Oturak";
            lblPanel5SinifAdi.Text = BirinciKDb.Panel5SinifAdi(KatId, Panel5);
            lblPanel5KisiSayisi.Text = BirinciKDb.Panel5KisiSayisi(KatId, Panel5)+" Oturak";
            lblPanel6SinifAdi.Text = BirinciKDb.Panel6SinifAdi(KatId, Panel6);
            lblPanel6KisiSayisi.Text = BirinciKDb.Panel6KisiSayisi(KatId, Panel6)+" Oturak";
        }
        void Panel7Oda1Listesi()
        {
            Panel7Oda1GridListesi.DataSource = BirinciKDb.Panel7Oda1KisiListesi();
        }
        void Panel8Oda1Listesi()
        {
            Panel8Oda1GridListesi.DataSource = BirinciKDb.Panel8Oda1KisiListesi();
        }
        void Panel8Oda2Listesi()
        {
            Panel8Oda2GridListesi.DataSource = BirinciKDb.Panel8Oda2KisiListesi();
        }
        void Panel8Oda3Listesi()
        {
            Panel8Oda3GridListesi.DataSource = BirinciKDb.Panel8Oda3KisiListesi();
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

        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            Ekstralar.frmSinifGuncelleme frm = new Ekstralar.frmSinifGuncelleme();
            try
            {
                frm.txtSinifAdi.Text = lblPanel5SinifAdi.Text;
                frm.ShowDialog();
                PanelIslemleri();
            }
            catch (Exception)
            {
                frm.txtSinifAdi.Text = "-1"; 
            }
            
        }

        private void pictureBox6_DoubleClick(object sender, EventArgs e)
        {
            Ekstralar.frmSinifGuncelleme frm = new Ekstralar.frmSinifGuncelleme();
            try
            {
                
                frm.txtSinifAdi.Text = lblPanel6SinifAdi.Text;
                frm.ShowDialog();
                PanelIslemleri();
            }
            catch (Exception)
            {
                frm.txtSinifAdi.Text = "-1"; 
            }
            
        }
        private void Panel7Oda1GridListesi_DoubleClick(object sender, EventArgs e)
        {
            Ekstralar.frmPersonelKarti frm = new Ekstralar.frmPersonelKarti();
            try
            {
                frm.GelenKatId = "1";
                frm.GelenPanelId = "7";
                frm.GelenOdaId = "1";
                frm.ShowDialog();
                Panel7Oda1Listesi();
            }
            catch (Exception)
            {

            }
        }
        private void Panel8Oda1GridListesi_DoubleClick(object sender, EventArgs e)
        {
            Ekstralar.frmPersonelKarti frm = new Ekstralar.frmPersonelKarti();
            try
            {
                frm.GelenKatId = "1";
                frm.GelenPanelId = "8";
                frm.GelenOdaId = "1";
                frm.ShowDialog();
                Panel8Oda1Listesi();
            }
            catch (Exception)
            {

            }
        }

        private void Panel8Oda2GridListesi_DoubleClick(object sender, EventArgs e)
        {
            Ekstralar.frmPersonelKarti frm = new Ekstralar.frmPersonelKarti();
            try
            {
                frm.GelenKatId = "1";
                frm.GelenPanelId = "8";
                frm.GelenOdaId = "2";
                frm.ShowDialog();
                Panel8Oda2Listesi();
            }
            catch (Exception)
            {

            }
        }
    }
}