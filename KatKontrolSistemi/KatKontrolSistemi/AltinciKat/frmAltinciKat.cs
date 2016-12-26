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

namespace KatKontrolSistemi.AltinciKat
{
    public partial class frmAltinciKat : DevExpress.XtraEditors.XtraForm
    {
        AltinciKat.AltinciKatDb AltinciKDb = new AltinciKatDb();
        public string KatId = "6";
        public string Panel1 = "1";
        public string Panel2 = "2";
        public string Panel3 = "3";
        public string Panel4 = "4";
        public frmAltinciKat()
        {
            InitializeComponent();
        }

        private void frmAltinciKat_Load(object sender, EventArgs e)
        {
            Panel2Oda1Listesi();
            Panel3Oda1Listesi();
            Panel4Oda1Listesi();
            Panel5Oda1Listesi();
        }
        void Panel2Oda1Listesi()
        {
            Panel2Oda1GridListesi.DataSource = AltinciKDb.Panel2Oda1KisiListesi();
        }
        void Panel3Oda1Listesi()
        {
            Panel3Oda1GridListesi.DataSource = AltinciKDb.Panel3Oda1KisiListesi();
        }
        void Panel4Oda1Listesi()
        {
            Panel4Oda1GridListesi.DataSource = AltinciKDb.Panel4Oda1KisiListesi();
        }
        void Panel5Oda1Listesi()
        {
            Panel5Oda1GridListesi.DataSource = AltinciKDb.Panel5Oda1KisiListesi();
        }

        private void Panel2Oda1GridListesi_DoubleClick(object sender, EventArgs e)
        {
            Ekstralar.frmPersonelKarti frm = new Ekstralar.frmPersonelKarti();
            try
            {
                frm.GelenKatId = "6";
                frm.GelenPanelId = "2";
                frm.GelenOdaId = "1";
                frm.ShowDialog();
                Panel2Oda1Listesi();
            }
            catch (Exception)
            {

            }
        }

        private void Panel3Oda1GridListesi_DoubleClick(object sender, EventArgs e)
        {
            Ekstralar.frmPersonelKarti frm = new Ekstralar.frmPersonelKarti();
            try
            {
                frm.GelenKatId = "6";
                frm.GelenPanelId = "3";
                frm.GelenOdaId = "1";
                frm.ShowDialog();
                Panel3Oda1Listesi();
            }
            catch (Exception)
            {

            }
        }

        private void Panel4Oda1GridListesi_DoubleClick(object sender, EventArgs e)
        {
            Ekstralar.frmPersonelKarti frm = new Ekstralar.frmPersonelKarti();
            try
            {
                frm.GelenKatId = "6";
                frm.GelenPanelId = "4";
                frm.GelenOdaId = "1";
                frm.ShowDialog();
                Panel4Oda1Listesi();
            }
            catch (Exception)
            {

            }
        }

        private void Panel5Oda1GridListesi_DoubleClick(object sender, EventArgs e)
        {
            Ekstralar.frmPersonelKarti frm = new Ekstralar.frmPersonelKarti();
            try
            {
                frm.GelenKatId = "6";
                frm.GelenPanelId = "5";
                frm.GelenOdaId = "1";
                frm.ShowDialog();
                Panel5Oda1Listesi();
            }
            catch (Exception)
            {

            }
        }
    }
}