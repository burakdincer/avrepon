using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace KatKontrolSistemi.AltinciKat
{
    class AltinciKatDb
    {
        Dosyalar.VeriTabani Dbase = new Dosyalar.VeriTabani();
        //Oda İşlemleri Giriş
        public DataTable Panel2Oda1KisiListesi()
        {
            string sql = "SELECT * FROM PersonelTanitimKarti WHERE KatId='6' AND PanelId='2' AND OdaId='1'";
            DataTable Tablo = Dbase.TabloCek(sql);
            return Tablo;
        }
        public DataTable Panel3Oda1KisiListesi()
        {
            string sql = "SELECT * FROM PersonelTanitimKarti WHERE KatId='6' AND PanelId='3' AND OdaId='1'";
            DataTable Tablo = Dbase.TabloCek(sql);
            return Tablo;
        }
        public DataTable Panel4Oda1KisiListesi()
        {
            string sql = "SELECT * FROM PersonelTanitimKarti WHERE KatId='6' AND PanelId='4' AND OdaId='1'";
            DataTable Tablo = Dbase.TabloCek(sql);
            return Tablo;
        }
        public DataTable Panel5Oda1KisiListesi()
        {
            string sql = "SELECT * FROM PersonelTanitimKarti WHERE KatId='6' AND PanelId='5' AND OdaId='1'";
            DataTable Tablo = Dbase.TabloCek(sql);
            return Tablo;
        }
    }
}
