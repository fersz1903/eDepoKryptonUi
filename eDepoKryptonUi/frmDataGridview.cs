using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;

namespace eDepoKryptonUi
{
    public partial class frmDataGridview : KryptonForm
    {
        SqlConnection con;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        public static string kategori;

        VeriTabaniIslemleri veri = new VeriTabaniIslemleri();
        DataSet dataset;

        public frmDataGridview(string metin)
        {
            InitializeComponent();
            kategori = metin;
        }

        private void textboxDoldur(frmVeriDuzenle frm) // düzenleme formuna düzenlenecek veri gönderimi
        {
            if (kategori.Equals("teknolojikAlet"))
            {
                frm.txt_taMarkaEkle.Text = datagridview.CurrentRow.Cells["marka"].Value.ToString();  //textboxı public yapmalıyız
                frm.txt_taModelEkle.Text=datagridview.CurrentRow.Cells["model"].Value.ToString();
                frm.txt_taTipEkle.Text=datagridview.CurrentRow.Cells["tip"].Value.ToString();
                frm.txt_taFiyatEkle.Text=datagridview.CurrentRow.Cells["fiyat"].Value.ToString();
                frm.txt_taYilEkle.Text = datagridview.CurrentRow.Cells["yil"].Value.ToString();
                frm.txt_taBarkodEkle.Text = datagridview.CurrentRow.Cells["barkod"].Value.ToString();
                frm.txt_taNotEkle.Text = datagridview.CurrentRow.Cells["eklenenNot"].Value.ToString();
            }
            else if (kategori.Equals("araba"))
            {
                frm.txt_ArabaMarkaEkle.Text=datagridview.CurrentRow.Cells["marka"].Value.ToString();
                frm.txt_ArabaModelEkle.Text = datagridview.CurrentRow.Cells["model"].Value.ToString();
                frm.txt_ArabaRenkEkle.Text = datagridview.CurrentRow.Cells["renk"].Value.ToString();
                frm.txt_ArabaKmEkle.Text = datagridview.CurrentRow.Cells["kilometre"].Value.ToString();
                frm.txt_ArabaTipEkle.Text = datagridview.CurrentRow.Cells["tip"].Value.ToString();
                frm.txt_ArabaFiyatEkle.Text = datagridview.CurrentRow.Cells["fiyat"].Value.ToString();
                frm.txt_ArabaYilEkle.Text = datagridview.CurrentRow.Cells["yil"].Value.ToString();
                frm.txt_ArabaBarkodEkle.Text = datagridview.CurrentRow.Cells["barkod"].Value.ToString();
                frm.txt_ArabaNotEkle.Text = datagridview.CurrentRow.Cells["eklenenNot"].Value.ToString();
            }
            else
            {
                frm.txt_EvSehirEkle.Text= datagridview.CurrentRow.Cells["sehir"].Value.ToString();
                frm.txt_EvIlceEkle.Text = datagridview.CurrentRow.Cells["ilce"].Value.ToString();
                frm.txt_EvAdresEkle.Text = datagridview.CurrentRow.Cells["adres"].Value.ToString();
                frm.txt_EvOdaSEkle.Text = datagridview.CurrentRow.Cells["odaSayisi"].Value.ToString();
                frm.txt_EvKatEkle.Text = datagridview.CurrentRow.Cells["kat"].Value.ToString();
                frm.txt_EvMetreEkle.Text = datagridview.CurrentRow.Cells["metreKare"].Value.ToString();
                frm.txt_EvTipEkle.Text = datagridview.CurrentRow.Cells["tip"].Value.ToString();
                frm.txt_EvFiyatEkle.Text = datagridview.CurrentRow.Cells["fiyat"].Value.ToString();
                frm.txt_EvYilEkle.Text = datagridview.CurrentRow.Cells["yil"].Value.ToString();
                frm.txt_EvBarkodEkle.Text = datagridview.CurrentRow.Cells["barkod"].Value.ToString();
                frm.txt_EvNotEkle.Text = datagridview.CurrentRow.Cells["eklenenNot"].Value.ToString();
            }
        }



