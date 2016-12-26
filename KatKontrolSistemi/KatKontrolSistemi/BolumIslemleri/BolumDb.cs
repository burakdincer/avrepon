using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace KatKontrolSistemi.BolumIslemleri
{
    class BolumDb
    {
        Dosyalar.VeriTabani Dbase = new Dosyalar.VeriTabani();
        public DataTable BolumListesi()
        {
            string sql = "SELECT * FROM BolumTanitimKarti";
            DataTable Tablo = Dbase.TabloCek(sql);
            return Tablo;
        }
        public string BolumAdiAl(string SiraNumarasi)
        {
            return Dbase.SatirCek("SELECT * FROM BolumTanitimKarti WHERE SiraNumarasi='" + SiraNumarasi + "'")["BolumAdi"].ToString();
        }
        public string BolumIdAl(string BolumAdi)
        {
            return Dbase.SatirCek("SELECT * FROM BolumTanitimKarti WHERE BolumAdi='"+BolumAdi+"'")["SiraNumarasi"].ToString();
        }
    }
}
