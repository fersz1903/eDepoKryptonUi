using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace eDepoKryptonUi
{
    internal class VeriTabaniIslemleri
    {
        SqlConnection con;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        public static string kategori;
        

        public VeriTabaniIslemleri()
        {
            con = new SqlConnection(connectionStringOlustur());
        }

        
        string connectionStringOlustur()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            builder.InitialCatalog = "eDepo";
            builder.UserID = "sa";
            builder.Password = "1";
            return builder.ConnectionString;
        }

        public DataSet dataGridDoldur()
        {
            con.Open();
            adapter = new SqlDataAdapter("select * from "+kategori,con);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, kategori);
            con.Close();
            return dataSet;
        }

        public void urunSil(string barkod)
        {
            con.Open();
            cmd = new SqlCommand("delete " + kategori + " where barkod=" + barkod, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void urunEkle(List<string> ls )
        {
            con.Open();
            string command;
            
            if (kategori.Equals("teknolojikAlet"))
            {
                command = "insert into " + kategori + " values (@marka,@model,@tip," +
                    "@fiyat,@yil,@barkod,@not)";
                cmd = new SqlCommand(command, con);

                cmd.Parameters.AddWithValue("@marka",ls[0].ToString().ToLower());
                cmd.Parameters.AddWithValue("@model", ls[1].ToString().ToLower());
                cmd.Parameters.AddWithValue("@tip", ls[2].ToString().ToLower());
                cmd.Parameters.AddWithValue("@fiyat", ls[3].ToString().ToLower());
                cmd.Parameters.AddWithValue("@yil", ls[4].ToString().ToLower());
                cmd.Parameters.AddWithValue("@barkod", ls[5].ToString().ToLower());
                cmd.Parameters.AddWithValue("@not", ls[6].ToString().ToLower());

                cmd.ExecuteNonQuery();


            }
            else if (kategori.Equals("araba")) 
            {
                command = "insert into " + kategori + " values (@marka,@model,@renk,@km,@tip," +
                    "@fiyat,@yil,@barkod,@not)";
                cmd = new SqlCommand(command, con);

                cmd.Parameters.AddWithValue("@marka", ls[0].ToString().ToLower());
                cmd.Parameters.AddWithValue("@model", ls[1].ToString().ToLower());
                cmd.Parameters.AddWithValue("@renk", ls[2].ToString().ToLower());
                cmd.Parameters.AddWithValue("@km", ls[3].ToString().ToLower());
                cmd.Parameters.AddWithValue("@tip", ls[4].ToString().ToLower());
                cmd.Parameters.AddWithValue("@fiyat", ls[5].ToString().ToLower());
                cmd.Parameters.AddWithValue("@yil", ls[6].ToString().ToLower());
                cmd.Parameters.AddWithValue("@barkod", ls[7].ToString().ToLower());
                cmd.Parameters.AddWithValue("@not", ls[8].ToString().ToLower());
                
                cmd.ExecuteNonQuery();
            }
            else
            {
                command = "insert into " + kategori + " values (@sehir,@ilce,@adres,@oda,@kat,@metre,@tip," +
                    "@fiyat,@yil,@barkod,@not)";
                cmd = new SqlCommand(command, con);

                cmd.Parameters.AddWithValue("@sehir", ls[0].ToString().ToLower());
                cmd.Parameters.AddWithValue("@ilce", ls[1].ToString().ToLower());
                cmd.Parameters.AddWithValue("@adres", ls[2].ToString().ToLower());
                cmd.Parameters.AddWithValue("@oda", ls[3].ToString().ToLower());
                cmd.Parameters.AddWithValue("@kat", ls[4].ToString().ToLower());
                cmd.Parameters.AddWithValue("@metre", ls[5].ToString().ToLower());
                cmd.Parameters.AddWithValue("@tip", ls[6].ToString().ToLower());
                cmd.Parameters.AddWithValue("@fiyat", ls[7].ToString().ToLower());
                cmd.Parameters.AddWithValue("@yil", ls[8].ToString().ToLower());
                cmd.Parameters.AddWithValue("@barkod", ls[9].ToString().ToLower());
                cmd.Parameters.AddWithValue("@not", ls[10].ToString().ToLower());

                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        public void urunGuncelle(List<string> ls , string barkod)
        {
            string command;
            con.Open();
            if (kategori.Equals("teknolojikAlet"))
            {
                command = "update " + kategori + " set marka=@marka , model=@model , tip=@tip , " +
                    "fiyat=@fiyat , yil=@yil , barkod=@barkod , eklenenNot=@not where barkod="+barkod;

                cmd = new SqlCommand(command, con);

                cmd.Parameters.AddWithValue("@marka", ls[0].ToString().ToLower());
                cmd.Parameters.AddWithValue("@model", ls[1].ToString().ToLower());
                cmd.Parameters.AddWithValue("@tip", ls[2].ToString().ToLower());
                cmd.Parameters.AddWithValue("@fiyat", ls[3].ToString().ToLower());
                cmd.Parameters.AddWithValue("@yil", ls[4].ToString().ToLower());
                cmd.Parameters.AddWithValue("@barkod", ls[5].ToString().ToLower());
                cmd.Parameters.AddWithValue("@not", ls[6].ToString().ToLower());

                cmd.ExecuteNonQuery();
            }
            else if (kategori.Equals("araba"))
            {
                command = "update " + kategori + " set marka=@marka , model=@model , renk=@renk , " +
                    "kilometre=@km , tip=@tip , fiyat=@fiyat , yil=@yil , barkod=@barkod , " +
                    "eklenenNot=@not where barkod="+barkod;
            }
            else
            {
                command = "update " + kategori + " set sehir=@sehir , ilce=@ilce , adres=@adres , " +
                    "odaSayisi=@oda , kat=@kat , metreKare=@metre , tip=@tip , fiyat=@fiyat , " +
                    "yil=@yil , barkod=@barkod , eklenenNot=@not where barkod="+barkod;
            }
            con.Close();
        }     

        public void urunAra(string ara)
        {
            con.Open();
            cmd = new SqlCommand("select * from " + kategori + "where "); // nerde aranacağı önemli 


            if (kategori.Equals("teknolojikAlet"))
            {
                
            }
            else if (kategori.Equals("araba"))
            {

            }
            else
            {

            }
        }
    }
}
