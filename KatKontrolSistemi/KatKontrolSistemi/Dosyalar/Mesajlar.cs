using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KatKontrolSistemi.Dosyalar
{
    class Mesajlar
    {
        public void EkleMesajı()
        {
            MessageBox.Show("Kayıt Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public Boolean Sor(string Mesaj)
        {
            DialogResult Sor = new DialogResult();
            Sor = MessageBox.Show(Mesaj, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Sor == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        public void GuncelleMesaji()
        {
            MessageBox.Show("Kayıt Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void HataMesajı()
        {
            MessageBox.Show("Hata Oluştu!Yöneticinize Başvurunuz");
        }
    }
}
