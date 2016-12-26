using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace KatKontrolSistemi.Ekstralar
{
    class EkstralarDb
    {
        Dosyalar.VeriTabani Dbase = new Dosyalar.VeriTabani();
        //Sınıf İşlemleri Giriş
        public string SinifIdAl(string SinifAdi)
        {
            return Dbase.SatirCek("SELECT * FROM SinifTanitimKarti WHERE SinifAdi='" + SinifAdi +"'")["SiraNumarasi"].ToString();
        }
        public string KisiSayisiAl(string SiraNumarasi)
        {
            return Dbase.SatirCek("SELECT * FROM SinifTanitimKarti WHERE SiraNumarasi='" + SiraNumarasi + "'")["KisiSayisi"].ToString();
        }
        public void Guncelle(string SiraNumarasi, string SinifAdi, string KisiSayisi)
        {
            string sql = "UPDATE SinifTanitimKarti SET SinifAdi='"+SinifAdi+"',KisiSayisi='"+KisiSayisi+"' WHERE SiraNumarasi='"+SiraNumarasi+"'";
            Dbase.Isle(sql);
        }
        //Sınıf İşlemleri Bitiş

        //Oda İşlemleri Giriş
        public void PersonelEkle(string KatId,string PanelId, string OdaId, string Adi, string Soyadi, string Durum,string BolumId)
        {
            string sql = "INSERT INTO PersonelTanitimKarti(KatId,PanelId,OdaId,Adi,Soyadi,Durum,BolumId) VALUES ('"+KatId+"','"+PanelId+"','"+OdaId+"','"+Adi+"','"+Soyadi+"','"+Durum+"','"+BolumId+"')";
            Dbase.Isle(sql);
        }
        public void PersonelGuncelle(string SiraNumarasi,string KatId,string PanelId, string OdaId, string Adi, string Soyadi, string Durum,string BolumId)
        {
            string sql = "UPDATE PersonelTanitimKarti SET KatId='"+KatId+"',PanelId='"+PanelId+"',OdaId='"+OdaId+"',Adi='"+Adi+"',Soyadi='"+Soyadi+"',Durum='"+Durum+"',BolumId='"+BolumId+"' WHERE SiraNumarasi='"+SiraNumarasi+"'";
            Dbase.Isle(sql);
        }
        public void PersonelSil(string SiraNumarasi)
        {
            string sql = "DELETE FROM PersonelTanitimKarti WHERE SiraNumarasi='"+SiraNumarasi+"'";
            Dbase.Isle(sql);
        }
        public DataTable PersonelListesi(string KatId,string PanelId,string OdaId)
        {
            string sql = "SELECT * FROM PersonelTanitimKarti WHERE KatId='"+KatId+"' AND PanelId='"+PanelId+"' AND OdaId='"+OdaId+"'";
            DataTable Tablo = Dbase.TabloCek(sql);
            return Tablo;
        }
        //Oda İşlemleri Çıkış
    }
}
