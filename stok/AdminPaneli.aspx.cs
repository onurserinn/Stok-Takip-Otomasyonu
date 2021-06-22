using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace StokTakipOtomasyonu
{

    public partial class AdminPaneli : System.Web.UI.Page
    {
        string connectionString = "server=localhost;user id=root;database=stoktakip;Password=00000000";
        protected void Page_Load(object sender, EventArgs e)
        {
            GridFill(urunGridView, "TumUrunleriListele");
            GridFill(musteriGridView, "TumMusterileriListele");
        }

        protected void urunEkleBTN_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
                {
                    sqlCon.Open();
                    MySqlCommand sqlCmd = new MySqlCommand("UrunEkleGuncelle", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("_urun_id", 0);
                    sqlCmd.Parameters.AddWithValue("_urun_ad", urunAdiTXT.Text);
                    sqlCmd.Parameters.AddWithValue("_urun_aciklama", urunAciklamaText.Text);
                    sqlCmd.Parameters.AddWithValue("_urun_fiyat", urunFiyatText.Text);
                    sqlCmd.ExecuteNonQuery();

                    UrunClear();
                    GridFill(urunGridView, "TumUrunleriListele");
                    urunBilgiLabel.Text = "Ürün eklendi.";
                }
            }
            catch (Exception ex)
            {
                urunBilgiLabel.Text = ex.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
                {
                    sqlCon.Open();
                    MySqlCommand sqlCmd = new MySqlCommand("UrunEkleGuncelle", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("_urun_id", int.Parse(txtUrunId.Text));
                    sqlCmd.Parameters.AddWithValue("_urun_ad", urunAdiTXT.Text);
                    sqlCmd.Parameters.AddWithValue("_urun_aciklama", urunAciklamaText.Text);
                    sqlCmd.Parameters.AddWithValue("_urun_fiyat", urunFiyatText.Text);
                    sqlCmd.ExecuteNonQuery();

                    UrunClear();
                    GridFill(urunGridView, "TumUrunleriListele");
                    urunBilgiLabel.Text = "Ürün Güncellendi.";
                }
            }
            catch (Exception ex)
            {
                urunBilgiLabel.Text = ex.Message;
            }
        }

        private void GridFill(GridView gridView, string procedure)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            {
                sqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter(procedure, sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                gridView.DataSource = dt;
                gridView.DataBind();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            {
                sqlCon.Open();
                MySqlCommand sqlCmd = new MySqlCommand("IDileUrunSil", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("_urun_id", int.Parse(txtUrunId.Text));
                sqlCmd.ExecuteNonQuery();

                UrunClear();
                GridFill(urunGridView, "TumUrunleriListele");
                urunBilgiLabel.Text = "Urun silindi.";
            }
        }

        private void UrunClear()
        {
            urunAdiTXT.Text = null;
            urunAciklamaText.Text = null;
            urunAciklamaText.Text = null;
            txtUrunId.Text = "id";
        }

        private void MusteriClear()
        {
            musteriAdiText.Text = null;
            txtMusteriId.Text = "id";
            TextBox1.Text = null;
        }

        protected void musteriEkleBTN_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
                {
                    sqlCon.Open();
                    MySqlCommand sqlCmd = new MySqlCommand("MusteriEkleGuncelle", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("_musteri_id", 0);
                    sqlCmd.Parameters.AddWithValue("_musteri_adsoyad", musteriAdiText.Text);
                    sqlCmd.ExecuteNonQuery();

                    MusteriClear();
                    GridFill(musteriGridView, "TumMusterileriListele");
                    musteriBilgiLabel.Text = "Müşteri eklendi.";
                }
            }
            catch (Exception ex)
            {
                musteriBilgiLabel.Text = ex.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
                {
                    sqlCon.Open();
                    MySqlCommand sqlCmd = new MySqlCommand("MusteriEkleGuncelle", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("_musteri_id", int.Parse(txtMusteriId.Text));
                    sqlCmd.Parameters.AddWithValue("_musteri_adsoyad", musteriAdiText.Text);
                    sqlCmd.ExecuteNonQuery();

                    MusteriClear();
                    GridFill(musteriGridView, "TumMusterileriListele");
                    musteriBilgiLabel.Text = "Müşteri güncellendi.";
                }
            }
            catch (Exception ex)
            {
                musteriBilgiLabel.Text = ex.Message;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            {
                sqlCon.Open();
                MySqlCommand sqlCmd = new MySqlCommand("IDileMusteriSil", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("_musteri_id", int.Parse(txtMusteriId.Text));
                sqlCmd.ExecuteNonQuery();

                MusteriClear();
                GridFill(musteriGridView, "TumMusterileriListele");
                musteriBilgiLabel.Text = "Müşteri silindi.";
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            {
                sqlCon.Open();
                MySqlCommand sqlCmd = new MySqlCommand("MusteriyeUrunVer", sqlCon);
                MySqlCommand sqlCmd2 = new MySqlCommand("IDileUrunSil", sqlCon);



                sqlCmd2.CommandType = CommandType.StoredProcedure;
                sqlCmd2.Parameters.AddWithValue("_urun_id", int.Parse(TextBox1.Text));


                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("_musteri_id", int.Parse(txtMusteriId.Text));
                sqlCmd.Parameters.AddWithValue("_urun_id", int.Parse(TextBox1.Text));
                sqlCmd.Parameters.AddWithValue("_date", DateTime.Now.ToString("dddd, dd MMMM yyyy"));


                sqlCmd.ExecuteNonQuery();
                sqlCmd2.ExecuteNonQuery();


                UrunClear();
                MusteriClear();

                GridFill(urunGridView, "TumUrunleriListele");
                GridFill(musteriGridView, "TumMusterileriListele");
                urunBilgiLabel.Text = "Müşteriye ürün satıldı.";
                musteriBilgiLabel.Text = "Müşteriye ürün satıldı.";
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            {
                sqlCon.Open();
                MySqlCommand sqlCmd = new MySqlCommand("IDileUrunEkleIadeAl", sqlCon);
                MySqlCommand sqlCmd2 = new MySqlCommand("MusteridenUrunAl", sqlCon);




                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd2.CommandType = CommandType.StoredProcedure;



                sqlCmd2.Parameters.AddWithValue("_musteri_id", txtMusteriIadeID.Text);

                sqlCmd.Parameters.AddWithValue("_urun_id", txtUrunId.Text);
                sqlCmd.Parameters.AddWithValue("_urun_ad", urunAdiTXT.Text);
                sqlCmd.Parameters.AddWithValue("_urun_aciklama", urunAciklamaText.Text);
                sqlCmd.Parameters.AddWithValue("_urun_fiyat", urunFiyatText.Text);



                sqlCmd2.ExecuteNonQuery();
                sqlCmd.ExecuteNonQuery();

                MusteriClear();
                UrunClear();
                GridFill(musteriGridView, "TumMusterileriListele");
                GridFill(urunGridView, "TumUrunleriListele");
                urunBilgiLabel.Text = "Ürün iade alındı.";
                musteriBilgiLabel.Text = "Müşteriden ürün iade alındı.";
            }
        }
    }
}