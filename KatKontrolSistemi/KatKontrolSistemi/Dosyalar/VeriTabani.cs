using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql;
using MySql.Data.MySqlClient;
namespace KatKontrolSistemi.Dosyalar
{
    class VeriTabani
    {
        public MySqlConnection Baglan()
        {
            string provider = "Server=94.73.170.220;Database=AUKatSistemi;Uid=Dibb;Pwd=DIbb12345";
            MySqlConnection conn = new MySqlConnection(provider);
            conn.Open();
            return conn;
            //try
            //{

            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Sunucu İle Bağlantı Kurulamadı");
            //}
        }
        public void Isle(string sql)
        {
            MySqlCommand Islem = new MySqlCommand(sql, this.Baglan());
            Islem.ExecuteNonQuery();
        }
        public DataTable TabloCek(string sql)
        {
            DataTable tb = new DataTable();
            MySqlDataAdapter adap = new MySqlDataAdapter(sql, this.Baglan());
            adap.Fill(tb);
            return tb;
        }
        public DataSet DataSetCek(string sql)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter adap = new MySqlDataAdapter(sql, this.Baglan());
            adap.Fill(ds);
            return ds;
        }
        public DataRow SatirCek(string sql)
        {
            DataRow satir = TabloCek(sql).Rows[0];
            return satir;
        }
        public DataSet DataSetCek(string sql, string tablo)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter adap = new MySqlDataAdapter(sql, this.Baglan());
            adap.Fill(ds, tablo);
            return ds;
        }
    }
}
