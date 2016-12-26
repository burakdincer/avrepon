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

namespace KatKontrolSistemi.BolumIslemleri
{
    public partial class frmBolumListesi : DevExpress.XtraEditors.XtraForm
    {
        BolumIslemleri.BolumDb BIslemler = new BolumDb();
        string SecilenBolumId;
        public frmBolumListesi()
        {
            InitializeComponent();
        }

        private void frmBolumListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            liste.DataSource = BIslemler.BolumListesi();
        }
        void Sec()
        {
            try
            {
                SecilenBolumId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SiraNumarasi").ToString();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            frmAnaMenu.GelenBolumId = SecilenBolumId;
            this.Dispose();
        }
    }
}