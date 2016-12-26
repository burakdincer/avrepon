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

namespace KatKontrolSistemi.YedinciKat
{
    public partial class frmYedinciKat : DevExpress.XtraEditors.XtraForm
    {
        YedinciKat.YedinciKatDb YedinciKDb = new YedinciKatDb();
        public string KatId = "7";
        public string Panel1 = "1";
        public frmYedinciKat()
        {
            InitializeComponent();
        }

        private void frmYedinciKat_Load(object sender, EventArgs e)
        {
            PanelIslemleri();
        }
        void PanelIslemleri()
        {
            lblPanel1SinifAdi.Text = YedinciKDb.Panel1SinifAdi(KatId, Panel1);
            lblPanel1KisiSayisi.Text = YedinciKDb.Panel1KisiSayisi(KatId, Panel1) + " Oturak";
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
    }
}