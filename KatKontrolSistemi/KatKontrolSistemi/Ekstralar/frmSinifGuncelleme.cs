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
    public partial class frmSinifGuncelleme : DevExpress.XtraEditors.XtraForm
    {
        string GelenSinifId;
        Ekstralar.EkstralarDb EIslemler = new EkstralarDb();
        Dosyalar.Mesajlar Mesajlar = new Dosyalar.Mesajlar();
        public frmSinifGuncelleme()
        {
            InitializeComponent();
        }

        private void frmSinifGuncelleme_Load(object sender, EventArgs e)
        {
            GelenSinifId = EIslemler.SinifIdAl(txtSinifAdi.Text);
            txtKisiSayisi.Text = EIslemler.KisiSayisiAl(GelenSinifId);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                EIslemler.Guncelle(GelenSinifId, txtSinifAdi.Text, txtKisiSayisi.Text);
                Mesajlar.GuncelleMesaji();
                this.Close();
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
    }
}