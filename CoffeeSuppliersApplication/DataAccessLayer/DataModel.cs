using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.

namespace DataAccessLayer
{
    internal class DataModel
    {
        SqlConnection con;
        SqlCommand cmd;
        public VeriModeli()
        {
            con = new SqlConnection(ConnectionStrings.veriyolu);
            cmd = con.CreateCommand();
        }
        public void KahveEkle(Kahveler kahv)
        {
            cmd.CommandText = "INSERT INTO Kahveler(Isim, Satici, UreticiUlke, Fiyat, Stok, Satistami) VALUES (@isim, @satici, @ureticiUlke, @fiyat, @stok, @satistami)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@isim", kahv.Isim);
            cmd.Parameters.AddWithValue("@satici", kahv.Satici);
            cmd.Parameters.AddWithValue("@ureticiUlke", kahv.UreticiUlke);
            cmd.Parameters.AddWithValue("@fiyat", kahv.fiyat);
            cmd.Parameters.AddWithValue("@stok", kahv.stok);
            cmd.Parameters.AddWithValue("@satistami", kahv.satistami);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void SaticiEkle(Saticilar sat)
        {
            cmd.CommandText = "INSERT INTO Saticilar(Isim) VALUES (@isim)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@isim", sat.Isim);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UreticiUlkeEkle(UreticiUlkeler ulk)
        {
            cmd.CommandText = "INSERT INTO UreticiUlkeler(Isim) VALUES (@isim)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@isim", ulk.Isim);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void AlicilarEkle(Alicilar al)
        {
            cmd.CommandText = "INSERT INTO Alicilar(Isim) VALUES (@isim)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@isim", al.Isim);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<Kahveler> KahveleriGetir()
        {
            List<Kahveler> kahvelers = new List<Kahveler>();
            cmd.CommandText = "SELECT ID, Isim, Satici, UreticiUlkeler, Stok, Fiyat FROM Kahveler ORDER BY ID";
            cmd.Parameters.Clear();
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Kahveler kahv = new Kahveler();
                kahv.ID = reader.GetInt32(0);
                kahv.Isim = reader.GetString(1);
                kahv.Satici = reader.GetString(2);
                kahv.UreticiUlke = reader.GetString(3);
                kahv.stok = reader.GetInt32(4);
                kahv.fiyat = reader.GetDecimal(5);
                kahvelers.Add(kahv);
            }
            con.Close();
            return kahvelers;
        }
}
