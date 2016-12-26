using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace KatKontrolSistemi.BirinciKat
{
    class BirinciKatDb
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
        public string Panel5SinifAdi(string KatId, string PanelId)
        {
            return Dbase.SatirCek("SELECT * FROM SinifTanitimKarti WHERE KatId='" + KatId + "' AND PanelId='" + PanelId + "'")["SinifAdi"].ToString();
        }
        public string Panel5KisiSayisi(string KatId, string PanelId)
        {
            return Dbase.SatirCek("SELECT * FROM SinifTanitimKarti WHERE KatId='" + KatId + "' AND PanelId='" + PanelId + "'")["KisiSayisi"].ToString();
        }
        public string Panel6SinifAdi(string KatId, string PanelId)
        {
            return Dbase.SatirCek("SELECT * FROM SinifTanitimKarti WHERE KatId='" + KatId + "' AND PanelId='" + PanelId + "'")["SinifAdi"].ToString();
        }
        public string Panel6KisiSayisi(string KatId, string PanelId)
        {
            return Dbase.SatirCek("SELECT * FROM SinifTanitimKarti WHERE KatId='" + KatId + "' AND PanelId='" + PanelId + "'")["KisiSayisi"].ToString();
        }
        //Sınıf İşlemleri Bitiş
        //--------------------//
        //Oda İşlemleri Giriş
        public DataTable Panel7Oda1KisiListesi()
        {
            string sql = "SELECT * FROM PersonelTanitimKarti WHERE KatId='1' AND PanelId='7' AND OdaId='1'";
            DataTable Tablo = Dbase.TabloCek(sql);
            return Tablo;
        }
        public DataTable Panel8Oda1KisiListesi()
        {
            string sql = "SELECT * FROM PersonelTanitimKarti WHERE KatId='1' AND PanelId='8' AND OdaId='1'";
            DataTable Tablo = Dbase.TabloCek(sql);
            return Tablo;
        }
        public DataTable Panel8Oda2KisiListesi()
        {
            string sql = "SELECT * FROM PersonelTanitimKarti WHERE KatId='1' AND PanelId='8' AND OdaId='2'";
            DataTable Tablo = Dbase.TabloCek(sql);
            return Tablo;
        }
        public DataTable Panel8Oda3KisiListesi()
        {
            string sql = "SELECT * FROM PersonelTanitimKarti WHERE KatId='1' AND PanelId='8' AND OdaId='3'";
            DataTable Tablo = Dbase.TabloCek(sql);
            return Tablo;
        }
    }
}