        private void frmDataGridview_Load(object sender, EventArgs e)
        {
            datagridYenile();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (kategori.Equals("teknolojikAlet"))
            {
                frmVeriDuzenle frm = new frmVeriDuzenle(1,false); // teknolojik alet ekleme
                frm.Show();
            }
            else if (kategori.Equals("araba"))
            {
                frmVeriDuzenle frm = new frmVeriDuzenle(2,false); // araba ekleme
                frm.Show();
            }
            else
            {
                frmVeriDuzenle frm = new frmVeriDuzenle(3,false); // ev ekleme
                frm.Show();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e) // güncelleme kodları yazılmadı 
        {
            if (kategori.Equals("teknolojikAlet"))
            {
                frmVeriDuzenle frm = new frmVeriDuzenle(1, true);// teknolojik güncelleme
                if (datagridview.CurrentRow != null)
                {
                    textboxDoldur(frm);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Ürün Seçili Değil!");
                }
            }
            else if (kategori.Equals("araba"))
            {
                frmVeriDuzenle frm = new frmVeriDuzenle(2, true); // araba güncelleme

                if (datagridview.CurrentRow!=null)
                {
                    textboxDoldur(frm);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Ürün Seçili Değil!");
                }
                
            }
            else
            {
                frmVeriDuzenle frm = new frmVeriDuzenle(3, true); // ev güncelleme
                if (datagridview.CurrentRow != null)
                {
                    textboxDoldur(frm);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Ürün Seçili Değil!");
                }
            }
        }

        private void btn_ara_Click(object sender, EventArgs e) // combobox ayarlandı arama işlevi yapılacak
        {
            frmVeriDuzenle frm = new frmVeriDuzenle(4,false); // false'un bir anlamı yok;

            if (kategori.Equals("teknolojikAlet"))
            {
                frm.cbox_hucreSec.Items.Add("Marka");
                frm.cbox_hucreSec.Items.Add("Model");
                frm.cbox_hucreSec.Items.Add("Tip");
                frm.cbox_hucreSec.Items.Add("Fiyat");
                frm.cbox_hucreSec.Items.Add("Yıl");
                frm.cbox_hucreSec.Items.Add("Barkod");

            }
            else if (kategori.Equals("araba"))
            {
                frm.cbox_hucreSec.Items.Add("Marka");
                frm.cbox_hucreSec.Items.Add("Model");
                frm.cbox_hucreSec.Items.Add("Renk");
                frm.cbox_hucreSec.Items.Add("Kilometre");
                frm.cbox_hucreSec.Items.Add("Tip");
                frm.cbox_hucreSec.Items.Add("Fiyat");
                frm.cbox_hucreSec.Items.Add("Yıl");
                frm.cbox_hucreSec.Items.Add("Barkod");
            }
            else
            {
                frm.cbox_hucreSec.Items.Add("Şehir");
                frm.cbox_hucreSec.Items.Add("İlçe");
                //adrese göre arama yok
                frm.cbox_hucreSec.Items.Add("Oda Sayısı");
                frm.cbox_hucreSec.Items.Add("Kat");
                frm.cbox_hucreSec.Items.Add("Metre Kare");
                frm.cbox_hucreSec.Items.Add("Tip");
                frm.cbox_hucreSec.Items.Add("Fiyat");
                frm.cbox_hucreSec.Items.Add("Yil");
                frm.cbox_hucreSec.Items.Add("Barkod");
            }
            frm.Show();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (datagridview.CurrentRow != null)
            {
                veri.urunSil(datagridview.CurrentRow.Cells["barkod"].Value.ToString()); // barkodu eşleşen ürünü siler
            }
            else
            {
                MessageBox.Show("Ürün seçili değil!");
            }
            datagridYenile(); // ürün silindikten sonra datagrid yenilenir.
        }

        public void datagridYenile() // datagride veri tabanından verileri çeker
        {
            dataset = veri.dataGridDoldur();
            datagridview.DataSource = dataset.Tables[kategori];
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            datagridYenile();
        }

        public void urunAra(string ara)
        {
            for(int i=0; i < datagridview.Rows.Count; i++)
            {
                foreach(DataGridViewRow row in datagridview.Rows)
                {
                    foreach(DataGridView cell in row.Cells)
                    {
                        if (cell.ToString().Equals(ara)){
                            row.Selected = true;
                        }
                    }
                }
            }
        }
    }
}
