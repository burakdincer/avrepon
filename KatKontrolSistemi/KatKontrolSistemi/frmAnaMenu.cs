using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace KatKontrolSistemi
{
    public partial class frmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string GelenBolumId;
        Dosyalar.Ekranlar Ekranlar = new Dosyalar.Ekranlar();
        public frmAnaMenu()
        {
            InitializeComponent();
        }

        private void frmAnaMenu_Load(object sender, EventArgs e)
        {
            Ekranlar.frmBirinciKatAc();
            Ekranlar.frmIkinciKatAc();
            Ekranlar.frmUcuncuKatAc();
            Ekranlar.frmDorduncuKatAc();
            Ekranlar.frmBesinciKatAc();
            Ekranlar.frmAltinciKatAc();
            Ekranlar.frmYedinciKatAc();
        }
    }
}