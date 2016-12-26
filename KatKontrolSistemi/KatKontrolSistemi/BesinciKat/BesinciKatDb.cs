using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace KatKontrolSistemi.BesinciKat
{
    class BesinciKatDb
    {
        Dosyalar.VeriTabani Dbase = new Dosyalar.VeriTabani();
        //Sınıf İşlemleri Giriş
        public string Panel1SinifAdi(string KatId, string PanelId)
        {
            return Dbase.SatirCek("SELECT * FROM SinifTanitimKarti WHERE KatId='" + KatId + "' AND PanelId='" + PanelId + "'")["SinifAdi"].ToString();
        }
        public string Panel1KisiSayisi(string KatId, string PanelId)
        {
            return Dbase.SatirCek("SELECT * FROM SinifTanitimKarti WHERE KatId='" + KatId + "' AND PanelId='" + PanelId + "'")["KisiSayisi"].ToString();
        }
        public string Panel2SinifAdi(string KatId, string PanelId)
        {
            return Dbase.SatirCek("SELECT * FROM SinifTanitimKarti WHERE KatId='" + KatId + "' AND PanelId='" + PanelId + "'")["SinifAdi"].ToString();
        }
        public string Panel2KisiSayisi(string KatId, string PanelId)
        {
            return Dbase.SatirCek("SELECT * FROM SinifTanitimKarti WHERE KatId='" + KatId + "' AND PanelId='" + PanelId + "'")["KisiSayisi"].ToString();
        }
        public string Panel3SinifAdi(string KatId, string PanelId)
        {
            return Dbase.SatirCek("SELECT * FROM SinifTanitimKarti WHERE KatId='" + KatId + "' AND PanelId='" + PanelId + "'")["SinifAdi"].ToString();
        }
        public string Panel3KisiSayisi(string KatId, string PanelId)
        {
            return Dbase.SatirCek("SELECT * FROM SinifTanitimKarti WHERE KatId='" + KatId + "' AND PanelId='" + PanelId + "'")["KisiSayisi"].ToString();
        }
        public string Panel4SinifAdi(string KatId, string PanelId)
        {
            return Dbase.SatirCek("SELECT * FROM SinifTanitimKarti WHERE KatId='" + KatId + "' AND PanelId='" + PanelId + "'")["SinifAdi"].ToString();
        }
        public string Panel4KisiSayisi(string KatId, string PanelId)
        {
            return Dbase.SatirCek("SELECT * FROM SinifTanitimKarti WHERE KatId='" + KatId + "' AND PanelId='" + PanelId + "'")["KisiSayisi"].ToString();
        }
        //Sınıf İşlemleri Bitiş
        //--------------------//
        //Oda İşlemleri Giriş
        public DataTable Panel5Oda1KisiListesi()
        {
            string sql = "SELECT * FROM PersonelTanitimKarti WHERE KatId='5' AND PanelId='5' AND OdaId='1'";
            DataTable Tablo = Dbase.TabloCek(sql);
            return Tablo;
        }
        public DataTable Panel6Oda1KisiListesi()
        {
            string sql = "SELECT * FROM PersonelTanitimKarti WHERE KatId='5' AND PanelId='6' AND OdaId='1'";
            DataTable Tablo = Dbase.TabloCek(sql);
            return Tablo;
        }
        public DataTable Panel6Oda2KisiListesi()
        {
            string sql = "SELECT * FROM PersonelTanitimKarti WHERE KatId='5' AND PanelId='6' AND OdaId='2'";
            DataTable Tablo = Dbase.TabloCek(sql);
            return Tablo;
        }
        public DataTable Panel6Oda3KisiListesi()
        {
            string sql = "SELECT * FROM PersonelTanitimKarti WHERE KatId='5' AND PanelId='6' AND OdaId='3'";
            DataTable Tablo = Dbase.TabloCek(sql);
            return Tablo;
        }
    }
}
