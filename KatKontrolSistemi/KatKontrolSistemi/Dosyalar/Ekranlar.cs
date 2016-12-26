using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatKontrolSistemi.Dosyalar
{
    class Ekranlar
    {
        public string frmBolumListesiAc()
        {
            BolumIslemleri.frmBolumListesi frm = new BolumIslemleri.frmBolumListesi();
            frm.ShowDialog();
            return frmAnaMenu.GelenBolumId;
        }
        public void frmBirinciKatAc()
        {
            BirinciKat.frmBirinciKat frm = new BirinciKat.frmBirinciKat();
            frm.MdiParent = frmAnaMenu.ActiveForm;
            frm.Show();
        }
        public void frmIkinciKatAc()
        {
            IkinciKat.frmIkinciKat frm = new IkinciKat.frmIkinciKat();
            frm.MdiParent = frmAnaMenu.ActiveForm;
            frm.Show();
        }
        public void frmUcuncuKatAc()
        {
            UcüncüKat.frmUcüncüKat frm = new UcüncüKat.frmUcüncüKat();
            frm.MdiParent = frmAnaMenu.ActiveForm;
            frm.Show();
        }
        public void frmDorduncuKatAc()
        {
            DördüncüKat.frmDördüncüKat frm = new DördüncüKat.frmDördüncüKat();
            frm.MdiParent = frmAnaMenu.ActiveForm;
            frm.Show();
        }
        public void frmBesinciKatAc()
        {
            BesinciKat.frmBesinciKat frm = new BesinciKat.frmBesinciKat();
            frm.MdiParent = frmAnaMenu.ActiveForm;
            frm.Show();
        }
        public void frmAltinciKatAc()
        {
            AltinciKat.frmAltinciKat frm = new AltinciKat.frmAltinciKat();
            frm.MdiParent = frmAnaMenu.ActiveForm;
            frm.Show();
        }
        public void frmYedinciKatAc()
        {
            YedinciKat.frmYedinciKat frm =new YedinciKat.frmYedinciKat();
            frm.MdiParent=frmAnaMenu.ActiveForm;
            frm.Show();
        }
    }
}
