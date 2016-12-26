using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatKontrolSistemi.YedinciKat
{
    class YedinciKatDb
    {
        Dosyalar.VeriTabani Dbase = new Dosyalar.VeriTabani();
        public string Panel1SinifAdi(string KatId, string PanelId)
        {
            return Dbase.SatirCek("SELECT * FROM SinifTanitimKarti WHERE KatId='" + KatId + "' AND PanelId='" + PanelId + "'")["SinifAdi"].ToString();
        }
        public string Panel1KisiSayisi(string KatId, string PanelId)
        {
            return Dbase.SatirCek("SELECT * FROM SinifTanitimKarti WHERE KatId='" + KatId + "' AND PanelId='" + PanelId + "'")["KisiSayisi"].ToString();
        }
    }
}
